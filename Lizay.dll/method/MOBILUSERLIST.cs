using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lizay.dll.method
{
    public class MOBILUSERLIST
    {

        public static void AddUserData(Lizay.dll.entity.MOBILUSERLIST data)
        {

            Result result = dbCaller.ExecuteSql(
                @"INSERT INTO [dbo].[USERS] 
                                  ([USER_ID]
                                  ,[USERNAME]
                                  ,[FULLNAME]
                                  ,[PASSWORD]
                                  ,[PROFILE_PHOTO]
                                  ,[ISACTIVE]
                                  ,[CREATED_DATE]
                                  ,[MODIFIED_DATE]
                                  ,[MODIFIED_USER]
                                  ,[DELETED]
                                  ,[COMPANY_NO]
                                  ,[GSMNO]
                                  ,[EMAIL]
                                  ,[BIRTHDAY]
                                  ,[PAY]
                                  ,[USER_TYPE]) " +

                  "VALUES ('" + data.PERSID + "','" + GetClearText(data.NAME.Substring(0, 1)) + GetClearText(data.SURNAME) + "','" + data.DISPLAY + "','123456','assets/images/placeholder.jpg','TRUE',CONVERT(DATE,'" + DateTime.Now.ToShortDateString() + "',103),CONVERT(DATE,'" + DateTime.Now.ToShortDateString() + "',103),'ADMIN','FALSE','" + data.DEPARTMENT + "','','','" + data.BIRTHDAY + "','" + data.PAY + "','PERSONEL')");

            if (result.isErrorOccurred)
                throw new Exception(result.errorDescription);
        }


        public static string GetClearText(string t)
        {
            string clearText = t.Replace("Ö", "O").Replace("Ü", "U").Replace("İ", "I").Replace("Ş", "S").Replace("Ç", "C").Replace("Ğ","G");

            return clearText;
        }

        public static void AddCompanyData(Lizay.dll.entity.MOBILUSERLIST data)
        {

            Result result = dbCaller.ExecuteSql(
                @"INSERT INTO [dbo].[COMPANY] 
                                          ([COMPANY_NO]
                                          ,[COMPANY_NAME]
                                          ,[REGION]) " +

                  "VALUES ('" + data.DEPARTMENT + "','" + data.DEPARTMENTT + "','')");

            if (result.isErrorOccurred)
                throw new Exception(result.errorDescription);
        }
    }
}
