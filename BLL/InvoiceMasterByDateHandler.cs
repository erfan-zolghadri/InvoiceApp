using InvoiceApp.DAL;
using System.Data;

namespace InvoiceApp.BLL
{
    public class InvoiceMasterByDateHandler
    {
        private readonly InvoiceMasterByDateDataAccess _invoiceMasterByDateDataAccess = new InvoiceMasterByDateDataAccess();

        public DataTable GetInvoiceMasterByDate(InvoiceMasterByDate invoiceMasterByDate)
        {
            return _invoiceMasterByDateDataAccess.GetInvoiceMasterByDate(invoiceMasterByDate);
        }
    }
}
