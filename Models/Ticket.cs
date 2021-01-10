using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TicketLine.Models
{
    public class Ticket
    {

        public int Id { get; set; }

        public string Description { get; set; }

        public int SeatId { get; set; }

        public virtual Seat Seat { get; set; }

        public string OwnerId { get; set; }

        [ForeignKey("OwnerId")]
        public virtual ApplicationUser Owner { get; set; }

        public Ticket()
        {
        }
    }
}
