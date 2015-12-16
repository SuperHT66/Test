using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;

using FileNet.Api.Exception;
using FileNet.Api.Core;
using FileNet.Api.Constants;

using FileNetLoadData_Z050.Model;
using FileNetLoadData_Z050.FileNet;

namespace FileNetLoadData.FileNet
{
    public class FileNetApi
    {
        #region 调用FileNet Api
        /// <summary>
        /// 连接FileNet CE
        /// </summary>
        public static CEConnection ConnectionCE()
        {
            CEConnection ce = new CEConnection();
            string user = "p8admin";
            string pass = "q1w2e3r4";
            string uri = "http://11.10.115.48:9080/wsi/FNCEWS40MTOM/";
            try
            {
                ce.EstablishCredentials(user, pass, uri);
                Console.WriteLine("CE连接成功");
                //Console.ReadKey();
                return ce;
            }
            catch (EngineRuntimeException ere)
            {
                System.Console.WriteLine();
                System.Console.WriteLine(ere.ToString() + ere.StackTrace);
                Console.ReadKey();
                return null;
            }
        }

        /// <summary>
        /// 上传文件
        /// </summary>
        public static void UploadFileToFileNet(bool isAdd, string filePath, Z050Info info, CEConnection ce)
        {
            try
            {
                FileInfo fi = new FileInfo(filePath);
                string mime = "text/plain";
                string title = fi.Name;
                string className = "Z050";

                ArrayList osNames = ce.GetOSNames();
                IDocument doc = null;
                //IObjectStore os = ce.FetchOS("MDMOS");
                IObjectStore os = ce.FetchOS((String)osNames[0]);
                doc = CEUtil.CreateDocumentZ050(true, filePath, mime, title, os, className, info);
                doc.Save(RefreshMode.REFRESH);
                string folder = "/MDMRelease/MasterDataFile/Z050";
                if (folder.Length == 0)
                    folder = "/";
                IReferentialContainmentRelationship rcr = CEUtil.FileContainable(os, doc, folder);
                rcr.Save(RefreshMode.REFRESH);
                CEUtil.checkInDoc(doc);
            }
            catch (EngineRuntimeException ere)
            {
                System.Console.WriteLine();
                System.Console.WriteLine(ere.ToString() + ere.StackTrace);
                Console.ReadKey();
            }
        }
        #endregion

        public static void UploadFileToFileNetPro(bool isAdd, string filePath, Z050Info info, CEConnection ce)
        {
            FileInfo fi = new FileInfo(filePath);
            string mime = "text/plain";
            string title = fi.Name;
            string className = "ProjectCode";

            ArrayList osNames = ce.GetOSNames();
            IDocument doc = null;
            //IObjectStore os = ce.FetchOS("MDMOS");
            IObjectStore os = ce.FetchOS((String)osNames[0]);
            doc = CEUtil.CreateDocumentZ050(true, filePath, mime, title, os, className, info);
            doc.Save(RefreshMode.REFRESH);
            string folder = "/MDMRelease/MasterDataFile/Z050";
            if (folder.Length == 0)
                folder = "/";
            IReferentialContainmentRelationship rcr = CEUtil.FileContainable(os, doc, folder);
            rcr.Save(RefreshMode.REFRESH);
            CEUtil.checkInDoc(doc);
        }
    }
}
