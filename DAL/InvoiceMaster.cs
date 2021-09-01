namespace InvoiceApp.DAL
{
    public class InvoiceMaster
    {
        public long Id { get; set; }
        public string Number { get; set; }
        public long TypeId { get; set; }
        public string Date { get; set; }
        public long CompanyId { get; set; }
        public long PersonId { get; set; }
        public string RegisterDate { get; set; }
        public string RegisterTime { get; set; }
        public string Description { get; set; }
    }
}
