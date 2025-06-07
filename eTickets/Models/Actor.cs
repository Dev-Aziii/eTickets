using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }

        [Display(Name ="Profile Picture Url")]
        [Required(ErrorMessage = "Profile Picture is required")]
        [StringLength(2048, ErrorMessage = "URL cannot be longer than 2048 characters")]
        public string ProfilePictureUrl { get; set; }
         
        [Display(Name = "FullName")]
        [Required(ErrorMessage = "Full Name is required")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Full Name must be between 2 and 100 characters")]
        [RegularExpression(@"^[a-zA-Z\s\.'\-]+$", ErrorMessage = "Full Name can only contain letters, spaces, periods, apostrophes, and hyphens")]
        public string FullName { get; set; }

        [Display(Name = "Biography")]
        [Required(ErrorMessage = "Biography is required")]
        [StringLength(2000, ErrorMessage = "Biography cannot exceed 2000 characters")]
        public string Bio { get; set; }

        // Relationships
        public List<Actor_Movie> Actors_Movies { get; set; } = new();
    }
}
    