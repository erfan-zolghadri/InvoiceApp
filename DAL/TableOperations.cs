using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace InvoiceApp.DAL
{
    public class TableOperations
    {
        private string _connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

        public DataTable GetDataTable(string tbName, string spName)
        {
            var connection = new SqlConnection(_connectionString);

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            var dataTable = new DataTable(tbName);

            var command = new SqlCommand
            {
                Connection = connection,
                CommandText = spName,
                CommandType = CommandType.StoredProcedure
            };

            var adapter = new SqlDataAdapter(command);
            adapter.Fill(dataTable);
            connection.Close();

            return dataTable;
        }

        public long GetMaxId(string fnName)
        {
            var connection = new SqlConnection(_connectionString);

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            var command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = string.Format("SELECT [dbo].[{0}]()", fnName);
            command.CommandType = CommandType.Text;
            long maxId = Convert.ToInt64(command.ExecuteScalar().ToString());
            connection.Close();

            return maxId;
        }
    }
}
