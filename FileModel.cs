using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UploaderContent
{
    public class FileModel
    {
        public string Key { get; set; }
        public DateTime LastModified { get; set; }
        public long Size { get; set; }
    }
}
