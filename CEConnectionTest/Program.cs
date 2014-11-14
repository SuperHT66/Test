using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FileNet.Api.Exception;
using FileNetForMDMVerify.Library;

namespace CEConnectionTest
{
    class Program
    {  
        static void Main(string[] args)
        {
            CEConnection ce = new CEConnection();
            string user = "fnmdmadm";
            string pass = "mybasis0";
            string uri = "http://filenetdev:9080/wsi/FNCEWS40MTOM/";
            try
            {
                ce.EstablishCredentials(user, pass, uri);
                Console.WriteLine("CE连接成功");
                Console.ReadKey();
            }
            catch (EngineRuntimeException ere)
            {
                System.Console.WriteLine();
                System.Console.WriteLine(ere.ToString()+ere.StackTrace);
                Console.ReadKey();
            }
        }
    }
}
