using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lizay.dll.entity
{
   public class USERS
    {
       public int ID = 0;
        public string USERNAME = "";
        public string PASSWORD = "";
        public string FULLNAME = "";
        public string PROFILE_PHOTO = "";
        public string COMPANY_NO = "";
        public string USER_ID = "";
        public string USER_TYPE = "";
        public string EMAIL = "";
        public string GSMNO = "";
        public string BIRTHDAY = "";
        public bool DELETED = false;
        public bool ISACTIVE = false;
        public DateTime CREATED_DATE = new DateTime();
        public DateTime MODIFIED_DATE = new DateTime();
        public string MODIFIED_USER = "";
        public string DEVICE_ID = "";
        public string DEVICE_TYPE = "";

    }
}
