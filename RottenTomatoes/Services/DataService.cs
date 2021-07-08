using System.Collections.Generic;
using System.IO;
using System.Net;
using Newtonsoft.Json;
using RottenTomatoes.Models;

namespace RottenTomatoes.Services
{
    public class DataService
    {
        public Movie GetMovie(int id)
        {
            var detail = Request("movies/"+ id);
            var movie = JsonConvert.DeserializeObject<Movie>(detail);
            return movie;
        }

        public string Request(string endpoint)
        {
            var request =
                (HttpWebRequest) WebRequest.Create("https://www.rottentomatoes.com/api/private/v1.0/" + endpoint);
            var response = (HttpWebResponse) request.GetResponse();

            var reader = new StreamReader(response.GetResponseStream());
            return reader.ReadToEnd();
        }

        public List<Movie> GetMoviebyName(string nameMovie)
        {
            var detail = Request("movies?q=" + nameMovie);
            var movie = JsonConvert.DeserializeObject<List<Movie>>();
            return movie;
        }


    }
}