using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GetMedia.Models
{
    public class Campaign
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(256)]
        public virtual string Name { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public virtual DateTime StartDate { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public virtual DateTime EndDate { get; set; }

        public virtual ICollection<PurchaseOrder> Orders { get; set; }


    }
}
