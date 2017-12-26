using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetMedia.Models
{
    public class IModel
    {
        public virtual DateTime UpdateTime { get; set; }
        public int UserId { get; set; }
    }
}
