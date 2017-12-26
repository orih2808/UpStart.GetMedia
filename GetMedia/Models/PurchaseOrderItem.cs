using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GetMedia.Models
{
    public class PurchaseOrderItem
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public virtual DateTime StartDate { get; set; }

        [Required]
        public virtual DateTime EndDate { get; set; }

        [Required]
        public virtual Product Prudcct { get; set; }

        [Required]
        public virtual ICollection<PurchaseOrderItemState> ItemStates { get; set; }
    }
}