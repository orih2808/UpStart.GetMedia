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
        public string Enmail { get; set; }

        [Required]
        [StringLength(256)]
        public string Name { get; set; }

        [Required]
        [StringLength(256)]
        public string SoleProprietorship { get; set; }

        [Required]
        [StringLength(256)]
        public string ZipCOde { get; set; }

        [Required]
        [StringLength(256)]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [Required]
        [StringLength(256)]
        public string WebAddress { get; set; }

        [Required]
        [StringLength(256)]
        public string  AppLink { get; set; }

        public int? ParentID { get; set; }
        public virtual Publisher Parent { get; set; }

        [Required]
        public virtual User User { get; set; }

        public virtual ICollection<Media> PublisherMedia { get; set; }
    }
}
