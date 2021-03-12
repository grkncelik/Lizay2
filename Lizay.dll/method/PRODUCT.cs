using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Lizay.dll.method
{
    public class PRODUCT
    {
        public static List<entity.PRODUCT> Get_ProductList(string categoryId="")
        {
            var productList = new List<entity.PRODUCT>();

            Result result = dbCaller.GetTable(
                "SELECT * FROM [dbo].[PRODUCT] WHERE 1=1 " +
                (categoryId != "" ? " AND CATEGORY_ID=" + categoryId  : "") +
                 "ORDER BY  ID DESC ");
            if (!result.isErrorOccurred)
            {
                DataTable dt = result.resultAsDataTable;
                if (dt != null)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        DataRow row = dt.Rows[i];

                        productList.Add(new entity.PRODUCT()
                        {
                            ID = Convert.ToInt32(row["ID"].ToString()),
                            NAME = row["NAME"].ToString(),
                            DETAIL = row["DETAIL"].ToString(),
                            IMG = row["IMG"].ToString(),
                            PRICE = row["PRICE"].ToString(),
                            DISCOUNT = row["DISCOUNT"].ToString(),
                            CATEGORY_ID = Convert.ToInt32(row["CATEGORY_ID"].ToString()),
                            URL = row["URL"].ToString(),

                        });
                    }
                }
            }

            return productList;
        }

        public static Lizay.dll.entity.PRODUCT Get_ProductByDetail(int Id)
        {
            Lizay.dll.entity.PRODUCT product = new Lizay.dll.entity.PRODUCT();


            Result result = dbCaller.GetTable("SELECT * FROM [dbo].[PRODUCT] WHERE ID="+ Id );
            if (!result.isErrorOccurred)
            {
                DataTable dt = result.resultAsDataTable;

                if (dt.Rows.Count > 0)
                {
                    product = new Lizay.dll.entity.PRODUCT()
                    {
                        NAME = dt.Rows[0]["NAME"].ToString(),
                        DETAIL = dt.Rows[0]["DETAIL"].ToString(),
                        IMG = dt.Rows[0]["IMG"].ToString(),
                        PRICE = dt.Rows[0]["PRICE"].ToString(),
                        DISCOUNT = dt.Rows[0]["DISCOUNT"].ToString(),
                        CATEGORY_ID = Convert.ToInt32(dt.Rows[0]["CATEGORY_ID"].ToString()),
                        URL = dt.Rows[0]["URL"].ToString(),
                        CODE= dt.Rows[0]["PRODUCTCODE"].ToString(),

                    };


                }
            }
            else
            {
                throw new Exception(result.errorDescription);
            }

            return product;
        }


        public static void AddProduct(Lizay.dll.entity.PRODUCT product)
        {
            Result result = dbCaller.ExecuteSql(
                "INSERT INTO [dbo].[PRODUCT] " +
                           "(NAME, DETAIL, IMG,PRICE,DISCOUNT,CATEGORY_ID,URL) " +
                    "VALUES ('" + product.NAME + "','" + product.DETAIL + "','" + product.IMG + "','" + product.PRICE + "','" + product.DISCOUNT + "'," + product.CATEGORY_ID + ",'" + product.URL + "')");

            if (result.isErrorOccurred)
                throw new Exception(result.errorDescription);
        }

        public static void Delete(int Id)
        {

            Result result = dbCaller.ExecuteSql("DELETE FROM [dbo].[PRODUCT]  WHERE ID=" + Id + "");
            if (result.isErrorOccurred)
                throw new Exception(result.errorDescription);
        }
    }
}
