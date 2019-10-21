using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MovieWatchlist.Models;
using Types;

namespace MovieWatchlist.Pages
{
    public class IndexModel : PageModel
    {
        private readonly MovieWatchlistContext _context;

        public IndexModel(MovieWatchlistContext context)
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
