using System.ComponentModel.DataAnnotations.Schema;

namespace Voyages.DTOs.Requests
{
    public class CreateDiaryRequest
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string OverratedSpots { get; set; }
        public string UnderratedSpots { get; set; }
        public int Rating { get; set; } // Assuming 1-5 star rating
        public bool IsPublic { get; set; }
        public int UserId { get; set; } // Foreign key for User
    }
}
