using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using PobreFlix.Models.Enums;

namespace PobreFlix2.Models
{
    public class Watch
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Release Date")]
        public DateTime RealeaseDate { get; set; }
        public Genre Genre { get; set; }
        [DataType(DataType.Text)]
        public string Description { get; set; }
        [DisplayFormat(DataFormatString = "{0:F1}")]
        public double Rating { get; set; }

        public Watch()
        {

        }

        public Watch(int id, string name, DateTime realeaseDate, Genre genre, string description, double rating)
        {
            Id = id;
            Name = name;
            RealeaseDate = realeaseDate;
            Genre = genre;
            Description = description;
            Rating = rating;
        }
    }
}
