using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetMedia.Models
{
    public class User
    {
        public int Id { get; set; }
        public virtual ICollection<UserInOrganization> Organizations { get; set; }
        public virtual ICollection<UserAdvertiser> Advertisers { get; set; }
    }
}
