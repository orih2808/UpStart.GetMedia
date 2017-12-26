using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GetMedia.Models
{
    public class Organization
    {
        [Key]
        virtual public int Id {get;set;}

        [Required]
        [StringLength(256)]
        virtual public string Name { get; set; }

        virtual public ICollection<UserInOrganization>  Users   { get; set; }
        virtual public ICollection<Publisher> Publishers        { get; set; }
        virtual public ICollection<Media> Medias                { get; set; }
    }
}
