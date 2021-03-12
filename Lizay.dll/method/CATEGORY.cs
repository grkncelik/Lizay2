using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Lizay.dll.method
{
    public class CATEGORY
    {
        public static List<entity.CATEGORY> Get_CategoryList(string type = "")
        {
            var productList = new List<entity.CATEGORY>();

            Result result = dbCaller.GetTable(
                "SELECT * FROM [dbo].[CATEGORY] WHERE 1=1 " +
                (type != "" ? " AND TYPE='" + type + "'" : "") +
                 " ORDER BY ID ");
            if (!result.isErrorOccurred)
            {
                DataTable dt = result.resultAsDataTable;
                if (dt != null)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        DataRow row = dt.Rows[i];

                        productList.Add(new entity.CATEGORY()
                        {
                            ID = Convert.ToInt32(row["ID"].ToString()),
                            NAME = row["NAME"].ToString(),
                            TYPE = row["TYPE"].ToString(),


                        });
                    }
                }
            }

            return productList;
        }

        public static Lizay.dll.entity.CATEGORY Get_CategoryByDetail(int Id)
        {
            Lizay.dll.entity.CATEGORY product = new Lizay.dll.entity.CATEGORY();


            Result result = dbCaller.GetTable("SELECT * FROM [dbo].[CATEGORY] WHERE ID=" + Id);
            if (!result.isErrorOccurred)
            {
                DataTable dt = result.resultAsDataTable;

                if (dt.Rows.Count > 0)
                {
                    product = new Lizay.dll.entity.CATEGORY()
                    {
                        NAME = dt.Rows[0]["NAME"].ToString(),

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
