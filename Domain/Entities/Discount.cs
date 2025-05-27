using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class Discount
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; } = string.Empty;

        [StringLength(100)]
        public string? Description { get; set; } = "This is basic discount description";

        [Column(TypeName = "decimal(5, 2)")]
        [Range(0, 100)]
        public decimal Percentage { get; set; }
    }
}
