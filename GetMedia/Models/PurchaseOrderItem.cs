namespace GetMedia.Models
{
    public class PurchaseOrderItem
    {
        public int Id { get; set; }
        virtual public Product Prudcct { get; set; }
        virtual public PurchaseOrderItemState ItemState { get;set;}
    }
}