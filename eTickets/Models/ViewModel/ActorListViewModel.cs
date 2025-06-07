namespace eTickets.Models.ViewModels
{
    public class ActorListViewModel
    {
        public required IEnumerable<Actor> Actors { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
    }
}
