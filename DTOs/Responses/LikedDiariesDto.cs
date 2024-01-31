using System.ComponentModel.DataAnnotations.Schema;
using Voyages.Data;

namespace Voyages.DTOs.Responses
{
    public class LikedDiariesDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int DiaryId { get; set; }
    }
}
