using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SugarcaneApplication.Models
{
    public class Payment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int? ProcessingId { get; set; }
        public int? ProductId { get; set; }
        [Required]
        public short PaymentFlag { get; set; }
        public string PaymentText { get; set; }
        [Required]
        public int Total { get; set; }
        [Required]
        public string PaymentDate { get; set; }
        [ForeignKey("ProductId")]
        public ProductOrder ProductOrder { get; set; }
        [ForeignKey("ProcessingId")]
        public ProcessingOrder ProcessingOrder { get; set; }
    }
}
