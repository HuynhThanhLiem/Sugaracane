using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SugarcaneApplication.Models
{
    public class ProductOrder
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int? OrderId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int BigBunch { get; set; }
        [Required]
        public int SmallBunch { get; set; }
        [Required]
        public int Total { get; set; }
        public int? SupplierId { get; set; }
        public int PaidFlag { get; set; }

        [ForeignKey("OrderId")]
        public Order Order { get; set; }
        [ForeignKey("SupplierId")]
        public Supplier Supplier { get; set; }
    }
}
