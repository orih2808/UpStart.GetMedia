using System.Collections.Generic;

namespace GetMedia.Models
{
    public class SaleInvoice
    {
        public int Id { get; set; }
        public virtual ICollection<SalesInvoiceItem> SaleItems { get; set; } 
    }
}