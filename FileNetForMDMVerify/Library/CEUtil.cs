using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using FileNet.Api.Core;
using FileNet.Api.Collection;
using FileNet.Api.Constants;
using FileNet.Api.Util;
using System.Collections;
using FileNet.Api.Security;
using FileNet.Api.Query;
using FileNet.Api.Property;

namespace FileNetForMDMVerify.Library
{
    public class CEUtil
    {
        //
        // Reads the content from a file and stores it
        // in a byte array. The byte array will later be
        // used to create ContentTransfer object.
        //
        public static byte[] ReadContentFromFile(String fileName)
        {
            FileInfo fi = new FileInfo(fileName);
            long numBytes = fi.Length;
            byte[] buffer = null;
            if (numBytes > 0)
            {
                try
                {
                    FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    buffer = br.ReadBytes((int)numBytes);
                    br.Close();
                    fs.Close();
                }
                catch (Exception e)
                {
                    System.Console.WriteLine(e.StackTrace);
                }
            }
            return buffer;
        }

        //
        // Reads the content from Document's ContentStream and copies it
        // to a file on a file system.
        //
        public static void WriteContentToFile(IDocument doc, String path)
        {

            String fileName = doc.Name;
            String file = Path.Combine(path, fileName);
            try
            {
                FileStream fs = new FileStream(file, FileMode.CreateNew);
                BinaryWriter bw = new BinaryWriter(fs);
                Stream s = doc.AccessContentStream(0);
                byte[] data = new byte[s.Length];
                s.Read(data, 0, data.Length);
                s.Close();
                bw.Write(data);
                bw.Close();
                fs.Close();
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.StackTrace);
            }
        }

        //
        // Creates the ContentTransfer object from supplied file's
        // content.
        //
        public static IContentTransfer CreateContentTransfer(String fileName)
        {
            IContentTransfer ct = null;
            FileInfo fi = new FileInfo(fileName);
            if (ReadContentFromFile(fileName) != null)
            {
                ct = Factory.ContentTransfer.CreateInstance();
                Stream s = new MemoryStream(ReadContentFromFile(fileName));
                ct.SetCaptureSource(s);
                ct.RetrievalName = fi.Name;
            }
            return ct;
        }

        //
        // Creates the ContentElementList from ContentTransfer object.
        //
        public static IContentElementList CreateContentElementList(String fileName)
        {
            IContentElementList cel = null;
            if (CreateContentTransfer(fileName) != null)
            {
                cel = Factory.ContentElement.CreateList();
                IContentTransfer ct = CreateContentTransfer(fileName);
                cel.Add(ct);
            }
            return cel;
        }

        //
        // Creates the Document with or without content.
        //
        public static IDocument CreateDocument(bool withContent, String file, String mimeType, String docName, IObjectStore os, String className)
        {
            IDocument doc = null;
            if (className.Equals(""))
                doc = Factory.Document.CreateInstance(os, null);
            else
                doc = Factory.Document.CreateInstance(os, className);
            doc.Properties["DocumentTitle"] = docName;
            doc.MimeType = mimeType;
            if (withContent == true)
            {
                IContentElementList cel = CreateContentElementList(file);
                if (cel != null)
                    doc.ContentElements = cel;
            }
            return doc;
        }

        //
        // Checks in the Document object.
        //
        public static void checkInDoc(IDocument doc)
        {
            doc.Checkin(AutoClassify.AUTO_CLASSIFY, CheckinType.MINOR_VERSION);
            doc.Save(RefreshMode.REFRESH);
            doc.Refresh();
        }

        //
        // Fetches the Document instance with specified id from specified ObjectStore.
        //
        public static IDocument FetchDocByID(IObjectStore os, String id)
        {
            Id ID = new Id(id);
            IDocument doc = Factory.Document.FetchInstance(os, ID, null);
            return doc;
        }

        //
        // Fetches the Document instance from specified ObjectStore path.
        //
        public static IDocument FetchDocByPath(IObjectStore os, String path)
        {
            IDocument doc = Factory.Document.FetchInstance(os, path, null);
            return doc;
        }

        //
        // Creates the CustomObject.
        //
        public static ICustomObject CreateCustomObject(IObjectStore os, String className)
        {
            ICustomObject co = null;
            if (className.Equals(""))
                co = Factory.CustomObject.CreateInstance(os, null);
            else
                co = Factory.CustomObject.CreateInstance(os, className);
            return co;
        }

        //
        // Fetches the CustomObject instance from specified ObjectStore path.
        //
        public static ICustomObject FetchCustomObjectByPath(IObjectStore os, String path)
        {
            ICustomObject co = Factory.CustomObject.FetchInstance(os, path, null);
            return co;
        }

        //
        // Fetches the CustomObject instance with specified by ObjectStore and id.
        //
        public static ICustomObject FetchCustomObjectById(IObjectStore os, String id)
        {
            Id ID = new Id(id);
            ICustomObject co = Factory.CustomObject.FetchInstance(os, ID, null);
            return co;
        }

        //
        // Retrives some of the properties of Containable object 
        // (i.e. Document, CustomObject) and stores them in a Hashtable, 
        // with property name as key and property value as value.
        //
        public static Hashtable GetContainableProperties(IContainable c)
        {
            Hashtable properties = new Hashtable();
            properties.Add("ID", c.Id.ToString());
            properties.Add("Name", c.Name);
            properties.Add("Creator", c.Creator);
            properties.Add("Owner", c.Owner);
            properties.Add("Date Created", c.DateCreated.ToString());
            properties.Add("Date Last Modified", c.DateLastModified.ToString());
            return properties;
        }

        //
        // Retrives the access permission list for a Containable
        // object (i.e. Document, CustomObject) and stores it in an ArrayList.
        //
        public static ArrayList GetContainablePermissions(IContainable c)
        {
            ArrayList permissions = new ArrayList();
            IAccessPermissionList acl = c.Permissions;
            IEnumerator ie = acl.GetEnumerator();
            while (ie.MoveNext())
            {
                IAccessPermission ac = (IAccessPermission)ie.Current;
                permissions.Add("GRANTEE_NAME: " + ac.GranteeName);
                permissions.Add("ACCESS_MASK: " + ac.AccessMask.ToString());
                permissions.Add("ACCESS_TYPE: " + ac.AccessType.ToString());
            }
            return permissions;
        }

        //
        // Files the Containable object (i.e. Document, CustomObject) in
        // specified Folder.
        //
        public static IReferentialContainmentRelationship FileContainable(IObjectStore os, IContainable c, String folder)
        {
            IFolder f = Factory.Folder.FetchInstance(os, folder, null);
            IReferentialContainmentRelationship rcr = null;
            if (c is IDocument)
                rcr = f.File((IDocument)c, AutoUniqueName.AUTO_UNIQUE, ((IDocument)c).Name, DefineSecurityParentage.DO_NOT_DEFINE_SECURITY_PARENTAGE);
            else
                rcr = f.File((ICustomObject)c, AutoUniqueName.AUTO_UNIQUE, ((ICustomObject)c).Name, DefineSecurityParentage.DO_NOT_DEFINE_SECURITY_PARENTAGE);
            return rcr;
        }

        //
        // Creates the Folder instance at specified path using specified name.
        //
        public static IFolder CreateFolder(IObjectStore os, String fPath, String fName, String className)
        {
            IFolder f = Factory.Folder.FetchInstance(os, fPath, null);
            IFolder nf = null;
            if (className.Equals(""))
                nf = Factory.Folder.CreateInstance(os, null);
            else
                nf = Factory.Folder.CreateInstance(os, className);
            nf.FolderName = fName;
            nf.Parent = f;
            return nf;
        }

        //
        // Creates the CompoundDocument (i.e. ComponentRelationship instance)
        // with one parent and one child Document.
        //
        public static IComponentRelationship CreateComponentRelationship(IObjectStore os, String pTitle, String cTitle)
        {
            IDocument parent = Factory.Document.CreateInstance(os, null);
            parent.Properties["DocumentTitle"] = pTitle;
            parent.CompoundDocumentState = CompoundDocumentState.COMPOUND_DOCUMENT;
            parent.Save(RefreshMode.REFRESH);
            parent.Checkin(AutoClassify.AUTO_CLASSIFY, CheckinType.MINOR_VERSION);
            parent.Save(RefreshMode.REFRESH);

            IDocument child = Factory.Document.CreateInstance(os, null);
            child.Properties["DocumentTitle"] = cTitle;
            child.CompoundDocumentState = CompoundDocumentState.COMPOUND_DOCUMENT;
            child.Save(RefreshMode.REFRESH);
            child.Checkin(AutoClassify.AUTO_CLASSIFY, CheckinType.MINOR_VERSION);
            child.Save(RefreshMode.REFRESH);

            IComponentRelationship cr = Factory.ComponentRelationship.CreateInstance(os, null);
            cr.ParentComponent = parent;
            cr.ChildComponent = child;
            cr.ComponentRelationshipType = ComponentRelationshipType.DYNAMIC_CR;
            cr.VersionBindType = VersionBindType.LATEST_VERSION;

            return cr;
        }

        //
        // Fetches the CompoundDocument (i.e. ComponentRelationship) object using supplied ID.
        //
        public static IComponentRelationship FetchComponenetRelationship(IObjectStore os, string id)
        {
            Id ID = new Id(id);
            IComponentRelationship cr = Factory.ComponentRelationship.FetchInstance(os, ID, null);
            return cr;
        }

        //
        // Retrives some of the properties of CompoundDocument
        // (i.e. ComponentRelationship) object and stores them 
        // in a Hashtable, with property name as key and property value as value.
        //
        public static Hashtable GetComponentRelationshipProperties(IComponentRelationship cr)
        {
            Hashtable properties = new Hashtable();
            properties.Add("ID", cr.Id.ToString());
            properties.Add("Creator", cr.Creator);
            properties.Add("Date Created", cr.DateCreated.ToString());
            properties.Add("Date Last Modified", cr.DateLastModified.ToString());
            properties.Add("Parent Component", cr.ParentComponent.Name);
            properties.Add("Child Component", cr.ChildComponent.Name);
            return properties;
        }

        //
        // Retrives the RepositoryRowSet (result of querying Content Engine).
        // Query is constructed from supplied select, from, and where clause using
        // SearchSQL object. Then it creates the SearchScope object using supplied
        // ObjectStore, and queries the Content Engine using fetchRows method
        // of SearchScope object.
        //
        public static IRepositoryRowSet FetchResultRowSet(IObjectStore os, String select, String from, String where, int rows)
        {
            SearchSQL sq = new SearchSQL();
            SearchScope ss = new SearchScope(os);
            sq.SetSelectList(select);
            sq.SetFromClauseInitialValue(from, null, false);
            if (!(where.Equals("")))
                sq.SetWhereClause(where);
            if (!(rows == 0))
                sq.SetMaxRecords(rows);
            IRepositoryRowSet rrs = ss.FetchRows(sq, null, null, null);
            return rrs;
        }

        //
        // Retrives the properties values from given RepositoryRow
        // and stores them in an array.
        //
        public static String[] GetResultRow(IRepositoryRow rr)
        {
            IProperties prop = rr.Properties;
            IEnumerator ie = prop.GetEnumerator();
            String[] row = new String[prop.Count];
            int i = 0;
            while (ie.MoveNext())
            {
                IProperty p = (IProperty)ie.Current;
                Object value = p.GetObjectValue();
                if (value == null)
                    row[i] = "null";
                else if (value is IEngineCollection)
                    row[i] = "*";
                else
                    row[i] = value.ToString();
                i++;
            }
            return row;
        }

        //
        // Retrives the properties' names from supplied RepositoryRow
        // and stores them in an ArrayList.
        // 
        public static ArrayList GetRowPropertiesName(IRepositoryRow rr)
        {
            ArrayList names = new ArrayList();
            IProperties prop = rr.Properties;
            IEnumerator ie = prop.GetEnumerator();
            while (ie.MoveNext())
            {
                IProperty p = (IProperty)ie.Current;
                String name = p.GetPropertyName();
                names.Add(name);
            }
            return names;
        }
    }
}
