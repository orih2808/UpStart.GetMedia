namespace GetMedia.Models
{
    public class PurchaseOrderItem
    {
        public int Id { get; set; }
        public virtual Product Prudcct { get; set; }
        public virtual PurchaseOrderItemState ItemState { get;set;}
    }
}