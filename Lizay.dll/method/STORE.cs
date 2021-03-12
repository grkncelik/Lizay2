using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Lizay.dll.method
{
    public class STORE
    {
        public static List<entity.STORE> Get_StoreList(string city = "")
        {
            var productList = new List<entity.STORE>();

            Result result = dbCaller.GetTable(
                "SELECT * FROM [dbo].[STORE] WHERE 1=1 " +
                (city != "" ? " AND CITY='" + city + "'" : "") +
                 " ORDER BY ID  ");
            if (!result.isErrorOccurred)
            {
                DataTable dt = result.resultAsDataTable;
                if (dt != null)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        DataRow row = dt.Rows[i];

                        productList.Add(new entity.STORE()
                        {
                            ID = Convert.ToInt32(row["ID"].ToString()),
                            NAME = row["NAME"].ToString(),
                            ADDRESS = row["ADDRESS"].ToString(),
                            CITY = row["CITY"].ToString(),
                            MAP = row["MAP"].ToString(),
                            PHONE = row["PHONE"].ToString(),
                            WORKHOUR = row["WORKHOUR"].ToString(),

                        });
                    }
                }
            }

            return productList;
        }

        public static Lizay.dll.entity.STORE Get_StoreByDetail(int Id)
        {
            Lizay.dll.entity.STORE product = new Lizay.dll.entity.STORE();


            Result result = dbCaller.GetTable("SELECT * FROM [dbo].[STORE] WHERE ID=" + Id);
            if (!result.isErrorOccurred)
            {
                DataTable dt = result.resultAsDataTable;

                if (dt.Rows.Count > 0)
                {
                    product = new Lizay.dll.entity.STORE()
                    {
                        NAME = dt.Rows[0]["NAME"].ToString(),
                        ADDRESS = dt.Rows[0]["ADDRESS"].ToString(),
                        MAP = dt.Rows[0]["MAP"].ToString(),
                        CITY = dt.Rows[0]["CITY"].ToString(),
                        PHONE = dt.Rows[0]["PHONE"].ToString(),
                        ID = Convert.ToInt32(dt.Rows[0]["ID"].ToString()),
                        WORKHOUR = dt.Rows[0]["WORKHOUR"].ToString(),

                    };


                }
            }
            else
            {
                throw new Exception(result.errorDescription);
            }

            return product;
        }
    }
}
