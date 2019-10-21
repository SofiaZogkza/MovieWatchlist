using Interfaces;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Types;

namespace Services
{
    public class WatchlistService : IWatchlistServices
    {
        public async Task<ActionResult<Response>> SearchMovie(Request request)
        {
            string api_key = "008862c24c18c66f18982514a3641a88";
            string uri = "https://api.themoviedb.org/3/search/movie?api_key=008862c24c18c66f18982514a3641a88&language=en-US&query=";
            var requestedMoviesTasks = SendRequestToMovieDbApi(request, uri);

            List<Movie> movies = new List<Movie>();

            var tMDBResponse = (await Task.WhenAll(requestedMoviesTasks)).ToList();

            var objTMDBResponse = tMDBResponse.Where(x => !string.IsNullOrWhiteSpace(x))
                                                    .Select(x => JsonConvert.DeserializeObject<Response>(x));
            if (objTMDBResponse.Any())
            {
                // TODO: Show the response to javascript
                //return View(objTMDBResponse);
                //return objTMDBResponse.ToList();
            }

            return new NoContentResult();
        }

        private async Task<string> SendRequestToMovieDbApi(Request request, string address)
        {
            var baseAddress = new Uri(address);

            using (var httpClient = new HttpClient { BaseAddress = baseAddress})
            {
                var sofia = new Request()
                {
                    ApiKey = "008862c24c18c66f18982514a3641a88",
                    Title = "Batman"
                };
                string output = JsonConvert.SerializeObject(sofia);
                using (var content = new StringContent(output, System.Text.Encoding.Default, "application/json"))
                {
                    using (var response = await httpClient.GetAsync(address + sofia.Title.ToString()))// TODO: fix it with query string coming from javascript
                    {
                        string responseJsonData = await response.Content.ReadAsStringAsync();
                        return responseJsonData;
                    }
                }
            }
        }
    }
}
