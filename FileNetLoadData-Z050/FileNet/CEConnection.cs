using System;
using System.Collections.Generic;
using System.Text;
using FileNet.Api.Core;
using FileNet.Api.Collection;
using System.Collections;
using FileNet.Api.Util;
using FileNet.Api.Authentication;
using FileNet.Api.Property;

namespace FileNetLoadData_Z050.FileNet
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

        /// <summary>
        /// 返回ObjectStores集合
        /// </summary>
        /// <returns></returns>
        public ArrayList GetOSNames()
        {
            return osNames;
        }

        /// <summary>
        /// 返回Domain
        /// </summary>
        /// <returns></returns>
        public IDomain GetDomain()
        {
            return domain;
        }

        /// <summary>
        /// 返回Domain名称
        /// </summary>
        /// <returns></returns>
        public String GetDomainName()
        {
            return domainName;
        }

        /// <summary>
        /// 连接CE是否成功
        /// </summary>
        /// <returns></returns>
        public bool IsCredentialsEstablished()
        {
            return isCredentialsEstablished;
        }

        /// <summary>
        /// 实例化ObjectStore
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public IObjectStore FetchOS(String name)
        {
            IObjectStore os = Factory.ObjectStore.FetchInstance(domain, name, null);
            return os;
        }
    }
}
