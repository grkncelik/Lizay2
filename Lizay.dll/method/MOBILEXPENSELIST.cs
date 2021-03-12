using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Lizay.dll.method
{
    public class MOBILEXPENSELIST
    {

        public static void DeleteData(string company, string year, string month, string day, string type)
        {

            string sql = "DELETE FROM [dbo].[MOBILEXPENSELIST] WHERE " +
                         "COMPANY='" + company + "' " +
                         "AND DOCDATEY='" + year + "' " +
                         "AND DOCDATEM='" + month + "' " +
                         //"AND DOCDATDAY='" + day + "' " +
                         "AND DATATYPE='" + type + "' ";
            Result result = dbCaller.ExecuteSql(sql);
            if (result.isErrorOccurred)
                throw new Exception(result.errorDescription);
        }

        public static string Get_TotalPuanPersonel(string username)
        {
            string totalpoint = "0";

            Result result = dbCaller.GetTable(
                @"SELECT SUM(CAST(PUAN AS DECIMAL(18, 2)))AS TOTAL FROM [LizayDB].[dbo].[MOBILEXPENSELIST]
                    WHERE TEGI='2' AND PUAN!='[]' AND SALDEPT='" + username + "'" +
                    " GROUP BY SALDEPT ");
            if (!result.isErrorOccurred)
            {
                DataTable dt = result.resultAsDataTable;
                if (dt != null)
                {
                    if (dt.Rows.Count != 0)
                    {
                        DataRow row = dt.Rows[0];

                        totalpoint = string.Format("{0:###,###}", Convert.ToDecimal(row["TOTAL"].ToString()));
                    }

                }
            }

            return totalpoint;
        }

        public static string Get_TotalPuanCompany(string companyno)
        {
            string totalpoint = "0";

            Result result = dbCaller.GetTable(
                @"SELECT SUM(CAST(PUAN AS DECIMAL(18, 2)))AS TOTAL FROM [LizayDB].[dbo].[MOBILEXPENSELIST]
                    WHERE TEGI='2' AND PUAN!='[]' AND BUSAREA='" + companyno + "'" +
                    " GROUP BY BUSAREA ");
            if (!result.isErrorOccurred)
            {
                DataTable dt = result.resultAsDataTable;
                if (dt != null)
                {

                    DataRow row = dt.Rows[0];

                    totalpoint = string.Format("{0:###,###}", Convert.ToDecimal(row["TOTAL"].ToString()));

                }
            }

            return totalpoint;
        }

        public static List<entity.MOBILEXPENSELIST> Get_ListSalesCompany(string param = "")
        {
            var list = new List<entity.MOBILEXPENSELIST>();


            //string sql = @"SELECT M.[SALDEPTX],M.[BUSAREA] ,((SUM(CAST(M.SUBTOTAL AS DECIMAL(18, 2))) / CAST(C.MAGAZAORAN AS DECIMAL(18, 2)))*100) AS TOTAL FROM [LizayDB].[dbo].[MOBILEXPENSELIST] M INNER JOIN [LizayDB].[dbo].[COMPANYTARGETRATE] C ON M.BUSAREA=C.BUSAREA
            //                WHERE M.DATATYPE='MAĞAZA' AND M.BUSAREA!='[]' AND M.TEGI='2' 
            //                AND M.DOCDATEM=" + DateTime.Now.Month.ToString() + " AND M.DOCDATEY=" + DateTime.Now.Year.ToString() +
            //                " GROUP BY M.[SALDEPTX],M.[BUSAREA],C.MAGAZAORAN" +
            //                " ORDER BY TOTAL DESC";


            var sql = @"SELECT M.[BUSAREA] ,((SUM(CAST(M.SUBTOTAL AS DECIMAL(18, 2))) / CAST(C.MAGAZAORAN AS DECIMAL(18, 2)))*100) AS TOTAL,
                            SUM(CAST(M.SUBTOTAL AS DECIMAL(18, 2))) AS TOPLAM,CAST(C.MAGAZAORAN AS DECIMAL(18, 2)) AS MAGAZAORAN
                            FROM [LizayDB].[dbo].[MOBILEXPENSELIST] M INNER JOIN [LizayDB].[dbo].[COMPANYTARGETRATE] C ON M.BUSAREA=C.BUSAREA
                            WHERE M.DATATYPE='MAĞAZA' AND M.BUSAREA!='[]' AND M.TEGI='2' 
                            AND M.DOCDATEM=" + DateTime.Now.Month + " AND M.DOCDATEY=" + DateTime.Now.Year +
                            " GROUP BY M.[BUSAREA],C.MAGAZAORAN" +
                            " ORDER BY TOTAL DESC";

            var dbResult = dbCaller.GetTable(sql);

            if (dbResult.isErrorOccurred) return list;
            if (dbResult.resultAsDataTable == null) return list;
            var dt = dbResult.resultAsDataTable;
            for (var i = 0; i < dt.Rows.Count; i++)
            {
                var r = dt.Rows[i];

                list.Add(new entity.MOBILEXPENSELIST
                {
                    SALDEPTX = GetCompanyName(r["BUSAREA"].ToString()),
                    BUSAREA = r["BUSAREA"].ToString(),
                    SUBTOTAL = r["TOTAL"].ToString(),
                    Toplam = r["TOPLAM"].ToString(),
                    MagazaOran = r["MAGAZAORAN"].ToString()
                });
            }

            return list;
        }

        public static string GetCompanyName(string BusAreaId)
        {
            string Name = "";

            Name = Lizay.dll.method.COMPANY.Get_CompanyByDetail(BusAreaId).COMPANY_NAME;

            return Name;
        }

        public static List<entity.MOBILEXPENSELIST> Get_ListSalesPerson(string param = "")
        {
            var list = new List<entity.MOBILEXPENSELIST>();


            string sql = @"SELECT SALDEPTX,BUSAREA,SUM(CAST(PUAN AS DECIMAL(18, 2)))AS TOTAL FROM [LizayDB].[dbo].[MOBILEXPENSELIST]
                            WHERE TEGI='2' AND DATATYPE='PERSONEL'AND PUAN!='[]'
                            AND DOCDATEM=" + DateTime.Now.Month.ToString() + " AND DOCDATEY=" + DateTime.Now.Year.ToString() +
                            " GROUP BY SALDEPTX,BUSAREA" +
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

                        list.Add(new entity.MOBILEXPENSELIST()
                        {
                            SALDEPTX = r["SALDEPTX"].ToString(),
                            SALDEPT = r["BUSAREA"].ToString(),
                            SUBTOTAL = string.Format("{0:##,###}", Convert.ToDecimal(r["TOTAL"].ToString())),


                        });
                    }
                }

            }

            return list;
        }

        public static List<entity.MOBILEXPENSELIST> Get_EnCokSatanMagaza()
        {
            var list = new List<entity.MOBILEXPENSELIST>();


            string sql = @"SELECT TOP 3 M.SALDEPTX,M.BUSAREA, ((SUM(CAST(M.SUBTOTAL AS DECIMAL(18, 2))) / CAST(C.MAGAZAORAN AS DECIMAL(18, 2)))*100) AS TOTAL
                                FROM [LizayDB].[dbo].[MOBILEXPENSELIST] M INNER JOIN [LizayDB].[dbo].[COMPANYTARGETRATE] C ON M.BUSAREA=C.BUSAREA
                                WHERE M.DATATYPE='MAĞAZA' AND M.TEGI='2'
                                AND M.DOCDATEM=" + DateTime.Now.Month.ToString() + " AND M.DOCDATEY=" + DateTime.Now.Year.ToString() +
                            " GROUP BY M.SALDEPTX,C.MAGAZAORAN,M.BUSAREA" +
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

                        list.Add(new entity.MOBILEXPENSELIST()
                        {
                            SALDEPTX = r["SALDEPTX"].ToString(),
                            BUSAREA = r["BUSAREA"].ToString(),
                            SUBTOTAL = r["TOTAL"].ToString(),


                        });
                    }
                }

            }

            return list;
        }

        public static List<entity.MOBILEXPENSELIST> Get_EnKarliSatanMagaza()
        {
            var list = new List<entity.MOBILEXPENSELIST>();


            string sql = @"SELECT TOP 3 SALDEPTX,BUSAREA,((SUM(CAST(TOTPROF AS DECIMAL(18, 0)))/SUM(CAST(TCOST AS DECIMAL(18, 0))))*100)AS TOTAL
                            FROM [LizayDB].[dbo].[MOBILEXPENSELIST]
                            WHERE DATATYPE='MAĞAZA' AND TEGI='2'
                            AND DOCDATEM=" + DateTime.Now.Month.ToString() + " AND DOCDATEY=" + DateTime.Now.Year.ToString() +
                            " GROUP BY SALDEPTX,BUSAREA" +
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

                        list.Add(new entity.MOBILEXPENSELIST()
                        {
                            SALDEPTX = r["SALDEPTX"].ToString(),
                            BUSAREA = r["BUSAREA"].ToString(),
                            SUBTOTAL = r["TOTAL"].ToString(),


                        });
                    }
                }

            }

            return list;
        }

        public static List<entity.MOBILEXPENSELIST> Get_EnBasariliPirlantaSatanMagaza()
        {
            var list = new List<entity.MOBILEXPENSELIST>();


            string sql = @"SELECT TOP 3 M.SALDEPTX,M.BUSAREA, ((SUM(CAST(M.SUBTOTAL AS DECIMAL(18, 2))) / CAST(C.MAGAZAORAN AS DECIMAL(18, 2)))*100) AS TOTAL
                        FROM [LizayDB].[dbo].[MOBILEXPENSELIST] M INNER JOIN [LizayDB].[dbo].[COMPANYTARGETRATE] C ON M.BUSAREA=C.BUSAREA
                        WHERE M.DATATYPE='MAĞAZA' AND M.MATTYPE='YTCM' AND TEGI!='2'
                        AND M.DOCDATEM=" + DateTime.Now.Month.ToString() + " AND M.DOCDATEY=" + DateTime.Now.Year.ToString() +
                        " GROUP BY M.SALDEPTX,C.MAGAZAORAN,M.BUSAREA" +
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

                        list.Add(new entity.MOBILEXPENSELIST()
                        {
                            SALDEPTX = r["SALDEPTX"].ToString(),
                            BUSAREA = r["BUSAREA"].ToString(),
                            SUBTOTAL = r["TOTAL"].ToString(),


                        });
                    }
                }

            }

            return list;
        }

        public static List<entity.MOBILEXPENSELIST> Get_EnBasariliAltinSatanMagaza()
        {
            var list = new List<entity.MOBILEXPENSELIST>();


            string sql = @"SELECT TOP 3 M.SALDEPTX,M.BUSAREA, ((SUM(CAST(M.SUBTOTAL AS DECIMAL(18, 2))) / CAST(C.MAGAZAORAN AS DECIMAL(18, 2)))*100) AS TOTAL
                        FROM [LizayDB].[dbo].[MOBILEXPENSELIST] M INNER JOIN [LizayDB].[dbo].[COMPANYTARGETRATE] C ON M.BUSAREA=C.BUSAREA
                        WHERE M.DATATYPE='MAĞAZA' AND (M.MATTYPE='AMML' OR MATTYPE='ALYM') AND TEGI!='2'
                        AND M.DOCDATEM=" + DateTime.Now.Month.ToString() + " AND M.DOCDATEY=" + DateTime.Now.Year.ToString() +
                        " GROUP BY M.SALDEPTX,C.MAGAZAORAN,M.BUSAREA" +
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

                        list.Add(new entity.MOBILEXPENSELIST()
                        {
                            SALDEPTX = r["SALDEPTX"].ToString(),
                            BUSAREA = r["BUSAREA"].ToString(),
                            SUBTOTAL = r["TOTAL"].ToString(),


                        });
                    }
                }

            }

            return list;
        }

        public static List<entity.MOBILEXPENSELIST> Get_EnCokSatanPersonel()
        {
            var list = new List<entity.MOBILEXPENSELIST>();


            string sql = @"SELECT TOP 3 (SELECT COMPANY_NAME FROM COMPANY WHERE COMPANY_NO=BUSAREA) AS MAGAZA_ADI ,SALDEPTX,SALDEPT,SUM(CAST(PUAN AS DECIMAL(18, 2)))AS PUAN FROM [LizayDB].[dbo].[MOBILEXPENSELIST]
                            WHERE TEGI='2' AND DATATYPE='PERSONEL'AND PUAN!='[]'
                            AND DOCDATEM=" + DateTime.Now.Month.ToString() + " AND DOCDATEY=" + DateTime.Now.Year.ToString() +
                            " GROUP BY SALDEPTX,SALDEPT,BUSAREA" +
                            " ORDER BY PUAN DESC";

            var dbResult = dbCaller.GetTable(sql);

            if (!dbResult.isErrorOccurred)
            {
                if (dbResult.resultAsDataTable != null)
                {
                    DataTable dt = dbResult.resultAsDataTable;
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        DataRow r = dt.Rows[i];

                        list.Add(new entity.MOBILEXPENSELIST()
                        {
                            SALDEPTX = r["SALDEPTX"].ToString(),
                            SALDEPT = r["SALDEPT"].ToString(),
                            SUBTOTAL = r["PUAN"].ToString(),
                            MagazaAdi = r["MAGAZA_ADI"].ToString(),
                        });
                    }
                }

            }

            return list;
        }

        public static List<entity.MOBILEXPENSELIST> Get_EnKarliSatanPersonel()
        {
            var list = new List<entity.MOBILEXPENSELIST>();


            string sql = @"SELECT TOP 3 (SELECT COMPANY_NAME FROM COMPANY WHERE COMPANY_NO=BUSAREA) AS MAGAZA_ADI ,SALDEPTX,SALDEPT,((SUM(CAST(TOTPROF AS DECIMAL(18, 2)))/SUM(CAST(TCOST AS DECIMAL(18, 2))))*100)AS TOTAL
                            FROM [LizayDB].[dbo].[MOBILEXPENSELIST]
                            WHERE DATATYPE='PERSONEL' AND TEGI='2'
                            AND DOCDATEM=" + DateTime.Now.Month.ToString() + " AND DOCDATEY=" + DateTime.Now.Year.ToString() +
                            " GROUP BY SALDEPTX,SALDEPT,BUSAREA" +
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

                        list.Add(new entity.MOBILEXPENSELIST()
                        {
                            SALDEPTX = r["SALDEPTX"].ToString(),
                            SALDEPT = r["SALDEPT"].ToString(),
                            SUBTOTAL = r["TOTAL"].ToString(),
                            MagazaAdi = r["MAGAZA_ADI"].ToString()
                        });
                    }
                }

            }

            return list;
        }

        public static void AddData(entity.MOBILEXPENSELIST data)
        {

            var sql = @"INSERT INTO [dbo].[MOBILEXPENSELIST] 
                                          ([SATISD],[SALDEPT],[COMPANY],[DOCTYPE],
                                           [DOCNUM],[DOCDATE],[CUSTOMER],
                                           [NAME1],[INVTYPE],[CUSTGRP],
                                           [COUNTRY],[DISCAMNT],[CURRENCY],[ITEMNUM],[MATERIAL],
                                           [MTEXT],[QUANTITY],[QUNIT],
                                           [BUSAREA],[SPRICE],[PRICEFACTOR],
                                           [GROSS],[TDISCAMNT],[DISCFROMHEAD],[SUBTOTAL],
                                           [ITENDORSE],[MATTYPE],[MATGRP],[EXHM],
                                           [EXHR],[MONTSUBTOTAL],
                                           [YEARSUBTOTAL],[MONTHQUANTITY],[YEARQUANTITY],
                                           [ISVARIANT],[QUANTITYX],[TCOST],[BATCHNUM],
                                           [TOTPROF],[TOTRATE],[PRINTEDINVNUM],
                                           [MAINMATGRP],[PAYMCOND],[PAYMTYPE],[SCMADEN],
                                           [SCGRUP],[SCTEMEL],[SALDEPTX],[TEGI],
                                           [TERW],[PUAN],[DATATYPE],[DOCDATEM],
                                           [DOCDATEY],[DOCDATDAY]) " +

                      "VALUES ('" + data.SATISD.Trim() + "','" + data.SALDEPT.Trim() + "','" + data.COMPANY.Trim() + "','" + data.DOCTYPE.Trim() + "','" +
                      data.DOCNUM.Trim() + "','" + data.DOCDATE.Trim() + "','" + data.CUSTOMER.Trim() + "','" +
                      data.NAME1.Replace("'", "").Trim() + "','" + data.INVTYPE.Trim() + "','" + data.CUSTGRP.Trim() + "','" +
                      data.COUNTRY.Trim() + "'" + " ,'" + data.DISCAMNT.Trim() + "','" + data.CURRENCY.Trim() + "','" + data.ITEMNUM.Trim() + "','" + data.MATERIAL.Trim() + "','" +
                      data.MTEXT.Replace("'", "").Trim() + "','" + data.QUANTITY.Trim() + "','" + data.QUNIT.Trim() + "','" +
                      data.BUSAREA.Trim() + "','" + data.SPRICE.Trim() + "','" + data.PRICEFACTOR.Trim() + "'" + " ,'" +
                      data.GROSS.Trim() + "','" + data.TDISCAMNT.Trim() + "','" + data.DISCFROMHEAD.Trim() + "','" + data.SUBTOTAL.Trim() + "','" +
                      data.ITENDORSE.Trim() + "','" + data.MATTYPE.Trim() + "','" + data.MATGRP.Trim() + "','" + data.EXHM.Trim() + "','" +
                      data.EXHR.Trim() + "','" + data.MONTSUBTOTAL.Trim() + "'" + " ,'" +
                      data.YEARSUBTOTAL.Trim() + "','" + data.MONTHQUANTITY.Trim() + "','" + data.YEARQUANTITY.Trim() + "','" +
                      data.ISVARIANT.Trim() + "','" + data.QUANTITYX.Trim() + "','" + data.TCOST.Trim() + "','" + data.BATCHNUM.Trim() + "','" +
                      data.TOTPROF.Trim() + "','" + data.TOTRATE.Trim() + "','" + data.PRINTEDINVNUM.Trim() + "'" + " ,'" +
                      data.MAINMATGRP.Trim() + "','" + data.PAYMCOND.Trim() + "','" + data.PAYMTYPE.Trim() + "','" + data.SCMADEN.Trim() + "','" +
                      data.SCGRUP.Trim() + "','" + data.SCTEMEL.Trim() + "','" + data.SALDEPTX.Trim() + "','" + data.TEGI.Trim() + "','" +
                      data.TERW.Trim() + "','" + data.PUAN.Trim() + "','" + data.DATATYPE.Trim() + "','" + data.DOCDATEM.Trim() + "','" +
                      data.DOCDATEY.Trim() + "','" + data.DOCDATDAY.Trim() + "')";

            var result = dbCaller.ExecuteSql(sql);

            if (result.isErrorOccurred)
                throw new Exception(result.errorDescription);
        }

        public static void AddDataSqlBulk(DataTable dt)
        {
            try
            {
                dbCaller.ExecuteQuery(dt, "MOBILEXPENSELIST");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }




        public static void LogAdd(string title, string description, string statu)
        {
            string sql =
                    "INSERT INTO [dbo].[LOG] " +
                                 "(TITLE, DESCRIPTION,STATU,LOGDATE) " +
                         "VALUES ('" + title + "','" + description + "','" + statu + "',CONVERT(DATETIME,'" + DateTime.Now.ToString() + "',104))";

            Result result = dbCaller.ExecuteSql(sql);
            if (result.isErrorOccurred)
                throw new Exception(result.errorDescription);
        }
    }
}
