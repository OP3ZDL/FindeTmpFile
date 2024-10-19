using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class TmpFile
    {
        public string Name { get; set; }
        public string Path { get; set; }

        public TmpFile(string name, string path)
        {
            Name = name;
            Path = path;
        }
        public bool CreateF()
        { 
           string PN = Path + Name;
           File.Create(PN);
           return File.Exists(PN);

        }
    }
}
