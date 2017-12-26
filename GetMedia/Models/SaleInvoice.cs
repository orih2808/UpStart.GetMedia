using System.Collections.Generic;

namespace GetMedia.Models
{
    public class SaleInvoice
    {
        public int Id { get; set; }
        virtual public ICollection<SalesInvoiceItem> SaleItems { get; set; } 
    }
}