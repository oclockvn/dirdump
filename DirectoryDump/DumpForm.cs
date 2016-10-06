using KBCsv;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DirectoryDump
{
    public partial class DumpForm : Form
    {
        private const string CREATED_DATE = "Created date";
        private const string UPDATED_DATE = "Updated date";
        private const string FILE_NAME = "File name";
        private const string OUTPUT = "output";

        public DumpForm()
        {
            InitializeComponent();

            //DirTextBox.ReadOnly = true;
            radioText.Checked = true;
            comboOrder.Items.Add(CREATED_DATE);
            comboOrder.Items.Add(UPDATED_DATE);
            comboOrder.Items.Add(FILE_NAME);

            comboOrder.SelectedIndex = 2;

            buttonOpenOutputFolder.Click += buttonOpenOutputFolder_Click;
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

        private List<DumpInfo> DirDump(string dir)
        {
            var dumps = new List<DumpInfo>();

            try
            {
                // search all file
                foreach (var f in Directory.GetFiles(dir))
                {
                    var fi = new FileInfo(f);
                    var di = new DumpInfo()
                    {
                        CreatedDate = fi.CreationTime,
                        LastModified = fi.LastWriteTime,
                        Name = fi.FullName
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
                files = files.OrderByDescending(f => f.Name).ToList();

            // create sub folder
            var output = "output";
            if (!Directory.Exists(output))
                Directory.CreateDirectory(output);
            
            var filename = string.Format("dump-{1}-{0}", folderName, DateTime.Now.ToString("dd-MM-yyyy-hh-mm-ss"));
            filename = Path.Combine(output, filename);

            if (radioText.Checked) // text
            {
                filename += ".txt";

                var names = files.Select(f => f.Name).ToList();
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
                            f.Name);

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
    }
}
