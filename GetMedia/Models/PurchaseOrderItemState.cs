using System;
using System.ComponentModel.DataAnnotations;

namespace GetMedia.Models
{
    public class PurchaseOrderItemState: IModel
    {
        [Key]
        public int Id { get; set; }

        public virtual DateTime StateDate { get; set; }
        public virtual EItemState State { get; set; }
        public virtual EItemStateStatus StateStatus { get; set; }

        [StringLength(256)]
        public string Notes { get; set; }
    }
}