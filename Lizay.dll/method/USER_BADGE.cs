using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Lizay.dll.method
{
    public class USER_BADGE
    {

        public static List<entity.USER_BADGE> Get_OdulList()
        {
            var badgeList = new List<entity.USER_BADGE>();

            Result result = dbCaller.GetTable(
                "SELECT * FROM [dbo].[USER_BADGE] " +
                 "WHERE 1=1 AND BADGE_ID=13");
            if (!result.isErrorOccurred)
            {
                DataTable dt = result.resultAsDataTable;
                if (dt != null)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        DataRow row = dt.Rows[i];

                        badgeList.Add(new entity.USER_BADGE()
                        {
                            ID = Convert.ToInt32(row["ID"].ToString()),
                            USER_ID = row["USER_ID"].ToString(),
                            BADGE_ID = Convert.ToInt32(row["BADGE_ID"].ToString()),
                            CREATED_DATE = Convert.ToDateTime(row["CREATED_DATE"].ToString()),
                            COMPANY_NO = row["COMPANY_NO"].ToString(),
                            ISACTIVE = Convert.ToBoolean(row["ISACTIVE"].ToString() != "" ? row["ISACTIVE"].ToString() : "false"),
                        });
                    }
                }
            }

            return badgeList;
        }


        public static void AddNewOdul(Lizay.dll.entity.USER_BADGE badge)
        {
            Result result = dbCaller.ExecuteSql(
                "INSERT INTO [dbo].[USER_BADGE] " +
                           "(USER_ID, BADGE_ID, CREATED_DATE,MODIFIED_DATE,DELETED,ISACTIVE,COMPANY_NO) " +
                    "VALUES ('000',13,CONVERT(DATE,'" + badge.CREATED_DATE + "',103),CONVERT(DATE,'" + badge.MODIFIED_DATE + "',103),'0','1','" + badge.COMPANY_NO + "')");

            if (result.isErrorOccurred)
                throw new Exception(result.errorDescription);
        }

        public static void AddNewOdulMonthly(Lizay.dll.entity.USER_BADGE badge)
        {
            Result result = dbCaller.ExecuteSql(
                "INSERT INTO [dbo].[USER_BADGE] " +
                           "(USER_ID, BADGE_ID, CREATED_DATE,MODIFIED_DATE,DELETED,ISACTIVE,COMPANY_NO) " +
                    "VALUES ('" + badge.USER_ID + "'," + badge.BADGE_ID+",CONVERT(DATE,'" + badge.CREATED_DATE + "',103),CONVERT(DATE,'" + badge.MODIFIED_DATE + "',103),'0','1','" + badge.COMPANY_NO + "')");

            if (result.isErrorOccurred)
                throw new Exception(result.errorDescription);
        }


        public static void DeleteOdul(int Id)
        {

            Result result = dbCaller.ExecuteSql("DELETE FROM [dbo].[USER_BADGE] WHERE ID=" + Id);
            if (result.isErrorOccurred)
                throw new Exception(result.errorDescription);
        }


        public static int Get_BadgeCount(string username, string companyno, int badgeid)
        {
            int badgecount = 0;

            Result result = dbCaller.GetTable(
                "SELECT COUNT(*) AS BADGECOUNT FROM [dbo].[USER_BADGE] " +
                 "WHERE 1=1 " +
                 (username != "" ? " AND USER_ID ='" + username + "' " : "") +
                 (companyno != "" ? " AND COMPANY_NO ='" + companyno + "' " : "") +
                 (badgeid != 0 ? " AND BADGE_ID =" + badgeid : "") +
                 "");
            if (!result.isErrorOccurred)
            {
                DataTable dt = result.resultAsDataTable;
                if (dt != null)
                {

                    DataRow row = dt.Rows[0];

                    badgecount = Convert.ToInt32(row["BADGECOUNT"].ToString());

                }
            }

            return badgecount;
        }


        public static int Get_TotalBadgeCount(string username, string companyno)
        {
            int badgecount = 0;

            Result result = dbCaller.GetTable(
                "SELECT COUNT(*) AS BADGECOUNT FROM [dbo].[USER_BADGE] " +
                 "WHERE 1=1 " +
                 (username != "" ? " AND USER_ID ='" + username + "' " : "") +
                 (companyno != "" ? " AND COMPANY_NO ='" + companyno + "' " : "") +
                 "");
            if (!result.isErrorOccurred)
            {
                DataTable dt = result.resultAsDataTable;
                if (dt != null)
                {

                    DataRow row = dt.Rows[0];

                    badgecount = Convert.ToInt32(row["BADGECOUNT"].ToString());

                }
            }

            return badgecount;
        }
    }
}
