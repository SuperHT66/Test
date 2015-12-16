using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;

using FileNetLoadData_Z050.Model;


namespace FileNetLoadData_Z050
{
    public class AnalyticalXML
    {
        #region 解析XML
        /// <summary>
        /// Linq To XML
        /// </summary>
        public static Z050Info LinqReadXML(string filePath)
        {
            Dictionary<string, object> dir = new Dictionary<string, object>();
            Z050Info info = new Z050Info();
            XDocument xdoc = XDocument.Load(filePath);
            var text = from t in xdoc.Descendants("MT_MATS")
                       select new
                       {
                           MAT_CODE = t.Element("MAT_GLDN_NUM").Value,
                           MAT_NAME = t.Element("MAT_GLDN_DESC_LONG_CN").Value,
                           REL_TIME = DateTime.Now,
                           IS_SPEC = t.Element("FUN_SPEC_TAG").Value,
                           FRE_IDE = t.Element("FUN_STOP_TAG").Value,
                           DEL_DATA = t.Element("FUN_DEL_TAG").Value,
                           QUA_EXC = t.Element("FUN_DQ_EXC_TAG").Value,
                           MAT_CLA_CODE = (from c in t.Elements("MAT_GROUP")
                                           select new {
                                               GROUP_CODE = c.Element("GROUP_CODE").Value,
                                               GROUP_NAME = c.Element("GROUP_NAME").Value,
                                           }
                                             ).ToArray(),

                                    
                           SYS_ID = from s in t.Elements("FUN_MIS_TAG").Elements("SYSTEM")
                                    select s,        
                       };

            foreach (var item in text)
            {
                info.MAT_CODE = item.MAT_CODE;
                info.MAT_NAME = item.MAT_NAME;
                foreach (var sys in item.SYS_ID)
                {
                    var q1 = from s_code in sys.Elements("SYS_CODE")
                             select new
                             {
                                 SYS_CODE = s_code.Value,
                             };
                    foreach (var sys_id in q1)
                    {
                        info.SYS_ID += sys_id.SYS_CODE + " ";
                    }
                    var q2 = from s_name in sys.Elements("SYS_NAME")
                             select new
                             {
                                 SYS_NAME = s_name.Value,
                             };
                    foreach (var sys_name in q2)
                    {
                        info.SYS_ID += sys_name.SYS_NAME + ";";
                    }
                }
                if (!string.IsNullOrEmpty(info.SYS_ID))
                    info.SYS_ID = info.SYS_ID.TrimEnd(';');
                info.REL_TIME = item.REL_TIME;
                info.IS_SPEC = GetIsTrue(item.IS_SPEC);
                info.FRE_IDE = GetIsTrue(item.FRE_IDE);
                info.DEL_DATA = GetIsTrue(item.DEL_DATA);
                info.QUA_EXC = GetIsTrue(item.QUA_EXC);
                foreach (var str in item.MAT_CLA_CODE)
                {
                    info.MAT_CLA_CODE = str.GROUP_CODE + " " + str.GROUP_NAME;
                    info.MAT_MAINCATEGORIES = str.GROUP_CODE.Substring(0, 2);
                    info.MAT_MIDCATEGORIES = str.GROUP_CODE.Substring(2, 2);
                    info.MAT_SUBCATEGORIES = str.GROUP_CODE.Substring(4, 2);
                    info.MAT_COMMODITYNAME = info.MAT_CLA_CODE;
                }
            }
            dir.Add("MAT_CODE", info.MAT_CODE);
            dir.Add("MAT_NAME", info.MAT_NAME);
            dir.Add("SYS_ID", info.SYS_ID);
            dir.Add("REL_TIME", info.REL_TIME);
            dir.Add("IS_SPEC", info.IS_SPEC);
            dir.Add("FRE_IDE", info.FRE_IDE);
            dir.Add("DEL_DATA", info.DEL_DATA);
            dir.Add("QUA_EXC", info.QUA_EXC);
            dir.Add("MAT_CLA_CODE", info.MAT_CLA_CODE);
            dir.Add("MAT_MAINCATEGORIES", info.MAT_MAINCATEGORIES);
            dir.Add("MAT_MIDCATEGORIES", info.MAT_MIDCATEGORIES);
            dir.Add("MAT_SUBCATEGORIES", info.MAT_SUBCATEGORIES);
            dir.Add("MAT_COMMODITYNAME", info.MAT_COMMODITYNAME);
            return info;
        }
        #endregion

        private static bool GetIsTrue(string item)
        {
            if (item.Contains("Null"))
                return false;
            else
                return true;
        }
    }
}
