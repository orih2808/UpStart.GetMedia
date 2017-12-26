using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetMedia.Models
{
    public class UserInOrganization
    {
        public int UserId                               { get; set; }
        virtual public User User                        { get; set; }


        public int OrganizationId                       { get; set; }
        virtual public Organization Organization        { get; set; }

        virtual public ICollection<UserRole> UserRole { get; set; }
    }
}
