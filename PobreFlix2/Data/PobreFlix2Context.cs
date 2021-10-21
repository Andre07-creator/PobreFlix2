using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PobreFlix2.Models;

namespace PobreFlix2.Data
{
    public class PobreFlix2Context : DbContext
    {
        public PobreFlix2Context (DbContextOptions<PobreFlix2Context> options)
            : base(options)
        {
        }

        public DbSet<PobreFlix2.Models.Serie> Serie { get; set; }

        public DbSet<PobreFlix2.Models.Movie> Movie { get; set; }
    }
}
