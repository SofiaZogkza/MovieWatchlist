using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MovieWatchlist.Models;
using Types;

namespace MovieWatchlist.Pages.Watchlist
{
    public class GetMoviesModel : PageModel
    {
        private readonly MovieWatchlistContext _context;

        public GetMoviesModel(MovieWatchlistContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            //return Page();
        }

        [BindProperty]
        public Movie Movie { get; set; }

        //public async Task<IActionResult> OnGetAsync(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    //Movie = await _context.Movie.FirstOrDefaultAsync(m => m.Id == id);

        //    if (Movie == null)
        //    {
        //        return NotFound();
        //    }
        //    return Page();
        //}
    }
}