using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SugarcaneApplication.Models
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int Total { get; set; }
        public int Paid { get; set; }
        public int PaidFlag { get; set; }
        [Required]
        public string OrderDate { get; set; }

    }
}
