using InvoiceApp.DAL;
using System.Data;

namespace InvoiceApp.BLL
{
    public class InvoiceDetailHandler
    {
        private readonly InvoiceDetailDataAccess _invoiceDetailDataAccess = new InvoiceDetailDataAccess();
        private readonly TableOperations _tableOperations = new TableOperations();

        public long GetMaxInvoiceDetailId()
        {
            return _tableOperations.GetMaxId("fnMaxInvoiceDetailId");
        }

        public DataTable GetUnit()
        {
            return _tableOperations.GetDataTable("tbUnit", "spUnitSelect");
        }

        public DataTable GetInvoiceDetail(InvoiceDetail invoiceDetail)
        {
            return _invoiceDetailDataAccess.GetInvoiceDetail(invoiceDetail);
        }

        public void InsertInvoiceDetail(InvoiceDetail invoiceDetail)
        {
            _invoiceDetailDataAccess.InsertInvoiceDetail(invoiceDetail);
        }

        public void UpdateInvoiceDetail(InvoiceDetail invoiceDetail)
        {
            _invoiceDetailDataAccess.UpdateInvoiceDetail(invoiceDetail);
        }

        public void DeleteInvoiceDetail(InvoiceDetail invoiceDetail)
        {
            _invoiceDetailDataAccess.DeleteInvoiceDetail(invoiceDetail);
        }
    }
}
