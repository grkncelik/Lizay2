using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Lizay.dll.method
{
    public class SALES
    {
        public static Lizay.dll.entity.SALES Get_CompanySalesByNo(string companyno)
        {
            var company_Sales = new Lizay.dll.entity.SALES();
            string sql = "SELECT * FROM [dbo].[SALES_PRIM] WHERE COMPANY_NO='" + companyno + "'";

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

                        toplamsatis += Convert.ToDecimal(dr2["SALES_AMOUNT"].ToString());

                    }


                    DataRow dr = dt.Rows[0];

                    company_Sales = new entity.SALES();
                    company_Sales.SALES_AMOUNT = toplamsatis;

                }


            }

            return company_Sales;
        }

        public static Lizay.dll.entity.SALES Get_PersonSalesByNo(string username)
        {
            var company_Sales = new Lizay.dll.entity.SALES();
            string sql = "SELECT * FROM [dbo].[SALES_PRIM] WHERE USER_ID='" + username + "'";

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

                        toplamsatis += Convert.ToDecimal(dr2["SALES_AMOUNT"].ToString());

                    }


                    DataRow dr = dt.Rows[0];

                    company_Sales = new entity.SALES();
                    company_Sales.SALES_AMOUNT = toplamsatis;

                }


            }

            return company_Sales;
        }

        public static Lizay.dll.entity.SALES Get_CompanySalesList()
        {
            var company_Sales = new Lizay.dll.entity.SALES();
            string sql = "SELECT * FROM [dbo].[SALES_PRIM] ORDER BY ID DESC";

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

                        toplamsatis += Convert.ToDecimal(dr2["SALES_AMOUNT"].ToString());

                    }


                    DataRow dr = dt.Rows[0];

                    company_Sales = new entity.SALES();
                    company_Sales.SALES_AMOUNT = toplamsatis;

                }


            }

            return company_Sales;
        }


        public static Lizay.dll.entity.SALES Get_PersonSalesList()
        {
            var company_Sales = new Lizay.dll.entity.SALES();
            string sql = "SELECT * FROM [dbo].[SALES_PRIM] ORDER BY ID DESC";

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

                        toplamsatis += Convert.ToDecimal(dr2["SALES_AMOUNT"].ToString());

                    }


                    DataRow dr = dt.Rows[0];

                    company_Sales = new entity.SALES();
                    company_Sales.SALES_AMOUNT = toplamsatis;

                }


            }

            return company_Sales;
        }
    }
}
