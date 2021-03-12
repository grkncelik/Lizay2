using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Lizay.dll.method
{
    public class SLIDER
    {
        public static Lizay.dll.entity.SLIDER Get_ById(int BANNER_ID)
        {
            var banner = new Lizay.dll.entity.SLIDER();

            string sql = "SELECT * FROM [dbo].[SLIDER] WHERE ID = " + BANNER_ID;
            Result dbResult = dbCaller.GetTable(sql);
            if (!dbResult.isErrorOccurred)
            {
                DataTable dt = dbResult.resultAsDataTable;

                if (dt != null && dt.Rows.Count > 0)
                {
                    DataRow r = dt.Rows[0];

                    banner = new entity.SLIDER()
                    {
                        BANNER_ID = Convert.ToInt32(r["ID"].ToString()),
                        IMG = r["IMG"].ToString(),
                        CREATED_DATE = Convert.ToDateTime(r["CREATED_DATE"].ToString()),
                        ISACTIVE = r["ISACTIVE"].ToString() != "" ? Convert.ToBoolean(r["ISACTIVE"].ToString()) : false,

                    };
                }
            }

            return banner;
        }

        public static List<Lizay.dll.entity.SLIDER> Get_SlideBannerId(int BayiKodu)
        {
            List<Lizay.dll.entity.SLIDER> slidebanner = new List<entity.SLIDER>();

            string sql = "SELECT * FROM [dbo].[SLIDER]  ORDER BY ID DESC";
            Result dbResult = dbCaller.GetTable(sql);
            if (!dbResult.isErrorOccurred)
            {
                DataTable dt = dbResult.resultAsDataTable;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow r = dt.Rows[i];
                    slidebanner.Add(new entity.SLIDER()
                    {
                        BANNER_ID = Convert.ToInt32(r["ID"].ToString()),
                        IMG = r["IMG"].ToString(),
                        CREATED_DATE = Convert.ToDateTime(r["CREATED_DATE"].ToString()),
                        ISACTIVE = r["ISACTIVE"].ToString() != "" ? Convert.ToBoolean(r["ISACTIVE"].ToString()) : false,
                    });
                }
            }
            else
            {
                throw new Exception(dbResult.errorDescription);
            }
            return slidebanner;
        }

        public static List<Lizay.dll.entity.SLIDER> Get_SlideBanners()
        {
            List<Lizay.dll.entity.SLIDER> slidebanner = new List<entity.SLIDER>();

            string sql = "SELECT * FROM [dbo].[SLIDER] ORDER BY ID DESC";
            Result dbResult = dbCaller.GetTable(sql);
            if (!dbResult.isErrorOccurred)
            {
                DataTable dt = dbResult.resultAsDataTable;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow r = dt.Rows[i];
                    slidebanner.Add(new entity.SLIDER()
                    {
                        BANNER_ID = Convert.ToInt32(r["ID"].ToString()),
                        IMG = r["IMG"].ToString(),
                        CREATED_DATE = Convert.ToDateTime(r["CREATED_DATE"].ToString()),
                        ISACTIVE = r["ISACTIVE"].ToString() != "" ? Convert.ToBoolean(r["ISACTIVE"].ToString()) : false,
                    });
                }
            }
            else
            {
                throw new Exception(dbResult.errorDescription);
            }
            return slidebanner;
        }


        public static void Add(Lizay.dll.entity.SLIDER banner)
        {
            string sql =
                    "INSERT INTO [dbo].[SLIDER] " +
                                 "(IMG, ISACTIVE,CREATED_DATE) " +
                         "VALUES ('" + banner.IMG + "','" + banner.ISACTIVE.ToString() + "',CONVERT(DATE,'" + banner.CREATED_DATE + "',103)))";

            Result result = dbCaller.ExecuteSql(sql);
            if (result.isErrorOccurred)
                throw new Exception(result.errorDescription);
        }

        public static void Update(Lizay.dll.entity.SLIDER banner)
        {

                string sql =
                    "UPDATE [dbo].[SLIDER] " +
                       "SET " +
                           (banner.IMG != "" ? "IMG = '" + banner.IMG + "', " : "") +
                           "ISACTIVE = '" + banner.ISACTIVE.ToString() + "' " +
                     "WHERE ID= " + banner.BANNER_ID;

                Result result = dbCaller.ExecuteSql(sql);
                if (result.isErrorOccurred)
                    throw new Exception(result.errorDescription);
            
        }

        public static void Delete(int BANNER_ID)
        {
                string sql = "DELETE FROM [dbo].[SLIDER] WHERE ID= " + BANNER_ID;
                Result result = dbCaller.ExecuteSql(sql);
                if (result.isErrorOccurred)
                    throw new Exception(result.errorDescription);
            
        }
    }
}
