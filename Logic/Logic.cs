using System;
using System.IO;

namespace DateSeparator.Logic
{
    public class Logic : ILogic
    {
        public void CopyIntoEveryMonth(string sourcePath, string targetPath)
        {


            CreateFile(targetPath);


            var filesToHandle = new DirectoryInfo(sourcePath);


            var files = filesToHandle.GetFiles("*.*", SearchOption.AllDirectories);


            foreach (var fileInfo in files)
            {
                //Console.WriteLine(fileInfo + " and the creation date is ; " + fileInfo.LastWriteTime);
                var newTargetWithYearAndMonth = targetPath + @"\" + fileInfo.LastWriteTime.Year + @"\" + (Static.Months)(fileInfo.LastWriteTime.Month - 1);
                CreateFile(newTargetWithYearAndMonth);
                File.Copy(fileInfo.DirectoryName + @"\" + fileInfo.Name, newTargetWithYearAndMonth + @"\" + fileInfo.Name, true);
            }
        }

        public void CopyIntoEvery3Month(string sourcePath, string targetPath)
        {
            CreateFile(targetPath);


            var filesToHandle = new DirectoryInfo(sourcePath);


            var files = filesToHandle.GetFiles("*.*", SearchOption.AllDirectories);


            foreach (var fileInfo in files)
            {


                var newTargetWithYear = targetPath + @"\" + fileInfo.LastWriteTime.Year;

                var month = fileInfo.LastWriteTime.Month;

                string newTargetWithYearWithMonth = "";

                string months = "";

                if (month == 1 || month == 2 || month == 3)
                {
                    months = Static.Months.January + "-" + Static.Months.February + "-" + Static.Months.March;
                    newTargetWithYearWithMonth = newTargetWithYear + @"\" + months;

                }
                else if (month == 4 || month == 5 || month == 6)
                {
                    months = Static.Months.April + "-" + Static.Months.May + "-" + Static.Months.June;

                    newTargetWithYearWithMonth = newTargetWithYear + @"\" + months;
                }
                else if (month == 7 || month == 8 || month == 9)
                {
                    months = Static.Months.July + "-" + Static.Months.August + "-" + Static.Months.September;

                    newTargetWithYearWithMonth = newTargetWithYear + @"\" + months;
                }
                else if (month == 10 || month == 11 || month == 12)
                {
                    months = Static.Months.October + "-" + Static.Months.November + "-" + Static.Months.December;

                    newTargetWithYearWithMonth = newTargetWithYear + @"\" + months;
                }

                CreateFile(newTargetWithYearWithMonth);
                File.Copy(fileInfo.DirectoryName + @"\" + fileInfo.Name, newTargetWithYearWithMonth + @"\" + fileInfo.Name, true);

            }
        }

        public void CopyIntoYears(string sourcePath, string targetPath)
        {
            CreateFile(targetPath);


            var filesToHandle = new DirectoryInfo(sourcePath);


            var files = filesToHandle.GetFiles("*.*", SearchOption.AllDirectories);


            foreach (var fileInfo in files)
            {
                //Console.WriteLine(fileInfo + " and the creation date is ; " + fileInfo.LastWriteTime);
                var newTargetWithYear = targetPath + @"\" + fileInfo.LastWriteTime.Year;
                CreateFile(newTargetWithYear);
                File.Copy(fileInfo.DirectoryName + @"\" + fileInfo.Name, newTargetWithYear + @"\" + fileInfo.Name, true);
            }
        }
        public void CreateFile(String path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);

            }
        }

    }
}
