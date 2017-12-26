﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GetMedia.Models
{
    public class Media
    {
        [Key]
        int Id { get; }

        int ParentId { get; set; }
        public virtual Media Parent { get; set; }

        public virtual ICollection<Media> InnerMedia    { get; set; }

        [Required]
        public virtual EMediaType MediaType             { get; set; }

        [Required]
        public virtual ICollection<Product> Products   { get; set; }


    }


}
