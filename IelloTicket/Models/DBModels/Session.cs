using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IelloTicket.Models.DBModels
{
    public class Session
    {

        public int Id { get; set; }
        public DateTime Date { get; set; }

        public int? MovieId { get; set; }

        public Movie Movie { get; set; }

        public List<Session> Sessions { get; set; }

        public Session ()
            {
            Sessions = new List<Session>();
            }

    }
}
