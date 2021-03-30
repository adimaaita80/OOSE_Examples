using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplainingAssociations
{
    public class Folder
    {
        public int FolderId { get; set; }
        public string FolderName { get; set; }
        ICollection<File> Files { get; set; }

        public Folder()
        {
            Files = new List<File>();
        }
    }
}
