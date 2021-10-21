using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using PobreFlix.Models.Enums;

namespace PobreFlix2.Models
{
    public class Movie : Watch
    {
        [DataType(DataType.Time)]
        public DateTime Duration { get; set; }
            
        public Movie()
        {

        }
        public Movie(int id, string name, Genre genre, string description, int rating, DateTime duration, DateTime releaseDate, DateTime realeaseDate) : base(id, name, realeaseDate, genre, description, rating)
        {
            Duration = duration;
        }
    }
}
