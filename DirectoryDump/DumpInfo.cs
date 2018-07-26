using System;
using System.Diagnostics;

namespace DirectoryDump
{
    [DebuggerDisplay("{Name} : {LastModified}")]
    public class DumpInfo
    {
        public string Path { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastModified { get; set; }
    }
}
