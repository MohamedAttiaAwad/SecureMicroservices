using Movies.Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Client.ApiServices
{
    public class MovieApiService : IMovieApiService
    {
        public Task<Movie> CreateMovie(Movie movie)
        {
            throw new NotImplementedException();
        }

        public Task DeleteMovie(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Movie> GetMovie(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Movie> GetMovies()
        {
            var movies = new List<Movie>()
                {
                    new Movie(){ Id = 1, Genre = "drama", Title="the film 1", ImageUrl="src", ReleaseDate= new DateTime(1994,12,1),Rating="9.3",Owner="alice" },
                    new Movie(){ Id = 2, Genre = "drama", Title="the film 2", ImageUrl="src", ReleaseDate= new DateTime(1994,12,1),Rating="9.3",Owner="alice" },
                    new Movie(){ Id = 3, Genre = "drama", Title="the film 3", ImageUrl="src", ReleaseDate= new DateTime(1994,12,1),Rating="9.3",Owner="alice" },
                    new Movie(){ Id = 4, Genre = "drama", Title="the film 4", ImageUrl="src", ReleaseDate= new DateTime(1994,12,1),Rating="9.3",Owner="alice" },
                };
            return movies;
        }

        public Task<Movie> UpdateMovie(Movie movie)
        {
            throw new NotImplementedException();
        }
    }
}
