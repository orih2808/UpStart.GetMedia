using System.Collections.Generic;

namespace GetMedia.Models
{
    public class PurchaseOrder
    {
        public int Id { get; set; }
        virtual public ICollection<PurchaseOrderItem> Prudccts { get; set; }
        virtual public ICollection<SaleInvoice> Invoice { get; set; }
    }
}