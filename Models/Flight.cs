using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using TicketLine.Models;

namespace TicketLine.Models
{
    public class Flight
    {
        [Key]
        public int Id { get; set; }

        public int BoardingId { get; set; }

        public int DestinationId { get; set; }

        [Required]
        public DateTime TakeoffTime { get; set; }

        [Required]
        public DateTime ArrivalTime { get; set; }

        public virtual Airport Boarding { get; set; }

        public virtual Airport Destination { get; set; }

        public Flight()
        {
        }
    }
}
