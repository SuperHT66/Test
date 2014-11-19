
namespace FileNetMDMLibrary.CEModel
{
    public class CEDocumentInfo
    {
        private bool isContent;
        /// <summary>
        /// 是否包含内容
        /// </summary>
        public bool IsContent
        {
            get { return isContent; }
            set { isContent = value; }
        }

        private string file;
        /// <summary>
        /// 需要创建的文件
        /// </summary>
        public string File
        {
            get { return file; }
            set { file = value; }
        }

        private string mime;
        /// <summary>
        /// 文档类型
        /// </summary>
        public string Mime
        {
            get { return mime; }
            set { mime = value; }
        }

        private string title;
        /// <summary>
        /// 文档标题
        /// </summary>
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        private string osName;
        /// <summary>
        /// FileNet ObjectStore存储库名称
        /// </summary>
        public string OsName
        {
            get { return osName; }
            set { osName = value; }
        }

        private string className;
        /// <summary>
        /// 文档类
        /// </summary>
        public string ClassName
        {
            get { return className; }
            set { className = value; }
        }

        private bool isFileInFolder;
        /// <summary>
        /// 是否包含在文件夹内
        /// </summary>
        public bool IsFileInFolder
        {
            get { return isFileInFolder; }
            set { isFileInFolder = value; }
        }

        private string filePath;
        /// <summary>
        /// 文件夹路径
        /// </summary>
        public string FilePath
        {
            get { return filePath; }
            set { filePath = value; }
        }

        private bool isbCheckIn;
        /// <summary>
        /// 是否签入
        /// </summary>
        public bool IsbCheckIn
        {
            get { return isbCheckIn; }
            set { isbCheckIn = value; }
        }
    }
}
