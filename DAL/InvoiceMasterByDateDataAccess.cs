using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace InvoiceApp.DAL
{
    public class InvoiceMasterByDateDataAccess
    {
        private string _connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

        public DataTable GetInvoiceMasterByDate(InvoiceMasterByDate reportInvoiceByDate)
        {
            var connection = new SqlConnection(_connectionString);

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            var command = new SqlCommand
            {
                Connection = connection,
                CommandText = "SELECT * FROM dbo.fnInvoiceMasterByDateSelect(@FromDate, @ToDate)",
                CommandType = CommandType.Text
            };

            command.Parameters.Add("@FromDate", SqlDbType.Char, 10).Value = reportInvoiceByDate.FromDate;
            command.Parameters.Add("@ToDate", SqlDbType.Char, 10).Value = reportInvoiceByDate.ToDate;
            var dataTable = new DataTable("tbInvoiceMaster");
            var adapter = new SqlDataAdapter(command);
            adapter.Fill(dataTable);
            connection.Close();

            return dataTable;
        }
    }
}
