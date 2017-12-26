using System.Collections.Generic;

namespace GetMedia.Models
{
    public class PurchaseOrder
    {
        public int Id { get; set; }
        public virtual ICollection<PurchaseOrderItem> Prudccts { get; set; }
        public virtual ICollection<SaleInvoice> Invoice { get; set; }
    }
}