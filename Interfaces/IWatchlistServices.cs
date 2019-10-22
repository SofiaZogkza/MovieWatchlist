using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Types;

namespace Interfaces
{
    public interface IWatchlistServices
    {
        Task<ActionResult<Response>> SearchMovie(Request request);
        Task<ActionResult<Response>> GetWatchlistFromDb();
    }
}
