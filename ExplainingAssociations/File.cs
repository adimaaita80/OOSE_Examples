using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplainingAssociations
{
    public class File
    {
        public int FileId { get; set; }
        public string FileName { get; set; }
        public int FolderId { get; set; }
        public Folder Folder { get; set; }

    }
}
