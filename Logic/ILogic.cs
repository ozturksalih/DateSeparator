using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateSeparator.Logic
{
    public interface ILogic
    {
        void CopyIntoEveryMonth(string sourcePath, string targetPath);
        void CopyIntoEvery3Month(string sourcePath, string targetPath);
        void CopyIntoYears(string sourcePath, string targetPath);
        void CreateFile(String path);
    }
}
