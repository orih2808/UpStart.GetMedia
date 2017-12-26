using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GetMedia.Models
{
    public class Publisher
    {
        [Key]
        public int Id { get; set; }

        [EmailAddress]
        [Required]
        [DataType(DataType.EmailAddress)]
        public virtual string Enmail { get; set; }

        [Required]
        [StringLength(256)]
        public virtual string Name { get; set; }

        [Required]
        [StringLength(256)]
        public virtual string SoleProprietorship { get; set; }

        [Required]
        [StringLength(256)]
        public virtual string ZipCOde { get; set; }

        [Required]
        [StringLength(256)]
        [DataType(DataType.PhoneNumber)]
        public virtual string PhoneNumber { get; set; }

        [Required]
        [StringLength(256)]
        public virtual string WebAddress { get; set; }

        [Required]
        [StringLength(256)]
        public virtual string  AppLink { get; set; }

        public virtual int? ParentID { get; set; }
        public virtual Publisher Parent { get; set; }

        [Required]
        public virtual User User { get; set; }

        public virtual ICollection<Media> PublisherMedia { get; set; }
    }
}
