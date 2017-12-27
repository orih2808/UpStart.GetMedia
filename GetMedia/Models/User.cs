using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GetMedia.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        public virtual EUserStatus UserStatus { get; set; }

        public virtual ICollection<UserInOrganization> Organizations { get; set; }
    }
}
