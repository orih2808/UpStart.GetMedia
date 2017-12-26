
using System.ComponentModel.DataAnnotations;

namespace GetMedia.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(256)]
        public virtual string Name { get; set; }

        [Required]
        public virtual EProductFormat ProductFormat { get; set; }

        [Required]
        public virtual EProductFixedSizes ProductFixedSizes { get; set; }

        [Required]
        public virtual ESpecificLocation PageLocation { get; set; }

        [Required]
        [Range(1, int.MaxValue)]
        public virtual int Amount { get; set; }

        public virtual bool IsForSale { get; set; }

        [Required]
        [Range(1, double.MaxValue)]
        public virtual double Price { get; set; }
    }
}