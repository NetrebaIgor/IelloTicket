using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IelloTicket.Models.DBModels
{
    public class Ticket
    {

        public int Id { get; set; }

        public int Seat { get; set; }

        public int Row { get; set; }

        public int Cost { get; set; }
   
        public int? UserId { get; set; }

        public User User { get; set; }

        public int? MovieId { get; set; }

        public Movie Movie { get; set; }

        public int? SessionId { get; set; }

        public Session Session { get; set; }

        public int? TimeId { get; set; }

        public Time Time { get; set; }
    }
}
