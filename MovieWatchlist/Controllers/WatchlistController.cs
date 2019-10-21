using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Types;
using Interfaces;
using Microsoft.AspNetCore.Authorization;

namespace MovieWatchlist.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WatchlistController : Controller
    {
        private readonly IWatchlistServices _wServices;
        public WatchlistController(IWatchlistServices wServices)
        {
            _wServices = wServices;
        }

        [HttpGet]
        [Route("GetMovies")]
        public async Task<ActionResult<Response>> GetMovies([FromBody] Request request)
        {
            //stelno ena moviename kai mou epistrefi Lista
            var result = await _wServices.SearchMovie(request);
            return result;
        }

        [HttpGet]
        [Route("GetWatchlist")]
        public async Task<ActionResult<Response>> WatchlistFromDb([FromBody] Request request)
        {
            //stelno ena moviename kai mou epistrefi Lista
            var result = await _wServices.SearchMovie(request);
            return View(result);
        }

    }
}