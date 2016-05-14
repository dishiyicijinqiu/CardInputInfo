using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;

namespace CardInputInfo.Core
{
    public static class DataBaseExtend
    {
        public static List<T> GetEntitys<T>(this Database Database, DbCommand cmd)
        {
            DataSet ds = Database.ExecuteDataSet(cmd);
            var results = new List<T>();
            if (ds == null || ds.Tables.Count <= 0)
                return results;
            var ps = typeof(T).GetProperties();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                var dr = ds.Tables[0].Rows[i];
                T t = (T)Activator.CreateInstance(typeof(T));
                foreach (var p in ps)
                {
                    if (ds.Tables[0].Columns.Contains(p.Name))
                        p.SetValue(t, dr[p.Name], null);
                }
                results.Add(t);
            }
            return results;

        }
    }
}
