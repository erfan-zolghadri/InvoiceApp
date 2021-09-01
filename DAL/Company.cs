namespace InvoiceApp.DAL
{
    public class Company
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long TypeId { get; set; }
        public string Tel { get; set; }
        public string Fax { get; set; }
        public string Address { get; set; }
    }
}
