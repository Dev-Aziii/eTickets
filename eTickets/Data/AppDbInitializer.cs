using eTickets.Data.Enums;
using eTickets.Models;

namespace eTickets.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var servicescope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = servicescope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                //Cinema
                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            Name = "Cinema 1",
                            Logo = "https://dotnethow.net/images/cinemas/cinema-1.jpeg",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua."
                        },
                        new Cinema()
                        {
                            Name = "Cinema 2",
                            Logo = "https://dotnethow.net/images/cinemas/cinema-2.jpeg",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua."
                        },
                        new Cinema()
                        {
                            Name = "Cinema 3",
                            Logo = "https://dotnethow.net/images/cinemas/cinema-3.jpeg",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua."
                        },
                        new Cinema()
                        {
                            Name = "Cinema 4",
                            Logo = "https://dotnethow.net/images/cinemas/cinema-4.jpeg",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua."
                        },
                         new Cinema()
                        {
                            Name = "Cinema 5",
                            Logo = "https://dotnethow.net/images/cinemas/cinema-5.jpeg",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua."
                        },
                    });
                    context.SaveChanges();

                }
                //Actors
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor() {
                            FullName = "Tom Hanks",
                            Bio = "American actor and filmmaker.",
                            ProfilePictureUrl = "https://dotnethow.net/images/actors/actor-1.jpeg"
                        },
                        new Actor() { FullName = "Scarlett Johansson", Bio = "American actress and singer.", ProfilePictureUrl = "https://dotnethow.net/images/actors/actor-2.jpeg" },
                        new Actor() { FullName = "Dwayne Johnson", Bio = "American actor and former wrestler.", ProfilePictureUrl = "https://dotnethow.net/images/actors/actor-3.jpeg" },
                        new Actor() { FullName = "Emma Watson", Bio = "British actress and activist.", ProfilePictureUrl = "https://dotnethow.net/images/actors/actor-4.jpeg" },
                        new Actor() { FullName = "Leonardo DiCaprio", Bio = "American actor and producer.", ProfilePictureUrl = "https://dotnethow.net/images/actors/actor-5.jpeg" }
                    });
                    context.SaveChanges();
                }
                //Producers
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer() { FullName = "Steven Spielberg", Bio = "American film director and producer.", ProfilePictureUrl = "https://dotnethow.net/images/producers/producer-1.jpeg" },
                        new Producer() { FullName = "Christopher Nolan", Bio = "British-American film director, producer, and screenwriter.", ProfilePictureUrl = "https://dotnethow.net/images/producers/producer-2.jpeg" },
                        new Producer() { FullName = "Kathleen Kennedy", Bio = "American film producer and president of Lucasfilm.", ProfilePictureUrl = "https://dotnethow.net/images/producers/producer-3.jpeg" },
                        new Producer() { FullName = "Kevin Feige", Bio = "American film producer and president of Marvel Studios.", ProfilePictureUrl = "https://dotnethow.net/images/producers/producer-4.jpeg" },
                        new Producer() { FullName = "James Cameron", Bio = "Canadian filmmaker and environmentalist.", ProfilePictureUrl = "https://dotnethow.net/images/producers/producer-5.jpeg" }
                    });
                    context.SaveChanges();
                }
                //Movies
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            Name = "Action Movie 1",
                            Description = "An exciting action movie.",
                            Price = 10.99,
                            ImageUrl = "https://dotnethow.net/images/movies/movie-1.jpeg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(10),
                            CinemaId = 1,
                            ProducerId = 1,
                            MovieCategory = MovieCategory.Action
                        },
                        new Movie()
                        {
                            Name = "Comedy Movie 1",
                            Description = "A hilarious comedy movie.",
                            Price = 9.99,
                            ImageUrl = "https://dotnethow.net/images/movies/movie-2.jpeg",
                            StartDate = DateTime.Now.AddDays(-5),
                            EndDate = DateTime.Now.AddDays(15),
                            CinemaId = 2,
                            ProducerId = 2,
                            MovieCategory = MovieCategory.Comedy
                        },
                        new Movie()
                        {
                            Name = "Drama Movie 1",
                            Description = "A touching drama movie.",
                            Price = 12.99,
                            ImageUrl = "https://dotnethow.net/images/movies/movie-3.jpeg",
                            StartDate = DateTime.Now.AddDays(-20),
                            EndDate = DateTime.Now.AddDays(5),
                            CinemaId = 3,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Drama
                        },
                        new Movie()
                        {
                            Name = "Horror Movie 1",
                            Description = "A scary horror movie.",
                            Price = 8.99,
                            ImageUrl = "https://dotnethow.net/images/movies/movie-4.jpeg",
                            StartDate = DateTime.Now.AddDays(-2),
                            EndDate = DateTime.Now.AddDays(20),
                            CinemaId = 1,
                            ProducerId = 4,
                            MovieCategory = MovieCategory.Horror
                        },
                        new Movie()
                        {
                            Name = "Cartoon Movie 1",
                            Description = "A fun cartoon movie.",
                            Price = 7.99,
                            ImageUrl = "https://dotnethow.net/images/movies/movie-5.jpeg",
                            StartDate = DateTime.Now.AddDays(-1),
                            EndDate = DateTime.Now.AddDays(30),
                            CinemaId = 2,
                            ProducerId = 5,
                            MovieCategory = MovieCategory.Cartoon
                        }
                    });
                    context.SaveChanges();
                }
                //Actors_Movies
                if (!context.Actors_Movies.Any())
                {
                    context.Actors_Movies.AddRange(new List<Actor_Movie>()
                    {
                        new Actor_Movie() { ActorId = 1, MovieId = 1 },
                        new Actor_Movie() { ActorId = 2, MovieId = 2 },
                        new Actor_Movie() { ActorId = 3, MovieId = 3 },
                        new Actor_Movie() { ActorId = 4, MovieId = 4 },
                        new Actor_Movie() { ActorId = 5, MovieId = 5 }
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
