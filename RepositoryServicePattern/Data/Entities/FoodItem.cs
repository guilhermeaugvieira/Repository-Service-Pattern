using System.ComponentModel.DataAnnotations;

namespace RepositoryServicePattern.Data.Entities
{
    public class FoodItem
    {
        [Key]
        [Required] 
        public long ID { get; set; }

        [Required]
        [MaxLength(80)]
        public string Name { get; set; }

        [Required]
        public decimal SalePrice { get; set; }

        [Required]
        public decimal UnitPrice {get; set;}

        [Required]
        public int Quantity { get; set; }
    }
}
