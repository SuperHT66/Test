using System;
using System.Collections;
using System.Configuration;

using FileNetLoadData.FileNet;
using FileNetLoadData_Z050.FileNet;

namespace FileNetLoadData_Z050
{
    class Program
    {
        private static string dirPath = ConfigurationManager.AppSettings["DirPath"].ToString();
        private static CEConnection ce;
        
        static void Main(string[] args)
        {
            #region  方式1
            string file = string.Empty;
            string singleTime = string.Empty;
            DateTime allBeginTime = DateTime.Now;
            ce = FileNetApi.ConnectionCE();
            ArrayList list = Library.GetFileName(dirPath);
            for (int i = 0; i < list.Count; i++)
            {
                DateTime beginTime = DateTime.Now;
                file = list[i].ToString();
                Library.LoadDataZ050(file, ce);
                DateTime endTime = DateTime.Now;
                singleTime = Library.DateDiff(beginTime, endTime);
                Console.WriteLine("文件" + file + "上传成功，耗时:" + singleTime + "");
            }
            DateTime allEndTime = DateTime.Now;
            Console.WriteLine("文件全部上传成功，耗时:" + Library.DateDiff(allBeginTime, allEndTime) + "");
            Console.ReadKey();
            #endregion
        }


    }
}
