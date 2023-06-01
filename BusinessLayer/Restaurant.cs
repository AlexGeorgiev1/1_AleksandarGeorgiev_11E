using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Restaurant
    {
        public Restaurant()
        {
            Reservations = new List<Reservation>();
        }
        [Key]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        //[ForeignKey("Reservation")]
        public ICollection<Reservation> Reservations { get; set; }
        public double ProfitPerYear { get; set; }

    }
}
