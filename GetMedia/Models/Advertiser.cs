using System.Collections.Generic;

namespace GetMedia.Models
{
    public class Advertiser
    {
        public int Id { get; set; }
        public virtual int? ParentID {get;set;}
        public virtual Advertiser Parent { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<Advertiser> GetAdvertiser { get; set; }
        public virtual ICollection<Campaign> Campaignes { get; set; }
    }
}
