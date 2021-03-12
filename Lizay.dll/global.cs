using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Xml.Serialization;


namespace Lizay.dll
{
    public static class global
    {

        public static string Path_for_Pictures = "http://crm.lizay.com.tr/UploadedFiles/";


    }
    public struct Result
    {
        public Boolean isErrorOccurred;
        public String errorDescription;
        public DataTable resultAsDataTable;
        public String resultAsString;
        public Double resultAsDouble;
        public Int32 resultAsInt32;
        public List<CommandParameter> resultAsReturnParameters;
    }

    public class CommandParameter
    {
        public CommandParameter()
        { }
        public string ParameterName;
        public ParameterDirection Direction = ParameterDirection.Input;
        public DbType DataType = DbType.String;
        public object Value;
    }

}
