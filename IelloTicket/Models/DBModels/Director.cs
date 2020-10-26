using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace IelloTicket.Models.DBModels
{
    public class Director
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public List<Movie> Movies { get; set; }
        public Director()
        {
            Movies = new List<Movie>();
        }
    }
}
