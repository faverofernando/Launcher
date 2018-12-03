using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Launcher.Model
{
    public class Arquivos
    {
        public int fileID { get; set; }

        public string fileHash { get; set; }

        public string filePath { get; set; }

        public bool toUpdate { get; set; }
    }
}
