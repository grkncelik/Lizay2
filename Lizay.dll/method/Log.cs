using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Lizay.dll.method
{
    public class Log
    {
        public static List<entity.Log> GetLastLog()
        {
            var log = new List<entity.Log>();

            var sql = @"SELECT TOP 1 ID
                              ,LOGDATE
                              ,TITLE
                              ,DESCRIPTION
                              ,STATU
                          FROM dbo.LOG
                          ORDER BY ID DESC";
            var result = dbCaller.GetTable(sql);
            if (result.isErrorOccurred) return log;
            var dt = result.resultAsDataTable;
            if (dt == null) return log;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                var row = dt.Rows[i];

                log.Add(new entity.Log
                {
                    Id = Convert.ToInt32(row["ID"].ToString()),
                    LogDate = row["LOGDATE"].ToString(),
                    Title = row["TITLE"].ToString(),
                    Description = row["DESCRIPTION"].ToString(),
                    Statu = row["STATU"].ToString(),

                });
            }

            return log;
        }


    }
}
