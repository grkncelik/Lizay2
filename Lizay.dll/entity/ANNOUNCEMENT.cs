using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lizay.dll.entity
{
    public class ANNOUNCEMENT
    {
        public int ANNOUNCE_ID = 0;
        public string TITLE = "";
        public string DESCRIPTION = "";
        public string IMG = "";
        public string DOCFILE = "";
        public string TYPE = "";
        public bool ISACTIVE = false;
        public DateTime PUB_DATE = new DateTime();
    }
}
