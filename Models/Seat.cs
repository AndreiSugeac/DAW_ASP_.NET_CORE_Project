using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketLine.Models
{
    public class Seat
    {
        public int Id { get; set; }

        public int AirplaneId { get; set; }

        public virtual Airplane Airplane { get; set; }

        public virtual Ticket Ticket { get; set; }
    }
}
