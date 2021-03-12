using System;
using System.Collections.Generic;

namespace Lizay.dll.method
{
    public class USERS
    {
        public static List<entity.USERS> Get_UserListIn(string userid, string name, string userType, string region, string statu, string devicetype = "", string companyno = "")
        {
            var userList = new List<entity.USERS>();

            var result = dbCaller.GetTable(
                "SELECT * FROM [dbo].[USERS] " +
                 "WHERE 1=1 AND [USER_TYPE] IN ('PERSONEL','MUDUR','MAGAZA_MUDURU','FRANCHISE') " +
                 //(username != "" ? " AND USERNAME LIKE '" + username + "%' " : "") +
                 (name != "" ? " AND FULLNAME LIKE '" + name + "%' " : "") +
                 (userType != "" ? " AND USER_TYPE LIKE '" + userType + "%' " : "") +
                  (statu != "" ? " AND ISACTIVE LIKE '" + statu + "%' " : "") +
                  (devicetype != "" ? " AND DEVICE_TYPE='" + devicetype + "' " : "") +
                   (companyno != "" ? " AND COMPANY_NO IN(" + companyno + ") " : "") +
                   (userid != "" ? " AND USER_ID IN(" + userid + ") " : "") +
                 "ORDER BY  USERNAME ");
            if (result.isErrorOccurred) return userList;
            var dt = result.resultAsDataTable;
            if (dt == null) return userList;
            for (var i = 0; i < dt.Rows.Count; i++)
            {
                var row = dt.Rows[i];

                userList.Add(new entity.USERS
                {
                    ID = Convert.ToInt32(row["ID"].ToString()),
                    USERNAME = row["USERNAME"].ToString(),
                    FULLNAME = row["FULLNAME"].ToString(),
                    PASSWORD = row["PASSWORD"].ToString(),
                    COMPANY_NO = row["COMPANY_NO"].ToString(),
                    GSMNO = row["GSMNO"].ToString(),
                    EMAIL = row["EMAIL"].ToString(),
                    BIRTHDAY = row["BIRTHDAY"].ToString(),
                    USER_TYPE = row["USER_TYPE"].ToString(),
                    DEVICE_ID = row["DEVICE_ID"].ToString(),
                    DEVICE_TYPE = row["DEVICE_TYPE"].ToString(),
                    PROFILE_PHOTO = dt.Rows[0]["PROFILE_PHOTO"].ToString(),
                    ISACTIVE = Convert.ToBoolean(row["ISACTIVE"].ToString() != "" ? row["ISACTIVE"].ToString() : "false"),
                });
            }

            return userList;
        }




        public static List<entity.USERS> Get_UserList(string username, string name, string userType, string region, string statu, string devicetype = "", string companyno = "")
        {
            var userList = new List<entity.USERS>();

            var result = dbCaller.GetTable(
                "SELECT * FROM [dbo].[USERS] " +
                 "WHERE 1=1 AND DELETED=0 AND [USER_TYPE] IN ('PERSONEL','MUDUR','MAGAZA_MUDURU','FRANCHISE') " +
                 (username != "" ? " AND USERNAME LIKE '" + username + "%' " : "") +
                 (name != "" ? " AND FULLNAME LIKE '" + name + "%' " : "") +
                 (userType != "" ? " AND USER_TYPE LIKE '" + userType + "%' " : "") +
                  (statu != "" ? " AND ISACTIVE LIKE '" + statu + "%' " : "") +
                  (devicetype != "" ? " AND DEVICE_TYPE='" + devicetype + "' " : "") +
                   (companyno != "" ? " AND COMPANY_NO='" + companyno + "' " : "") +
                 "ORDER BY  USERNAME ");
            if (result.isErrorOccurred) return userList;
            var dt = result.resultAsDataTable;
            if (dt == null) return userList;
            for (var i = 0; i < dt.Rows.Count; i++)
            {
                var row = dt.Rows[i];

                userList.Add(new entity.USERS
                {
                    ID = Convert.ToInt32(row["ID"].ToString()),
                    USERNAME = row["USERNAME"].ToString(),
                    FULLNAME = row["FULLNAME"].ToString(),
                    PASSWORD = row["PASSWORD"].ToString(),
                    COMPANY_NO = row["COMPANY_NO"].ToString(),
                    GSMNO = row["GSMNO"].ToString(),
                    EMAIL = row["EMAIL"].ToString(),
                    BIRTHDAY = row["BIRTHDAY"].ToString(),
                    USER_TYPE = row["USER_TYPE"].ToString(),
                    DEVICE_ID = row["DEVICE_ID"].ToString(),
                    DEVICE_TYPE = row["DEVICE_TYPE"].ToString(),
                    PROFILE_PHOTO = dt.Rows[0]["PROFILE_PHOTO"].ToString(),
                    ISACTIVE = Convert.ToBoolean(row["ISACTIVE"].ToString() != "" ? row["ISACTIVE"].ToString() : "false"),
                });
            }

            return userList;
        }


        public static entity.USERS Get_User(string username, string password)
        {
            var user = new entity.USERS();
            
            var result = dbCaller.GetTable("SELECT * FROM [dbo].[USERS] WHERE USERNAME='" + username + "'");
            if (!result.isErrorOccurred)
            {
                var dt = result.resultAsDataTable;

                if (dt.Rows.Count > 0 && dt.Rows[0]["PASSWORD"].ToString() == password)
                {
                    user = new entity.USERS
                    {
                        USERNAME = dt.Rows[0]["USERNAME"].ToString(),
                        PASSWORD = dt.Rows[0]["PASSWORD"].ToString(),
                        FULLNAME = dt.Rows[0]["FULLNAME"].ToString(),
                        COMPANY_NO = dt.Rows[0]["COMPANY_NO"].ToString(),
                        USER_ID = dt.Rows[0]["USER_ID"].ToString(),
                        EMAIL = dt.Rows[0]["EMAIL"].ToString(),
                        GSMNO = dt.Rows[0]["GSMNO"].ToString(),
                        BIRTHDAY = dt.Rows[0]["BIRTHDAY"].ToString(),
                        PROFILE_PHOTO = dt.Rows[0]["PROFILE_PHOTO"].ToString(),
                        USER_TYPE = dt.Rows[0]["USER_TYPE"].ToString().Trim(),
                        ISACTIVE = Convert.ToBoolean(dt.Rows[0]["ISACTIVE"].ToString() != "" ? dt.Rows[0]["ISACTIVE"].ToString() : "false"),

                    };
                }
            }
            else
            {
                throw new Exception(result.errorDescription);
            }

            return user;
        }

        public static entity.USERS Get_UserByDetail(string username)
        {
            var user = new entity.USERS();
            
            var result = dbCaller.GetTable("SELECT * FROM [dbo].[USERS] WHERE USERNAME='" + username + "'");
            if (!result.isErrorOccurred)
            {
                var dt = result.resultAsDataTable;

                if (dt.Rows.Count > 0)
                {
                    user = new entity.USERS
                    {
                        USERNAME = dt.Rows[0]["USERNAME"].ToString(),
                        PASSWORD = dt.Rows[0]["PASSWORD"].ToString(),
                        FULLNAME = dt.Rows[0]["FULLNAME"].ToString(),
                        COMPANY_NO = dt.Rows[0]["COMPANY_NO"].ToString(),
                        EMAIL = dt.Rows[0]["EMAIL"].ToString(),
                        GSMNO = dt.Rows[0]["GSMNO"].ToString(),
                        BIRTHDAY = dt.Rows[0]["BIRTHDAY"].ToString(),
                        PROFILE_PHOTO = dt.Rows[0]["PROFILE_PHOTO"].ToString(),
                        USER_TYPE = dt.Rows[0]["USER_TYPE"].ToString().Trim(),
                        DEVICE_ID = dt.Rows[0]["DEVICE_ID"].ToString().Trim(),
                        DEVICE_TYPE = dt.Rows[0]["DEVICE_TYPE"].ToString().Trim(),
                        ISACTIVE = Convert.ToBoolean(dt.Rows[0]["ISACTIVE"].ToString() != "" ? dt.Rows[0]["ISACTIVE"].ToString() : "false"),
                    };
                }
            }
            else
            {
                throw new Exception(result.errorDescription);
            }

            return user;
        }


        public static bool Get_UserByUsername(string username)
        {
            var user = new entity.USERS();

            var usernamestatu = false;

            var result = dbCaller.GetTable("SELECT * FROM [dbo].[USERS] WHERE USERNAME='" + username + "'");
            if (!result.isErrorOccurred)
            {
                var dt = result.resultAsDataTable;

                usernamestatu = dt.Rows.Count > 0;
            }
            else
            {
                throw new Exception(result.errorDescription);
            }

            return usernamestatu;
        }

        public static void Change_Password(string username, string newPassword)
        {
            var result = dbCaller.ExecuteSql("UPDATE [dbo].[USERS] SET PASSWORD='" + newPassword + "' WHERE USERNAME='" + username + "'");
            if (result.isErrorOccurred)
                throw new Exception(result.errorDescription);
        }

        public static void Change_DeviceId(string username, string deviceId)
        {
            var result = dbCaller.ExecuteSql("UPDATE [dbo].[USERS] SET DEVICE_ID='" + deviceId + "' WHERE USERNAME='" + username + "'");
            if (result.isErrorOccurred)
                throw new Exception(result.errorDescription);
        }

        public static void Change_DeviceType(string username, string deviceType)
        {
            var result = dbCaller.ExecuteSql("UPDATE [dbo].[USERS] SET DEVICE_TYPE='" + deviceType + "' WHERE USERNAME='" + username + "'");
            if (result.isErrorOccurred)
                throw new Exception(result.errorDescription);
        }

        public static void Change_ProfilePhoto(string username, string photo)
        {
            var result = dbCaller.ExecuteSql("UPDATE [dbo].[USERS] SET PROFILE_PHOTO='" + photo + "' WHERE USERNAME='" + username + "'");
            if (result.isErrorOccurred)
                throw new Exception(result.errorDescription);
        }


        public static void Set_IsActive(string username, bool isActive)
        {
            var result = dbCaller.ExecuteSql("UPDATE [dbo].[USERS] SET ISACTIVE='" + isActive + "' WHERE USERNAME='" + username + "'");
            if (result.isErrorOccurred)
                throw new Exception(result.errorDescription);
        }

        public static void AddNewUser(entity.USERS user)
        {
            var result = dbCaller.ExecuteSql(
                "INSERT INTO [dbo].[USERS] " +
                           "(USERNAME, PASSWORD, FULLNAME,PROFILE_PHOTO,COMPANY_NO,GSMNO,EMAIL,BIRTHDAY,USER_TYPE, ISACTIVE, CREATED_DATE,MODIFIED_DATE,MODIFIED_USER,DELETED) " +
                    "VALUES ('" + user.USERNAME + "','" + user.PASSWORD + "','" + user.FULLNAME + "','" + user.PROFILE_PHOTO + "','" + user.COMPANY_NO + "','" + user.GSMNO + "','" + user.EMAIL + "','" + user.BIRTHDAY + "','" + user.USER_TYPE + "','" + user.ISACTIVE.ToString() + "',CONVERT(DATE,'" + user.CREATED_DATE + "',103),CONVERT(DATE,'" + user.MODIFIED_DATE + "',103),'" + user.MODIFIED_USER + "','" + user.DELETED + "')");

            if (result.isErrorOccurred)
                throw new Exception(result.errorDescription);
        }

        public static void UpdateUser(entity.USERS user)
        {
            var result = dbCaller.ExecuteSql(
                "UPDATE [dbo].[USERS] " +
                "   SET " +
                "IS_ACTIVE='" + user.ISACTIVE + "'" +
                (user.FULLNAME != "" ? ",FULLNAME='" + user.FULLNAME + "'" : "") +
                (user.EMAIL != "" ? ",EMAIL='" + user.EMAIL + "'" : "") +
                (user.BIRTHDAY != "" ? ",BIRTHDAY='" + user.BIRTHDAY + "'" : "") +
                (user.GSMNO != "" ? ",GSMNO='" + user.GSMNO + "'" : "") +
                (user.PROFILE_PHOTO != "" ? ",PROFILE_PHOTO='" + user.PROFILE_PHOTO + "'" : "") +
                (user.USER_TYPE != "" ? ",USER_TYPE='" + user.USER_TYPE + "'" : "") +
                (user.DEVICE_TYPE != "" ? ",DEVICE_TYPE='" + user.DEVICE_TYPE + "'" : "") +
                (user.DEVICE_ID != "" ? ",DEVICE_ID='" + user.DEVICE_ID + "'" : "") +
                " WHERE USERNAME='" + user.USERNAME + "'");

            if (result.isErrorOccurred)
                throw new Exception(result.errorDescription);
        }

        public static void DeleteUser(int id)
        {
            var result = dbCaller.ExecuteSql("UPDATE [dbo].[USERS] SET DELETED='TRUE' WHERE ID=" + id + "");
            if (result.isErrorOccurred)
                throw new Exception(result.errorDescription);
        }
    }
}
