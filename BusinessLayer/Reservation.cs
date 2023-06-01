using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessLayer
{
    public class Reservation
    {
        public Reservation()
        {

        }
        [Key]
        public int Id { get; set; }
        [Required]
        public string Address { get; set; }
        [Range(0, int.MaxValue)]
        [Required]
        public int Days { get; set; }

        [Range(0, double.MaxValue)]
        [Required]
        public double Price { get; set; }

        [Required]
        //[ForeignKey("Restaurant")]
        public Restaurant Restaurant { get; set; }
    }
}