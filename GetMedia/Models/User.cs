using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GetMedia.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public virtual EUserStatus UserStatus { get; set; }

        public virtual ICollection<UserInOrganization> Organizations { get; set; }
        //public virtual ICollection<UserAdvertiser> Advertisers { get; set; }
    }
}
