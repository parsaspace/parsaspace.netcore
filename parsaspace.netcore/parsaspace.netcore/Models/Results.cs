using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace parsaspace.netcore.Models
{
    public class Results
    {
        public class ApiResult
        {
            public string Result { get; set; }
            public string Message { get; set; }
        }
        public class FileListResult
        {
            public string Result { get; set; }
            public FileListItemResult[] List { get; set; }

        }

        public class FileListItemResult
        {
            public string Name { get; set; }
            public bool IsFolder { get; set; }
            public string Size { get; set; }
            public string LastModified { get; set; }

        }
        public class UploadResult
        {
            public string DownloadLink { get; set; }
            public string Result { get; set; }
        }
    }
}