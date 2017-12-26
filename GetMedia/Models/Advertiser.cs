using System.Collections.Generic;

namespace GetMedia.Models
{
    public class Advertiser
    {
        public int Id { get; set; }
        virtual public int ParentID {get;set;}
        virtual public ICollection<User> Users { get; set; }
        virtual public ICollection<Campaign> Campaignes { get; set; }
    }
}
