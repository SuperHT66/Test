using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileNetLoadData_Z050.Model
{
    public class Z050Info
    {
        private string _MAT_CODE;
        /// <summary>
        /// 物料编码
        /// </summary>
        public string MAT_CODE
        {
            get { return _MAT_CODE; }
            set { _MAT_CODE = value; }
        }

        private string _MAT_NAME;
        /// <summary>
        /// 物料描述
        /// </summary>
        public string MAT_NAME
        {
            get { return _MAT_NAME; }
            set { _MAT_NAME = value; }
        }

        private string _SYS_ID;
        /// <summary>
        /// 信息系统
        /// </summary>
        public string SYS_ID
        {
            get { return _SYS_ID; }
            set { _SYS_ID = value; }
        }

        private DateTime _REL_TIME;
        /// <summary>
        /// 发布时间
        /// </summary>
        public DateTime REL_TIME
        {
            get { return _REL_TIME; }
            set { _REL_TIME = value; }
        }

        private bool _IS_SPEC;
        /// <summary>
        /// 特批数据
        /// </summary>
        public bool IS_SPEC
        {
            get { return _IS_SPEC; }
            set { _IS_SPEC = value; }
        }

        private bool _FRE_IDE;
        /// <summary>
        /// 冻结标识
        /// </summary>
        public bool FRE_IDE
        {
            get { return _FRE_IDE; }
            set { _FRE_IDE = value; }
        }

        private bool _DEL_DATA;
        /// <summary>
        /// 删除数据
        /// </summary>
        public bool DEL_DATA
        {
            get { return _DEL_DATA; }
            set { _DEL_DATA = value; }
        }

        private bool _QUA_EXC;
        /// <summary>
        /// 质量异常
        /// </summary>
        public bool QUA_EXC
        {
            get { return _QUA_EXC; }
            set { _QUA_EXC = value; }
        }

        private string _MAT_CLA_CODE;
        /// <summary>
        /// 分类编码
        /// </summary>
        public string MAT_CLA_CODE
        {
            get { return _MAT_CLA_CODE; }
            set { _MAT_CLA_CODE = value; }
        }

        private string _MAT_MAINCATEGORIES;
        /// <summary>
        /// 大类
        /// </summary>
        public string MAT_MAINCATEGORIES
        {
            get { return _MAT_MAINCATEGORIES; }
            set { _MAT_MAINCATEGORIES = value; }
        }

        private string _MAT_MIDCATEGORIES;
        /// <summary>
        /// 中类
        /// </summary>
        public string MAT_MIDCATEGORIES
        {
            get { return _MAT_MIDCATEGORIES; }
            set { _MAT_MIDCATEGORIES = value; }
        }

        private string _MAT_SUBCATEGORIES;
        /// <summary>
        /// 小类
        /// </summary>
        public string MAT_SUBCATEGORIES
        {
            get { return _MAT_SUBCATEGORIES; }
            set { _MAT_SUBCATEGORIES = value; }
        }

        private string _MAT_COMMODITYNAME;
        /// <summary>
        /// 品名
        /// </summary>
        public string MAT_COMMODITYNAME
        {
            get { return _MAT_COMMODITYNAME; }
            set { _MAT_COMMODITYNAME = value; }
        }
    }
}
