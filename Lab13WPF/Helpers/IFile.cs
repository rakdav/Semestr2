using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13WPF.Helpers
{
    interface IFile
    {
        void Save(string filename);
        void SaveAs(string filename);
        void Open(string filename);
    }
}
