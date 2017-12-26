using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GetMedia.Models
{
    public class Publisher
    {
        [Key]
        public int Id { get; set; }

        [EmailAddress]
        [Required]
        virtual public string Enmail { get; set; }

        [Required]
        [StringLength(256)]
        virtual public string Name { get; set; }

        [Required]
        [StringLength(256)]
        virtual public string SoleProprietorship { get; set; }

        [Required]
        [StringLength(256)]
        virtual public string ZipCOde { get; set; }

        [Required]
        [StringLength(256)]
        virtual public string PhoneNumber { get; set; }

        [Required]
        [StringLength(256)]
        virtual public string WebAddress { get; set; }

        [Required]
        [StringLength(256)]
        virtual public string  AppLink { get; set; }

        virtual public ICollection<Media> PublisherMedia { get; set; }

    }
}
