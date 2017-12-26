﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetMedia.Models
{
    public class UserInOrganization
    {
        public int UserId                               { get; set; }
        public virtual User User                        { get; set; }


        public int OrganizationId                       { get; set; }
        public virtual Organization Organization        { get; set; }

        public virtual ICollection<UserRole> UserRole   { get; set; }
    }
}
