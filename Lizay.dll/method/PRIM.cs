using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Lizay.dll.method
{
    public class PRIM
    {
        public static Lizay.dll.entity.PRIM Get_CompanyPrimByNo(string companyno)
        {
            var company_Sales = new Lizay.dll.entity.PRIM();
            string sql = "SELECT * FROM [dbo].[SALES_PRIM] WHERE COMPANY_NO='" + companyno + "' AND PRIM='TRUE'";

            var dbResult = dbCaller.GetTable(sql, dbCaller.ConnectionString);
            if (!dbResult.isErrorOccurred)
            {
                DataTable dt = dbResult.resultAsDataTable;

                if (dt != null && dt.Rows.Count > 0)
                {
                    decimal toplamsatis = 0;

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {

                        DataRow dr2 = dt.Rows[i];

                        toplamsatis += Convert.ToDecimal(dr2["PRIM_AMOUNT"].ToString());

                    }


                    DataRow dr = dt.Rows[0];

                    company_Sales = new entity.PRIM();
                    company_Sales.SALES_AMOUNT = toplamsatis;

                }


            }

            return company_Sales;
        }

        public static Lizay.dll.entity.PRIM Get_PersonPrimByNo(string username)
        {
            var company_Sales = new Lizay.dll.entity.PRIM();
            string sql = "SELECT * FROM [dbo].[SALES_PRIM] WHERE USER_ID='" + username + "' AND PRIM='TRUE'";

            var dbResult = dbCaller.GetTable(sql, dbCaller.ConnectionString);
            if (!dbResult.isErrorOccurred)
            {
                DataTable dt = dbResult.resultAsDataTable;

                if (dt != null && dt.Rows.Count > 0)
                {
                    decimal toplamsatis = 0;

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {

                        DataRow dr2 = dt.Rows[i];

                        toplamsatis += Convert.ToDecimal(dr2["PRIM_AMOUNT"].ToString());

                    }


                    DataRow dr = dt.Rows[0];

                    company_Sales = new entity.PRIM();
                    company_Sales.SALES_AMOUNT = toplamsatis;

                }


            }

            return company_Sales;
        }

        public static Lizay.dll.entity.PRIM Get_CompanyPrimList()
        {
            var company_Sales = new Lizay.dll.entity.PRIM();
            string sql = "SELECT * FROM [dbo].[SALES_PRIM] WHERE AND PRIM='TRUE' ORDER BY ID DESC";

            var dbResult = dbCaller.GetTable(sql, dbCaller.ConnectionString);
            if (!dbResult.isErrorOccurred)
            {
                DataTable dt = dbResult.resultAsDataTable;

                if (dt != null && dt.Rows.Count > 0)
                {
                    decimal toplamsatis = 0;

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {

                        DataRow dr2 = dt.Rows[i];

                        toplamsatis += Convert.ToDecimal(dr2["PRIM_AMOUNT"].ToString());

                    }


                    DataRow dr = dt.Rows[0];

                    company_Sales = new entity.PRIM();
                    company_Sales.SALES_AMOUNT = toplamsatis;

                }


            }

            return company_Sales;
        }


        public static Lizay.dll.entity.PRIM Get_PersonPrimList()
        {
            var company_Sales = new Lizay.dll.entity.PRIM();
            string sql = "SELECT * FROM [dbo].[SALES_PRIM] WHERE AND PRIM='TRUE' ORDER BY ID DESC";

            var dbResult = dbCaller.GetTable(sql, dbCaller.ConnectionString);
            if (!dbResult.isErrorOccurred)
            {
                DataTable dt = dbResult.resultAsDataTable;

                if (dt != null && dt.Rows.Count > 0)
                {
                    decimal toplamsatis = 0;

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {

                        DataRow dr2 = dt.Rows[i];

                        toplamsatis += Convert.ToDecimal(dr2["PRIM_AMOUNT"].ToString());

                    }


                    DataRow dr = dt.Rows[0];

                    company_Sales = new entity.PRIM();
                    company_Sales.SALES_AMOUNT = toplamsatis;

                }


            }

            return company_Sales;
        }
    }
}
