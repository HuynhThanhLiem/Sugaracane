using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SugarcaneApplication.Models
{
    public class ProcessingOrder
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int? OrderId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public int Price { get; set; }
        public int Total { get; set; }
        public int Balance { get; set; }
        [Required]
        public int RealPaid { get; set; }
        public int PaidFlag { get; set; }
        [ForeignKey("OrderId")]
        public Order Order { get; set; }
    }
}
