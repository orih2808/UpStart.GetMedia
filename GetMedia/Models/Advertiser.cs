using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GetMedia.Models
{
    public class Advertiser
    {
        [Key]
        public int Id { get; set; }

        public int? ParentID { get; set; }
        public virtual Advertiser Parent { get; set; }

        [Required]
        public virtual User User { get; set; }

        public virtual ICollection<Advertiser> GetAdvertiser { get; set; }
        public virtual ICollection<Campaign> Campaignes { get; set; }
        public virtual ICollection<SaleInvoice> SalesInvoice { get; set; }

    }
}
