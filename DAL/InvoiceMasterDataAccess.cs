using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace InvoiceApp.DAL
{
    public class InvoiceMasterDataAccess
    {
        private string _connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

        public int GetInvoiceDetailCount(InvoiceMaster invoiceMaster)
        {
            var connection = new SqlConnection(_connectionString);

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            var command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT [dbo].[fnInvoiceDetailCount](@InvoiceMasterId)";
            command.Parameters.Add("@InvoiceMasterId", SqlDbType.BigInt).Value = invoiceMaster.Id;
            command.CommandType = CommandType.Text;
            int recordsCount = Convert.ToInt32(command.ExecuteScalar().ToString());
            connection.Close();

            return recordsCount;
        }

        public void InsertUpdateInvoiceMaster(string spName, InvoiceMaster invoiceMaster)
        {
            var connection = new SqlConnection(_connectionString);

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            var command = new SqlCommand
            {
                Connection = connection,
                CommandText = spName,
                CommandType = CommandType.StoredProcedure
            };

            command.Parameters.Add("@InvoiceMasterId", SqlDbType.BigInt).Value = invoiceMaster.Id;
            command.Parameters.Add("@InvoiceNumber", SqlDbType.Char, 10).Value = invoiceMaster.Number;
            command.Parameters.Add("@InvoiceTypeId", SqlDbType.BigInt).Value = invoiceMaster.TypeId;
            command.Parameters.Add("@InvoiceDate", SqlDbType.Char, 10).Value = invoiceMaster.Date;
            command.Parameters.Add("@CompanyId", SqlDbType.BigInt).Value = invoiceMaster.CompanyId;
            command.Parameters.Add("@PersonId", SqlDbType.BigInt).Value = invoiceMaster.PersonId;
            command.Parameters.Add("@InvoiceRegisterDate", SqlDbType.Char, 10).Value = invoiceMaster.RegisterDate;
            command.Parameters.Add("@InvoiceRegisterTime", SqlDbType.Char, 5).Value = invoiceMaster.RegisterTime;
            command.Parameters.Add("@InvoiceDescription", SqlDbType.NVarChar, 100).Value = invoiceMaster.Description;
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void DeleteInvoiceMaster(InvoiceMaster invoiceMaster)
        {
            var connection = new SqlConnection(_connectionString);

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            var command = new SqlCommand
            {
                Connection = connection,
                CommandText = "spInvoiceMasterDelete",
                CommandType = CommandType.StoredProcedure
            };

            command.Parameters.Add("@InvoiceMasterId", SqlDbType.BigInt).Value = invoiceMaster.Id;
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
