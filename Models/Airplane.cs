﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketLine.Models
{
    public class Airplane
    {
        public int Id { get; set; }

        public string Manufacturer { get; set; }

        public string Model { get; set; }

        public int NumberOfSeats { get; set; }

        public virtual ICollection<Seat> Seats { get; set; }

        public int FlightId { get; set; }

        public virtual Flight Flight { get; set; }
    }
}
