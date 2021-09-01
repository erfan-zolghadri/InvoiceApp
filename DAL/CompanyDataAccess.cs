using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace InvoiceApp.DAL
{
    public class CompanyDataAccess
    {
        private string _connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

        public void InsertCompany(Company company)
        {
            var connection = new SqlConnection(_connectionString);
            connection.Open();

            var command = new SqlCommand()
            {
                Connection = connection,
                CommandText = "spCompanyInsert",
                CommandType = CommandType.StoredProcedure
            };

            command.Parameters.Add("@companyId", SqlDbType.NVarChar, 20).Value = company.Id;
            command.Parameters.Add("@CompanyName", SqlDbType.NVarChar, 20).Value = company.Name;
            command.Parameters.Add("@CompanyTypeId", SqlDbType.BigInt).Value = company.TypeId;
            command.Parameters.Add("@CompanyTel", SqlDbType.Char, 11).Value = company.Tel;
            command.Parameters.Add("@CompanyFax", SqlDbType.NVarChar, 200).Value = company.Fax;
            command.Parameters.Add("@CompanyAddress", SqlDbType.VarChar, 15).Value = company.Address;
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void UpdateCompany(Company company)
        {
            var connection = new SqlConnection(_connectionString);

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            var command = new SqlCommand
            {
                Connection = connection,
                CommandText = "spCompanyUpdate",
                CommandType = CommandType.StoredProcedure
            };

            command.Parameters.Add("@CompanyId", SqlDbType.NVarChar, 20).Value = company.Id;
            command.Parameters.Add("@CompanyName", SqlDbType.NVarChar, 20).Value = company.Name;
            command.Parameters.Add("@CompanyTypeId", SqlDbType.BigInt).Value = company.TypeId;
            command.Parameters.Add("@CompanyTel", SqlDbType.Char, 11).Value = company.Tel;
            command.Parameters.Add("@CompanyFax", SqlDbType.NVarChar, 200).Value = company.Fax;
            command.Parameters.Add("@CompanyAddress", SqlDbType.VarChar, 15).Value = company.Address;
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void DeleteCompany(Company company)
        {
            var connection = new SqlConnection(_connectionString);

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            var command = new SqlCommand
            {
                Connection = connection,
                CommandText = "spCompanyDelete",
                CommandType = CommandType.StoredProcedure
            };

            command.Parameters.Add("@CompanyId", SqlDbType.BigInt).Value = company.Id;
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
