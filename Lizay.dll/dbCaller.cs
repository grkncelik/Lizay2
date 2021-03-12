using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Lizay.dll
{
    internal static class dbCaller
    {


        public static string ConnectionString
        {
            get
            {
                return global::Lizay.dll.Properties.Settings.Default.ConnectionString;
            }
        }




        public static Result GetTable(String SqlStatement, string ConStr = "")
        {
            if (ConStr == "")
                ConStr = ConnectionString;

            var result = new Result() { isErrorOccurred = false, resultAsDataTable = new DataTable() };
            using (SqlConnection connection = new SqlConnection(ConStr))
            {
                try
                {
                    connection.Open();
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(SqlStatement, connection))
                    {
                        dataAdapter.Fill(result.resultAsDataTable);
                    }
                }
                catch (Exception ex)
                {
                    result.isErrorOccurred = true;
                    result.errorDescription = ex.Message;
                }

                connection.Close();
            }

            return result;
        }

        public static Result ExecuteSql(String SqlStatement)
        {
            var result = new Result() { isErrorOccurred = false };
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(SqlStatement, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    result.isErrorOccurred = true;
                    result.errorDescription = ex.Message;
                }

                connection.Close();
            }

            return result;
        }

        public static Result ExecuteProcedure(string ProcedureName, List<CommandParameter> Parameters = null, string ConStr = "")
        {
            if (ConStr == "")
                ConStr = ConnectionString;


            var result = new Result() { isErrorOccurred = false, resultAsReturnParameters = new List<CommandParameter>() };
            using (SqlConnection connection = new SqlConnection(ConStr))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(ProcedureName, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (Parameters != null)
                        {
                            foreach (CommandParameter parameter in Parameters)
                            {
                                command.Parameters.Add(new SqlParameter() { ParameterName = parameter.ParameterName, DbType = parameter.DataType, Direction = parameter.Direction, Value = parameter.Value });
                            }
                        }
                        command.ExecuteNonQuery();

                        foreach (SqlParameter item in command.Parameters)
                        {
                            result.resultAsReturnParameters.Add(new CommandParameter()
                            {
                                ParameterName = item.ParameterName,
                                DataType = item.DbType,
                                Direction = item.Direction,
                                Value = Convert.IsDBNull(item.Value) ? null : item.Value
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    result.isErrorOccurred = true;
                    result.errorDescription = ex.Message;
                }

                connection.Close();
            }

            return result;
        }

        public static Result ExecuteTable(string ProcedureName, List<CommandParameter> Parameters = null, string ConStr = "")
        {
            if (ConStr == "")
                ConStr = ConnectionString;

            var result = new Result() { isErrorOccurred = false, resultAsReturnParameters = new List<CommandParameter>() };
            using (SqlConnection connection = new SqlConnection(ConStr))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(ProcedureName, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (Parameters != null)
                        {
                            foreach (CommandParameter parameter in Parameters)
                            {
                                command.Parameters.Add(new SqlParameter() { ParameterName = parameter.ParameterName, DbType = parameter.DataType, Direction = parameter.Direction, Value = parameter.Value });
                            }
                        }

                        SqlDataAdapter da = new SqlDataAdapter();
                        da.SelectCommand = command;

                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        result.resultAsDataTable = dt;
                    }
                }
                catch (Exception ex)
                {
                    result.isErrorOccurred = true;
                    result.errorDescription = ex.Message;
                }

                connection.Close();
            }

            return result;
        }


        public static void ExecuteQuery(DataTable dt, string tableName, string ConStr = "")
        {
            if (ConStr == "")
                ConStr = ConnectionString;

            var sqlConn = new SqlConnection(ConStr);

            try
            {
                var bulkCopy =
                    new SqlBulkCopy
                        (
                            sqlConn,
                            SqlBulkCopyOptions.TableLock |
                            SqlBulkCopyOptions.FireTriggers |
                            SqlBulkCopyOptions.UseInternalTransaction,
                            null
                        )
                    { BulkCopyTimeout = 0, DestinationTableName = tableName };

                bulkCopy.WriteToServer(dt);
                sqlConn.Close();

            }
            catch (Exception ex)
            {
                if (sqlConn != null && sqlConn.State == ConnectionState.Open)
                {
                    sqlConn.Close();
                }

                throw new Exception(ex.Message);
            }
        }

    }


}
