using KBCsv;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DirectoryDump
{
    public partial class DumpForm : Form
    {
        private const string CREATED_DATE = "Created date";
        private const string UPDATED_DATE = "Updated date";
        private const string FILE_NAME = "File name";
        private const string OUTPUT = "output";
        public event Action<int, int> OnFileRemoveCompleted;
        public event Action<string> OnNotification;

        public DumpForm()
        {
            InitializeComponent();

            //DirTextBox.ReadOnly = true;
            radioText.Checked = true;
            comboOrder.Items.Add(CREATED_DATE);
            comboOrder.Items.Add(UPDATED_DATE);
            comboOrder.Items.Add(FILE_NAME);

            comboOrder.SelectedIndex = 2;

            openOutputFolderToolItem.Click += buttonOpenOutputFolder_Click;
            browseToolItem.Click += BrowseButton_Click;
            buttonDelete.Click += ButtonDelete_Click;
            OnFileRemoveCompleted += DumpForm_OnFileRemoveCompleted;
            OnNotification += DumpForm_OnNotification;
        }

        private void DumpForm_OnNotification(string message)
        {
            statusBar.Invoke(new Action(() =>
            {
                labelStatus.Text = message;
            }));
        }

        private void DumpForm_OnFileRemoveCompleted(int deleted, int total)
        {   
            labelDeleteReport.Invoke(new Action(() =>
            {
                labelDeleteReport.Text = $"{deleted}/{total} files were deleted";
            }));
        }

        private async void ButtonDelete_Click(object sender, EventArgs e)
        {
            labelDeleteReport.Text = string.Empty;
            var date = dateDelete.Value;
            var includeDate = ckbIncludeRemoveDate.Checked; // if include, remove `date` files as well

            var can = CanI(out string dir);
            if (!can)
                return;

            var files = DirDump(dir);
            if (files.Count == 0)
                return;

            var totalFile = files.Count;
            var totalDeleted = 0;

            var deleteFiles = files.Where(x => x.LastModified.Date < date.Date || (x.LastModified.Date == date.Date && includeDate)).ToList();

            foreach (var file in deleteFiles)
            {
                await Task.Delay(100);

                if (DeleteFile(file.Path))
                    totalDeleted++;

                OnFileRemoveCompleted?.Invoke(totalDeleted, totalFile);
                OnNotification?.Invoke($"Deleting {file.Name}...");
            }

            Debug.WriteLine($"Total {totalDeleted} files were deleted");
            var text = $"{totalDeleted}/{totalFile} files were deleted";
            labelDeleteReport.Text = text;
            labelStatus.Text = text;
            MessageBox.Show($"{totalDeleted}/{totalFile} files were deleted", "Completed");
        }

        private bool DeleteFile(string path)
        {
            try
            {
                File.Delete(path);
                Debug.WriteLine($"File {path} was deleted!");
                return true;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message + e.StackTrace);
                MessageBox.Show(e.Message, "Delete error");
            }

            return false;
        }

        private void buttonOpenOutputFolder_Click(object sender, EventArgs e)
        {
            var output = Path.Combine(Environment.CurrentDirectory, OUTPUT);
            if (!Directory.Exists(output))
                MessageBox.Show("'" + output + "' is not exist");
            else
                System.Diagnostics.Process.Start(output);
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            var dialog = folderBrowser.ShowDialog();
            if (dialog != System.Windows.Forms.DialogResult.OK)
                return;

            var folder = folderBrowser.SelectedPath;
            DirTextBox.Text = folder;
        }

        private List<string> DirSearch(string sDir)
        {
            List<string> files = new List<string>();
            try
            {
                foreach (string f in Directory.GetFiles(sDir))
                {
                    files.Add(f);
                }
                foreach (string d in Directory.GetDirectories(sDir))
                {
                    files.AddRange(DirSearch(d));
                }
            }
            catch (System.Exception excpt)
            {
                MessageBox.Show(excpt.Message);
            }

            return files;
        }

        private List<DumpInfo> DirDump(string dir, bool relativePath=false)
        {
            var dumps = new List<DumpInfo>();

            try
            {
                // search all file
                foreach (var f in Directory.GetFiles(dir))
                {
                    var fi = new FileInfo(f);
                    var di = new DumpInfo
                    {
                        CreatedDate = fi.CreationTime,
                        LastModified = fi.LastWriteTime,
                        Path = relativePath ? fi.FullName.Replace(fi.DirectoryName,string.Empty) : fi.FullName,
                        Name = fi.Name
                    };
                    dumps.Add(di);
                }

                // search all folder
                foreach (var d in Directory.GetDirectories(dir))
                {
                    dumps.AddRange(DirDump(d));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return dumps;
                
        }

        private async void DumpButton_Click(object sender, EventArgs e)
        {
            var folder = DirTextBox.Text;
            if (string.IsNullOrEmpty(folder))
            {
                MessageBox.Show("browse a directory, mother f*cker");
                return;
            }

            if (!Directory.Exists(folder))
            {
                MessageBox.Show("This folder is not exist, baka");
                return;
            }

            DumpButton.Text = "Writing..";
            var folderName = new DirectoryInfo(folder).Name; // Path.GetFileName(Path.GetDirectoryName(folder)); 

            var files = DirDump(folder);
            var order = comboOrder.SelectedText;

            if (order == CREATED_DATE)
                files = files.OrderByDescending(f => f.CreatedDate).ToList();
            if (order == UPDATED_DATE)
                files = files.OrderByDescending(f => f.LastModified).ToList();
            if (order == FILE_NAME)
                files = files.OrderByDescending(f => f.Path).ToList();

            // create sub folder
            var output = "output";
            if (!Directory.Exists(output))
                Directory.CreateDirectory(output);
            
            var filename = string.Format("dump-{1}-{0}", folderName, DateTime.Now.ToString("dd-MM-yyyy-hh-mm-ss"));
            filename = Path.Combine(output, filename);

            if (radioText.Checked) // text
            {
                filename += ".txt";

                var names = files.Select(f => f.Path).ToList();
                File.WriteAllLines(filename, names, Encoding.UTF8);
            }
            else // csv
            {
                filename += ".csv";

                using (var streamWriter = new StreamWriter(filename))
                using (var writer = new CsvWriter(streamWriter))
                {
                    writer.ForceDelimit = true;

                    writer.WriteRecord("Created Date", "Last Modified", "Name");
                    foreach (var f in files)
                    {
                        await writer.WriteRecordAsync(
                            f.CreatedDate.ToString("MM/dd/yyyy hh:mm:ss tt"),
                            f.LastModified.ToString("MM/dd/yyyy hh:mm:ss tt"),
                            f.Path);

                        /*
                        await writer.WriteRecordAsync("Created Date", f.CreatedDate.ToString("MM/dd/yyyy hh:mm tt"));
                        await writer.WriteRecordAsync("Last Modified", f.LastModified.ToString("MM/dd/yyyy hh:mm tt"));
                        await writer.WriteRecordAsync("Name", f.Name);
                        */
                    }
                }
            }
            
            DumpButton.Text = "Dump";
            if (checkOpenWhenDone.Checked && File.Exists(filename))
                System.Diagnostics.Process.Start(filename);

            MessageBox.Show("done!");
        }

        private bool CanI(out string dir)
        {
            dir = DirTextBox.Text;
            if (string.IsNullOrEmpty(dir))
            {
                MessageBox.Show("browse a directory, mother f*cker");
                return false;
            }

            if (!Directory.Exists(dir))
            {
                MessageBox.Show("This folder is not exist, baka");
                return false;
            }

            return true;
        }
    }
}
