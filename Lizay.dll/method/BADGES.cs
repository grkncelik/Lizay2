using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Lizay.dll.method
{
    public class BADGES
    {
        public static List<entity.BADGES> Get_BadgeList()
        {
            var badgeList = new List<entity.BADGES>();

            Result result = dbCaller.GetTable(
                "SELECT * FROM [dbo].[BADGES] ORDER BY ID");
            if (!result.isErrorOccurred)
            {
                DataTable dt = result.resultAsDataTable;
                if (dt != null)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        DataRow row = dt.Rows[i];

                        badgeList.Add(new entity.BADGES()
                        {

                            BADGENAME = row["BADGENAME"].ToString(),
                            BADGELOGO = row["BADGELOGO"].ToString(),

                        });
                    }
                }
            }

            return badgeList;
        }
    }
}
