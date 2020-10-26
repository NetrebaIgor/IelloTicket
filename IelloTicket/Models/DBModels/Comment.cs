using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IelloTicket.Models.DBModels
{
    public class Comment
    {

        public int Id { get; set; }

        public int? MovieId { get; set; }

        public Movie Movie { get; set; }
        public int? UserId { get; set; }

        public User User { get; set; }
    }
}
