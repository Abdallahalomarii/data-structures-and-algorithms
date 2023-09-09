namespace challenge28_SortingComparisons
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Movie[] movies = new Movie[5]
        {
            new Movie { title = "A Movie", year = 2012, genres = new List<string> { "Action", "Adventure" } },
            new Movie { title = "An Amazing Movie", year = 2011, genres = new List<string> { "Comedy", "Romance" } },
            new Movie { title = "The bestest Movie", year = 2003, genres = new List<string> { "Drama", "Thriller" } },
            new Movie { title = "Zelda", year = 2020, genres = new List<string> { "Sci-Fi", "Mystery" } },
            new Movie { title = "Starfield", year = 2001, genres = new List<string> { "Horror", "Fantasy" } }
        };

            Movie[] SortedByYear = movies[0].SortArrayMoviesByYear(movies);
            foreach (Movie movie in SortedByYear)
            {
                Console.WriteLine(movie.title);
            }

            Console.WriteLine("---------------");

            Movie[] sortByTitle = movies[0].SortArrayMoviesByTitle(movies);
            foreach (Movie movie in sortByTitle)
            {
                Console.WriteLine(movie.title);
            }

        }
    }
}
