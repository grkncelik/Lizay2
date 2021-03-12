using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Lizay.dll.method
{
    public class CHARTLIST
    {
        public static List<entity.CHARTLIST> Get_List(string ZiyaretEden = "")
        {
            var list = new List<entity.CHARTLIST>();


            /*string sql = @"SELECT SUM(CONVERT(DECIMAL(18,2),SUBTOTAL)) AS TOPLAM,SALDEPTX from [dbo].[MOBILEXPENSELIST] 
                           WHERE CONVERT(DECIMAL(18,2),SUBTOTAL)>0 AND SALDEPTX!='Genel Toplam' AND DATATYPE='MAĞAZA' AND TEGI!='2'
						   AND MONTH(CONVERT(DATE,DOCDATE,103))=MONTH(GETDATE()) AND YEAR(CONVERT(DATE,DOCDATE,103))=YEAR(GETDATE())
                           GROUP BY SALDEPTX
                           ORDER BY TOPLAM DESC";*/

            string sql = @"SELECT SUM(CONVERT(DECIMAL(18,2),SUBTOTAL)) AS TOPLAM,SALDEPTX from [dbo].[MOBILEXPENSELIST] 
                           WHERE CONVERT(DECIMAL(18,2),SUBTOTAL)>0 AND SALDEPTX!='Genel Toplam' AND DATATYPE='MAĞAZA' AND TEGI!='2'
						   AND DOCDATEM=" + DateTime.Now.Month.ToString() + " AND DOCDATEY=" + DateTime.Now.Year.ToString() +
                           " GROUP BY SALDEPTX" +
                           " ORDER BY TOPLAM DESC";

            var dbResult = dbCaller.GetTable(sql);

            if (!dbResult.isErrorOccurred)
            {
                if (dbResult.resultAsDataTable != null)
                {
                    DataTable dt = dbResult.resultAsDataTable;
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        DataRow r = dt.Rows[i];

                        list.Add(new entity.CHARTLIST()
                        {
                            Name = r["SALDEPTX"].ToString(),
                            Value = r["TOPLAM"].ToString().Replace(",", "."),


                        });
                    }
                }

            }

            return list;
        }


        public static List<entity.CHARTLIST> Get_List2(string ZiyaretEden = "")
        {
            var list = new List<entity.CHARTLIST>();


            /*string sql = @"SELECT SUM(CONVERT(DECIMAL(18,2),SUBTOTAL)) AS TOPLAM,SALDEPTX from [dbo].[MOBILEXPENSELIST] 
                           WHERE CONVERT(DECIMAL(18,2),SUBTOTAL)>0 AND SALDEPTX!='Genel Toplam' AND DATATYPE='MAĞAZA' AND TEGI!='2'
						   AND MONTH(CONVERT(DATE,DOCDATE,103))=MONTH(GETDATE()) AND YEAR(CONVERT(DATE,DOCDATE,103))=YEAR(GETDATE())
                           GROUP BY SALDEPTX
                           ORDER BY TOPLAM DESC";*/

            string sql = @"SELECT ((SUM(CAST(TOTPROF AS DECIMAL(18, 0)))/SUM(CAST(TCOST AS DECIMAL(18, 0))))*100) AS TOTAL,SALDEPTX from [dbo].[MOBILEXPENSELIST] 
                           WHERE DATATYPE='MAĞAZA' AND TEGI!='2'
						   AND DOCDATEM=" + DateTime.Now.Month.ToString() + " AND DOCDATEY=" + DateTime.Now.Year.ToString() +
                           " GROUP BY SALDEPTX" +
                           " ORDER BY TOTAL DESC";

            var dbResult = dbCaller.GetTable(sql);

            if (!dbResult.isErrorOccurred)
            {
                if (dbResult.resultAsDataTable != null)
                {
                    DataTable dt = dbResult.resultAsDataTable;
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        DataRow r = dt.Rows[i];

                        list.Add(new entity.CHARTLIST()
                        {
                            Name = r["SALDEPTX"].ToString(),
                            Value = r["TOTAL"].ToString().Replace(",", "."),


                        });
                    }
                }

            }

            return list;
        }



        public static List<entity.CHARTLIST> Get_ListPersonel(string ZiyaretEden = "")
        {
            var list = new List<entity.CHARTLIST>();


            string sql = @"SELECT TOP 7 SUM(CONVERT(DECIMAL(18,2),SUBTOTAL)) AS TOPLAM,SALDEPTX from [dbo].[MOBILEXPENSELIST] 
                           WHERE CONVERT(DECIMAL(18,2),SUBTOTAL)>0 AND SALDEPTX!='Genel Toplam' AND DATATYPE='PERSONEL'
                           GROUP BY SALDEPTX
                           ORDER BY TOPLAM DESC";

            var dbResult = dbCaller.GetTable(sql);

            if (!dbResult.isErrorOccurred)
            {
                if (dbResult.resultAsDataTable != null)
                {
                    DataTable dt = dbResult.resultAsDataTable;
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        DataRow r = dt.Rows[i];

                        list.Add(new entity.CHARTLIST()
                        {
                            Name = r["SALDEPTX"].ToString(),
                            Value = r["TOPLAM"].ToString().Replace(",", "."),


                        });
                    }
                }

            }

            return list;
        }
    }
}
