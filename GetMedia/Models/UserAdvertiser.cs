using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetMedia.Models
{
    public class UserAdvertiser
    {
        public int UserId               { get; set; }
        public User User                { get; set; }

        public int AdvertiserId         { get; set; }
        public Advertiser Advertiser    { get; set; }
    }
}
