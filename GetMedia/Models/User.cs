using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetMedia.Models
{
    public class User
    {
        public int Id { get; set; }
        virtual public ICollection<UserInOrganization> Organizations { get; set; }
        virtual public ICollection<UserAdvertiser> Advertisers { get; set; }
}
}
