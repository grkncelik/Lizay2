using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Lizay.dll.method
{
    public static class ANNOUNCEMENT
    {
        public static Lizay.dll.entity.ANNOUNCEMENT Get_ById(int ANNOUNCE_ID)
        {
            var duyuru = new Lizay.dll.entity.ANNOUNCEMENT();

            string sql = "SELECT * FROM [dbo].[ANNOUNCEMENT] WHERE ID = " + ANNOUNCE_ID;
            Result dbResult = dbCaller.GetTable(sql);
            if (!dbResult.isErrorOccurred)
            {
                DataTable dt = dbResult.resultAsDataTable;

                if (dt != null && dt.Rows.Count > 0)
                {
                    DataRow r = dt.Rows[0];

                    duyuru = new entity.ANNOUNCEMENT()
                    {

                        TITLE = r["TITLE"].ToString(),
                        DESCRIPTION = r["DESCRIPTION"].ToString(),
                        IMG = r["IMG"].ToString(),
                        DOCFILE = r["DOCFILE"].ToString(),
                        TYPE = r["TYPE"].ToString(),
                        ISACTIVE = r["ISACTIVE"].ToString() != "" ? Convert.ToBoolean(r["ISACTIVE"].ToString()) : false,
                        PUB_DATE = Convert.ToDateTime(r["PUB_DATE"].ToString()),
                    };
                }
            }

            return duyuru;
        }


        public static List<Lizay.dll.entity.ANNOUNCEMENT> Get_AnnouncementsAll()
        {
            List<Lizay.dll.entity.ANNOUNCEMENT> announcements = new List<entity.ANNOUNCEMENT>();

            string sql = "SELECT * FROM [dbo].[ANNOUNCEMENT] ORDER BY ID DESC";
            Result dbResult = dbCaller.GetTable(sql);
            if (!dbResult.isErrorOccurred)
            {
                DataTable dt = dbResult.resultAsDataTable;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow r = dt.Rows[i];
                    announcements.Add(new entity.ANNOUNCEMENT()
                    {
                        ANNOUNCE_ID = Convert.ToInt32(r["ID"]),
                        TITLE = r["TITLE"].ToString(),
                        DESCRIPTION = r["DESCRIPTION"].ToString(),
                        IMG = r["IMG"].ToString(),
                        DOCFILE = r["DOCFILE"].ToString(),
                        TYPE = r["TYPE"].ToString(),
                        ISACTIVE = r["ISACTIVE"].ToString() != "" ? Convert.ToBoolean(r["ISACTIVE"].ToString()) : false,
                        PUB_DATE = Convert.ToDateTime(r["PUB_DATE"].ToString()),
                    });
                }
            }
            else
            {
                throw new Exception(dbResult.errorDescription);
            }
            return announcements;
        }

        public static List<Lizay.dll.entity.ANNOUNCEMENT> Get_Announcements(string where)
        {
            List<Lizay.dll.entity.ANNOUNCEMENT> announcements = new List<entity.ANNOUNCEMENT>();

            string sql = "SELECT * FROM [dbo].[ANNOUNCEMENT] WHERE 1=1 AND TYPE='" + where + "' ORDER BY ID DESC";
            Result dbResult = dbCaller.GetTable(sql);
            if (!dbResult.isErrorOccurred)
            {
                DataTable dt = dbResult.resultAsDataTable;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow r = dt.Rows[i];
                    announcements.Add(new entity.ANNOUNCEMENT()
                    {

                        TITLE = r["TITLE"].ToString(),
                        DESCRIPTION = r["DESCRIPTION"].ToString(),
                        IMG = r["IMG"].ToString(),
                        DOCFILE = r["DOCFILE"].ToString(),
                        TYPE = r["TYPE"].ToString(),
                        ISACTIVE = r["ISACTIVE"].ToString() != "" ? Convert.ToBoolean(r["ISACTIVE"].ToString()) : false,
                        PUB_DATE = Convert.ToDateTime(r["PUB_DATE"].ToString()),
                    });
                }
            }
            else
            {
                throw new Exception(dbResult.errorDescription);
            }
            return announcements;
        }



        public static void Add(Lizay.dll.entity.ANNOUNCEMENT duyuru)
        {
            string sql =
                    "INSERT INTO [dbo].[ANNOUNCEMENT] " +
                                 "(TITLE,DESCRIPTION,IMG, TYPE,ISACTIVE,PUB_DATE,DOCFILE) " +
                         "VALUES ('" + duyuru.TITLE + "','" + duyuru.DESCRIPTION.Replace("'", "′") + "','" + duyuru.IMG + "','" + duyuru.TYPE + "','" + duyuru.ISACTIVE.ToString() + "',CONVERT(DATE,'" + duyuru.PUB_DATE + "',103),'"+duyuru.DOCFILE+"')";

            Result result = dbCaller.ExecuteSql(sql);
            if (result.isErrorOccurred)
                throw new Exception(result.errorDescription);
        }

        public static void Update(Lizay.dll.entity.ANNOUNCEMENT duyuru)
        {
            string sql =
                "UPDATE [dbo].[ANNOUNCEMENT] " +
                   "SET TITLE='" + duyuru.TITLE + "', " +
                       "DESCRIPTION = '" + duyuru.DESCRIPTION.Replace("'", "′") + "', " +
                       (duyuru.IMG != "" ? "RESIM = '" + duyuru.IMG + "', " : "") +
                       (duyuru.DOCFILE != "" ? "DOCFILE = '" + duyuru.DOCFILE + "', " : "") +
                       "TYPE = '" + duyuru.TYPE + "', " +
                       "ISACTIVE = '" + duyuru.ISACTIVE.ToString() + "' " +
                 "WHERE ID= " + duyuru.ANNOUNCE_ID;

            Result result = dbCaller.ExecuteSql(sql);
            if (result.isErrorOccurred)
                throw new Exception(result.errorDescription);

        }

        public static void Delete(int ANNOUNCE_ID)
        {

            string sql = "DELETE FROM [dbo].[ANNOUNCEMENT] WHERE ID= " + ANNOUNCE_ID;
            Result result = dbCaller.ExecuteSql(sql);
            if (result.isErrorOccurred)
                throw new Exception(result.errorDescription);

        }
    }
}
