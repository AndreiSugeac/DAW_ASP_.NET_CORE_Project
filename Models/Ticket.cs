using System;
using System.Collections.Generic;
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

        public Ticket()
        {
        }
    }
}
