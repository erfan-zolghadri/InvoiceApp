using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace InvoiceApp.DAL
{
    public class InvoiceDetailDataAccess
    {
        private string _connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

        public DataTable GetInvoiceDetail(InvoiceDetail invoiceDetail)
        {
            var connection = new SqlConnection(_connectionString);

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            var dataTable = new DataTable("tbInvoiceDetail");

            var command = new SqlCommand
            {
                Connection = connection,
                CommandText = "spInvoiceDetailSelect",
                CommandType = CommandType.StoredProcedure
            };

            command.Parameters.Add("@InvoiceMasterId", SqlDbType.BigInt).Value = invoiceDetail.MasterId;
            var adapter = new SqlDataAdapter(command);
            adapter.Fill(dataTable);
            connection.Close();

            return dataTable;
        }

        public void InsertInvoiceDetail(InvoiceDetail invoiceDetail)
        {
            var connection = new SqlConnection(_connectionString);

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            var command = new SqlCommand
            {
                Connection = connection,
                CommandText = "spInvoiceDetailInsert",
                CommandType = CommandType.StoredProcedure
            };

            command.Parameters.Add("@InvoiceMasterId", SqlDbType.BigInt).Value = invoiceDetail.MasterId;
            command.Parameters.Add("@InvoiceDetailId", SqlDbType.BigInt).Value = invoiceDetail.Id;
            command.Parameters.Add("@ProductCode", SqlDbType.Char, 10).Value = invoiceDetail.ProductCode;
            command.Parameters.Add("@ProductBriefDescription", SqlDbType.NVarChar, 50).Value = invoiceDetail.ProductBriefDescription;
            command.Parameters.Add("@ProductQuantity", SqlDbType.Float).Value = invoiceDetail.ProductQuantity;
            command.Parameters.Add("@UnitId", SqlDbType.BigInt).Value = invoiceDetail.UnitId;
            command.Parameters.Add("@ProductPrice", SqlDbType.BigInt).Value = invoiceDetail.ProductPrice;
            command.Parameters.Add("@ProductTotalPrice", SqlDbType.BigInt).Value = invoiceDetail.ProductTotalPrice;
            command.Parameters.Add("@ProductSpecifications", SqlDbType.NVarChar, 100).Value = invoiceDetail.ProductSpecification;
            command.Parameters.Add("@ProductDescription", SqlDbType.NVarChar, 100).Value = invoiceDetail.ProductDescription;
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void UpdateInvoiceDetail(InvoiceDetail invoiceDetail)
        {
            var connection = new SqlConnection(_connectionString);

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            var command = new SqlCommand
            {
                Connection = connection,
                CommandText = "spInvoiceDetailUpdate",
                CommandType = CommandType.StoredProcedure
            };

            command.Parameters.Add("@InvoiceDetailId", SqlDbType.Char, 10).Value = invoiceDetail.Id;
            command.Parameters.Add("@ProductCode", SqlDbType.Char, 10).Value = invoiceDetail.ProductCode;
            command.Parameters.Add("@ProductBriefDescription", SqlDbType.NVarChar, 50).Value = invoiceDetail.ProductBriefDescription;
            command.Parameters.Add("@ProductQuantity", SqlDbType.Float).Value = invoiceDetail.ProductQuantity;
            command.Parameters.Add("@UnitId", SqlDbType.BigInt).Value = invoiceDetail.UnitId;
            command.Parameters.Add("@ProductPrice", SqlDbType.BigInt).Value = invoiceDetail.ProductPrice;
            command.Parameters.Add("@ProductTotalPrice", SqlDbType.BigInt).Value = invoiceDetail.ProductTotalPrice;
            command.Parameters.Add("@ProductSpecifications", SqlDbType.NVarChar, 100).Value = invoiceDetail.ProductSpecification;
            command.Parameters.Add("@ProductDescription", SqlDbType.NVarChar, 100).Value = invoiceDetail.ProductDescription;
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void DeleteInvoiceDetail(InvoiceDetail invoiceDetail)
        {
            var connection = new SqlConnection(_connectionString);

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            var command = new SqlCommand
            {
                Connection = connection,
                CommandText = "spInvoiceDetailDelete",
                CommandType = CommandType.StoredProcedure
            };

            command.Parameters.Add("@InvoiceDetailId", SqlDbType.BigInt).Value = invoiceDetail.Id;
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
