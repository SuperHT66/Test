using System.Collections;

using FileNet.Api.Core;
using FileNetMDMLibrary.CEModel;

namespace FileNetMDMLibrary
{
   public class CEObjectStores
    {
       /// <summary>
        /// 获取所有ObjectStores集合
       /// </summary>
       /// <param name="ce"></param>
       /// <returns></returns>
       public static ArrayList GetAllObjectStores(CEConnection ce)
       {
           ArrayList osNames = ce.GetOSNames();
           return osNames;
       }

       /// <summary>
       /// 获取所选的ObjectStore
       /// </summary>
       /// <param name="ce"></param>
       /// <param name="OsName"></param>
       /// <returns></returns>
       public static IObjectStore GetSelectObjectStore(CEConnection ce, string OsName)
       {
           IObjectStore os = ce.FetchOS(OsName);
           return os;
       }
    }
}
