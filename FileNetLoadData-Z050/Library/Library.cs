using System;
using System.Collections;
using System.IO;

using FileNetLoadData.FileNet;
using FileNetLoadData_Z050.FileNet;
using FileNetLoadData_Z050.Model;


namespace FileNetLoadData_Z050
{
    public class Library
    {
        public static void LoadDataZ050(string path, CEConnection ce)
        {
            Z050Info info = new Z050Info();
            info = AnalyticalXML.LinqReadXML(path);
            FileNetApi.UploadFileToFileNet(true, path, info, ce);
        }

        public static ArrayList GetFileName(string dirPath)
        {
            ArrayList list = new ArrayList();
            if (Directory.Exists(dirPath))
                list.AddRange(Directory.GetFiles(dirPath));
            return list;
        }


        /// <summary>
        /// 已重载.计算两个日期的时间间隔,返回的是时间间隔的日期差的绝对值.
        /// </summary>
        /// <param name="dt1">第一个日期和时间</param>
        /// <param name="dt2">第二个日期和时间</param>
        /// <returns></returns>
        public static string DateDiff(DateTime dt1, DateTime dt2)
        {
            string dateDiff = null;
            try
            {
                TimeSpan ts1 = new TimeSpan(dt1.Ticks);
                TimeSpan ts2 = new TimeSpan(dt2.Ticks);
                TimeSpan ts = ts1.Subtract(ts2).Duration();
                dateDiff = ts.Days.ToString() + "天"
                        + ts.Hours.ToString() + "小时"
                        + ts.Minutes.ToString() + "分钟"
                        + ts.Seconds.ToString() + "秒"
                        + ts.Milliseconds.ToString() + "毫秒";
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dateDiff;
        }
    }
}
