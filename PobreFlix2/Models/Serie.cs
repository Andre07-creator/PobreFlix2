using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PobreFlix.Models.Enums;

namespace PobreFlix2.Models
{
    public class Serie : Watch
    {
        public int Season { get; set; }
        public Serie()
        {

        }

        public Serie(int id, string name, Genre genre, string description, double rating, int season, DateTime realeaseDate) : base(id, name, realeaseDate, genre, description, rating)
        {
            Season = season;
        }
    }
}
