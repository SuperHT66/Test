using System;
using System.Collections.Generic;
using System.Text;
using FileNet.Api.Core;
using FileNet.Api.Collection;
using System.Collections;
using FileNet.Api.Util;
using FileNet.Api.Authentication;
using FileNet.Api.Property;

namespace FileNetForMDMVerify.Library
{
    public class CEConnection
    {
        private IDomain domain;
        private IObjectStoreSet ost;
        private ArrayList osNames;
        private String domainName;
        private bool isCredentialsEstablished;

        /// <summary>
        /// 初试化Connection
        /// </summary>
        public CEConnection()
        {
            domain = null;
            ost = null;
            osNames = new ArrayList();
            domainName = null;
            isCredentialsEstablished = false;
        }

        /// <summary>
        /// 输入用户名，密码，URL
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <param name="uri"></param>
        public void EstablishCredentials(String userName, String password, String uri)
        {
            UsernameCredentials cred = new UsernameCredentials(userName, password);
            // now associate this Credentials with the whole process
            ClientContext.SetProcessCredentials(cred);
            IConnection connection = Factory.Connection.GetConnection(uri);
            isCredentialsEstablished = true;
            IntializeVariables(connection);
        }

       /// <summary>
       /// 连接CE
       /// </summary>
       /// <param name="connection"></param>
        private void IntializeVariables(IConnection connection)
        {
            domain = Factory.Domain.FetchInstance(connection, null, null);
            domainName = domain.Name;
            ost = domain.ObjectStores;
            SetOSNames();
        }

       /// <summary>
       /// 获取ObjectStores
       /// </summary>
        private void SetOSNames()
        {
            IEnumerator ie = ost.GetEnumerator();
            while (ie.MoveNext())
            {
                IObjectStore os = (IObjectStore)ie.Current;
                osNames.Add(os.DisplayName);
            }
        }

        //
        // Returns the osNames ArrayList.
        //
        public ArrayList GetOSNames()
        {
            return osNames;
        }

        //
        // Returns the domain (IDomain object)
        //
        public IDomain GetDomain()
        {
            return domain;
        }

        //
        // Returns the domain name
        //
        public String GetDomainName()
        {
            return domainName;
        }

        //
        // Returns true or false based on whether credentials have been
        // established with CE or not.
        //
        public bool IsCredentialsEstablished()
        {
            return isCredentialsEstablished;
        }

        //
        // Fetches the ObjectStore object using given name.
        //
        public IObjectStore FetchOS(String name)
        {
            IObjectStore os = Factory.ObjectStore.FetchInstance(domain, name, null);
            return os;
        }
    }
}
