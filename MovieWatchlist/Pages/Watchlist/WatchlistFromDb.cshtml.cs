using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MovieWatchlist.Models;
using Types;

namespace MovieWatchlist.Pages.Watchlist
{
    public class WatchlistFromDbModel : PageModel
    {
        private readonly MovieWatchlistContext _context;

        public WatchlistFromDbModel(MovieWatchlistContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get; set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}