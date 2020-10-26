using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IelloTicket.Models.DBModels
{
    public class Actor
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public int? MovieId { get; set; }

        public Movie Movie { get; set; }
    }
}
