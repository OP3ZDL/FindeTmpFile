using System;
using System.Collections.Generic;
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
    }
}
