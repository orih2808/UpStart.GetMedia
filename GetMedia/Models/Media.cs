using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GetMedia.Models
{
    public class Media
    {
        [Key]
        int Id { get; }

        int ParentId { get; set; }
        virtual public ICollection<Media> InnerMedia    { get; set; }

        [Required]
        virtual public EMediaType MediaType             { get; set; }

        [Required]
        virtual public ICollection<Product> Products   { get; set; }


    }


}
