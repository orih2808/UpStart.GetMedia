using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GetMedia.Models
{
    public class SaleInvoice
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public virtual DateTime InvoiceDate { get; set; }
        [Required]
        public virtual ICollection<SalesInvoiceItem> SaleItems { get; set; }
    }
}