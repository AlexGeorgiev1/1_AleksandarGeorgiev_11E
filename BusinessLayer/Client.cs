using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Client
    {
        public Client()
        {

        }
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Range(1, 100)]
        public int Age { get; set; }
        //[ForeignKey("Reservation")]
        public ICollection<Reservation> Reservations { get; set; }
    }
}
