using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; } = string.Empty;

        [StringLength(100)]
        public string? Description { get; set; } = "This is basic description";

        [Column(TypeName = "decimal(18, 2)")]
        [Range(0, 50)]
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}
