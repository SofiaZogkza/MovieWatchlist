using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MovieWatchlist.Models;
using Services;
using Types;

namespace MovieWatchlist.Pages.Watchlist
{
    public class GetMoviesModel : PageModel
    {
        private readonly MovieWatchlistContext _context;
        //private readonly WatchlistController _controller;
        private readonly WatchlistService _services;
        private readonly IWatchlistServices _Iservices;

        public GetMoviesModel(MovieWatchlistContext context, IWatchlistServices Iservices)
        {
            _context = context;
            _Iservices = Iservices;
        }
        //public void OnGet()
        //{
        //    //return Page();
        //}

        [BindProperty]
        public Movie Movie { get; set; }

        public async Task<IActionResult> OnGetAsync(Request request)
        {
            if (request == null)
            {
                return NotFound();
            }
            // The list with all the Movies and characteristics that our Search returned.
            var responseFromTMDB =  _Iservices.SearchMovie(request);
            // Keep only the title from the above movies.
            if (responseFromTMDB.Status != TaskStatus.Faulted)
            {
                var titleQuery = responseFromTMDB?.Result?.Value?.Movie?.Select(x => x?.Title).ToList();
            }
            else
            {
                return NotFound();
            }

            if (!string.IsNullOrEmpty(Movie.Title))
            {
                movies = titleQuery.Where(s => s.Title.Contains(Movie.Title));
            }


            if (responseFromTMDB == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}