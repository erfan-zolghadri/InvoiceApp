using InvoiceApp.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceApp.BLL
{
    public class InvoiceMasterHandler
    {
        private readonly InvoiceMasterDataAccess _invoiceMasterDataAccess = new InvoiceMasterDataAccess();
        private readonly TableOperations _tableOperations = new TableOperations();

        public DataTable GetInvoiceMaster()
        {
            return _tableOperations.GetDataTable("tbInvoiceMaster", "spInvoiceMasterSelect");
        }

        public DataTable GetInvoiceType()
        {
            return _tableOperations.GetDataTable("tbInvoiceType", "spInvoiceTypeSelect");
        }

        public DataTable GetCompany()
        {
            return _tableOperations.GetDataTable("tbCompany", "spCompanySelect");
        }
        
        public DataTable GetPerson()
        {
            return _tableOperations.GetDataTable("tbPerson", "spPersonSelect");
        }

        public long GetMaxInvoiceMasterId()
        {
            return _tableOperations.GetMaxId("fnMaxInvoiceMasterId");
        }

        public int GetInvoiceDetailCount(InvoiceMaster invoiceMaster)
        {
            return _invoiceMasterDataAccess.GetInvoiceDetailCount(invoiceMaster);
        }

        public void InsertInvoiceMaster(InvoiceMaster invoiceMaster)
        {
            _invoiceMasterDataAccess.InsertUpdateInvoiceMaster("spInvoiceMasterInsert", invoiceMaster);
        }

        public void UpdateInvoiceMaster(InvoiceMaster invoiceMaster)
        {
            _invoiceMasterDataAccess.InsertUpdateInvoiceMaster("spInvoiceMasterUpdate", invoiceMaster);
        }

        public void DeleteInvoiceMaster(InvoiceMaster invoiceMaster)
        {
            _invoiceMasterDataAccess.DeleteInvoiceMaster(invoiceMaster);
        }
    }
}
