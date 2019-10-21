using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MovieWatchlist.Models;
using Types;

namespace MovieWatchlist.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly MovieWatchlist.Models.MovieWatchlistContext _context;

        public IndexModel(MovieWatchlist.Models.MovieWatchlistContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
