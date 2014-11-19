using System;
using System.IO;
using System.Collections;
using FileNet.Api.Core;
using FileNet.Api.Constants;
using FileNet.Api.Exception;
using FileNetMDMLibrary.CEModel;

namespace FileNetMDMLibrary
{
    public class CEDocument
    {
        public static void CreateDocument(CEConnection ce,CEDocumentInfo info)
        {
            IDocument doc = null;
            IObjectStore os = CEObjectStores.GetSelectObjectStore(ce, info.OsName);
            if (info.IsContent)
                doc = CEUtil.CreateDocument(true, info.File, info.Mime, info.Title, os, info.ClassName);
            else
                doc = CEUtil.CreateDocument(false, null, info.Mime, info.Title, os, info.ClassName);
            doc.Save(RefreshMode.REFRESH);

            if (info.IsFileInFolder)
            {
                string folder = info.FilePath;
                if (folder.Length == 0)
                    folder = "/";
                IReferentialContainmentRelationship rcr = CEUtil.FileContainable(os, doc, folder);
                rcr.Save(RefreshMode.REFRESH);
            }

            if (info.IsbCheckIn)
                CEUtil.checkInDoc(doc);
        }
    }
}
