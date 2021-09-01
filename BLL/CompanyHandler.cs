using InvoiceApp.DAL;
using System.Data;

namespace InvoiceApp.BLL
{
    public class CompanyHandler
    {
        private readonly CompanyDataAccess _companyDataAccess = new CompanyDataAccess();
        private readonly TableOperations _tableOperations = new TableOperations();

        public DataTable GetCompanyType()
        {
            return _tableOperations.GetDataTable("tbCompanyType", "spCompanyTypeSelect");
        }

        public DataTable GetCompany()
        {
            return _tableOperations.GetDataTable("tbCompany", "spCompanySelect");
        }

        public long GetMaxCompanyId()
        {
            return _tableOperations.GetMaxId("fnMaxCompanyId");
        }

        public void InsertCompany(Company company)
        {
            _companyDataAccess.InsertCompany(company);
        }

        public void UpdateCompany(Company company)
        {
            _companyDataAccess.UpdateCompany(company);
        }

        public void DeleteCompany(Company company)
        {
            _companyDataAccess.DeleteCompany(company);
        }
    }
}
