using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Types;

namespace Interfaces
{
    public interface IWatchlistServices
    {
        Task<ActionResult<Response>> SearchMovie(Request request);
    }
}
