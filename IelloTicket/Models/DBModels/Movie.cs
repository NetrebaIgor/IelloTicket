using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IelloTicket.Models.DBModels
{
    public class Movie
    {

        int Id { get; set; }

        public string Name { get; set; }

        public byte[] PosterImage { get; set; }
        public byte[] BackgroundImage { get; set; }
        public string Country { get; set; }

        public int Duration { get; set; }


        //--------------------onE-TO-One--------------


        public int? DirectorID { get; set; }
        public Director Director { get; set; }


        //-------------------onE-TO-Many--------------


        public List<Actor> Actors { get; set; }
        public List<Genre> Genres { get; set; }
        public Movie()
        {
            Actors = new List<Actor>();
            Genres = new List<Genre>();
        }


    }
}
