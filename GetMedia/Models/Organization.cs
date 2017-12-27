using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GetMedia.Models
{
    public class Organization
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(256)]
        public string Name { get; set; }

        public virtual ICollection<UserInOrganization> Users { get; set; }
        public virtual ICollection<Publisher> Publishers { get; set; }
        public virtual ICollection<Media> Medias { get; set; }
    }
}
