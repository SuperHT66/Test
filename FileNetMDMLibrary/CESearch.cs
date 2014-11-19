using System;
using System.Collections;
using System.Data;

using FileNet.Api.Core;
using FileNet.Api.Collection;
using FileNetMDMLibrary.CEModel;
using FileNet.Api.Query;


namespace FileNetMDMLibrary
{
    public class CESearch
    {
        public static DataTable QueryToDataTable(CEConnection ce,CESearchInfo info)
        {
            IObjectStore os = CEObjectStores.GetSelectObjectStore(ce,info.OsName);
            IRepositoryRowSet rrs = CEUtil.FetchResultRowSet(os, info.Select, info.From, info.Where, info.MaxRow);
            bool firstpass = true;
            DataTable table = new DataTable();

            IEnumerator ie = rrs.GetEnumerator();
            while (ie.MoveNext())
            {
                IRepositoryRow rr = (IRepositoryRow)ie.Current;
                if (firstpass)
                {
                    ArrayList names = CEUtil.GetRowPropertiesName(rr);
                    for (int i = 0; i < names.Count; i++)
                        table.Columns.Add(new DataColumn((String)names[i]));
                    firstpass = false;
                }
                table.Rows.Add(CEUtil.GetResultRow(rr));
            }
            return table;
        }
    }
}
