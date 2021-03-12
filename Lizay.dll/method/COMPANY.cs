using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Lizay.dll.method
{
    public class COMPANY
    {
        public static List<entity.COMPANY> Get_CompanyList(string companyno)
        {
            var companyList = new List<entity.COMPANY>();

            Result result = dbCaller.GetTable(
                "SELECT * FROM [dbo].[COMPANY] " +
                 "WHERE 1=1 " +
                 (companyno != "" ? " AND COMPANY_NO ='" + companyno + "' " : "") +
                 "ORDER BY  COMPANY_NAME ");
            if (!result.isErrorOccurred)
            {
                DataTable dt = result.resultAsDataTable;
                if (dt != null)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        DataRow row = dt.Rows[i];

                        companyList.Add(new entity.COMPANY()
                        {

                            COMPANY_NO = row["COMPANY_NO"].ToString(),
                            COMPANY_NAME = row["COMPANY_NAME"].ToString(),

                        });
                    }
                }
            }

            return companyList;
        }


        public static Lizay.dll.entity.COMPANY Get_CompanyByDetail(string Id)
        {
            Lizay.dll.entity.COMPANY company = new Lizay.dll.entity.COMPANY();


            Result result = dbCaller.GetTable("SELECT * FROM [dbo].[COMPANY] WHERE COMPANY_NO='" + Id + "'");
            if (!result.isErrorOccurred)
            {
                DataTable dt = result.resultAsDataTable;

                if (dt.Rows.Count > 0)
                {
                    company = new Lizay.dll.entity.COMPANY()
                    {

                        COMPANY_NO = dt.Rows[0]["COMPANY_NO"].ToString(),
                        COMPANY_NAME = dt.Rows[0]["COMPANY_NAME"].ToString(),
                    };


                }
            }
            else
            {
                throw new Exception(result.errorDescription);
            }

            return company;
        }
    }
}
