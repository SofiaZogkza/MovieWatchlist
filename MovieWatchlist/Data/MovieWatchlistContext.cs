using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Types;

namespace MovieWatchlist.Models
{
    public class MovieWatchlistContext : DbContext
    {
        public MovieWatchlistContext (DbContextOptions<MovieWatchlistContext> options)
            : base(options)
        {
        }

        public DbSet<Types.Movie> Movie { get; set; }
    }
}
