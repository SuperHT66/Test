using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileNetMDMLibrary.CEModel
{
    public class CESearchInfo
    {
        private string osName;
        /// <summary>
        /// FileNet ObjectStore存储库名称
        /// </summary>
        public string OsName
        {
            get { return osName; }
            set { osName = value; }
        }

        private bool isMaxRow;
        /// <summary>
        /// 是否为最大行数
        /// </summary>
        public bool IsMaxRow
        {
            get { return isMaxRow; }
            set { isMaxRow = value; }
        }

        private int maxRow;
        /// <summary>
        /// 最大行数
        /// </summary>
        public int MaxRow
        {
            get { return maxRow; }
            set { maxRow = value; }
        }

        private string select;
        /// <summary>
        /// 查询语句select
        /// </summary>
        public string Select
        {
            get { return select; }
            set { select = value; }
        }

        private string from;
        /// <summary>
        /// 查询语句from
        /// </summary>
        public string From
        {
            get { return from; }
            set { from = value; }
        }

        private string where;
        /// <summary>
        /// 查询语句where
        /// </summary>
        public string Where
        {
            get { return where; }
            set { where = value; }
        }
    }
}
