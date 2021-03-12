using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Lizay.dll.method
{
    public class COMPANY_ANNOUNCEMENT
    {
        public static List<entity.COMPANY_ANNOUNCEMENT> Get_AnnouncementList(string companyno)
        {
            var announcementList = new List<entity.COMPANY_ANNOUNCEMENT>();

            Result result = dbCaller.GetTable(
                "SELECT * FROM [dbo].[COMPANY_ANNOUNCEMENT] " +
                 "WHERE 1=1 " +
                 (companyno != "" ? " AND COMPANY_NO ='" + companyno + "' " : "") +
                 "ORDER BY ID ");
            if (!result.isErrorOccurred)
            {
                DataTable dt = result.resultAsDataTable;
                if (dt != null)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        DataRow row = dt.Rows[i];

                        announcementList.Add(new entity.COMPANY_ANNOUNCEMENT()
                        {

                            ANNOUNCEMENT_ID = Convert.ToInt32(row["ANNOUNCEMENT_ID"].ToString()),

                        });
                    }
                }
            }

            return announcementList;
        }
    }
}
