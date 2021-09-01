using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceApp.DAL
{
    public class InvoiceDetail
    {
        public long Id { get; set; }
        public long MasterId { get; set; }
        public string ProductCode { get; set; }
        public string ProductBriefDescription { get; set; }
        public float ProductQuantity { get; set; }
        public long UnitId { get; set; }
        public long ProductPrice { get; set; }
        public long ProductTotalPrice { get; set; }
        public string ProductSpecification { get; set; }
        public string ProductDescription { get; set; }
    }
}
