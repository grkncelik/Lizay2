using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lizay.dll.method
{
    public class COMPANYTARGETRATE
    {
        public static void AddCompanyTargetData(Lizay.dll.entity.COMPANYTARGETRATE data)
        {

            Result result = dbCaller.ExecuteSql(
                @"INSERT INTO [dbo].[COMPANYTARGETRATE] 
                                          ([CLIENT]
                                          ,[COMPANY]
                                            ,[FINYEAR]
                                            ,[FINPERIOD]
                                            ,[TOTALORAN]
                                            ,[CURRENCY]
                                            ,[BUSAREA]
                                            ,[STEXT]
                                            ,[PLAIN]
                                          ,[MAGAZAORAN]) " +

                  "VALUES ('" + data.CLIENT + "','" + data.COMPANY + "','" + data.FINYEAR + "','" + data.FINPERIOD + "','" + data.TOTALORAN + "','" + data.CURRENCY + "','" + data.BUSAREA + "','" + data.STEXT + "','" + data.PLAIN + "','" + data.MAGAZAORAN + "')");

            if (result.isErrorOccurred)
                throw new Exception(result.errorDescription);
        }

        public static void DeleteCompanyTargetData()
        {

            string sql = "DELETE FROM [dbo].[COMPANYTARGETRATE]";
            Result result = dbCaller.ExecuteSql(sql);
            if (result.isErrorOccurred)
                throw new Exception(result.errorDescription);

        }
    }
}
