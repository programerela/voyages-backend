using AutoMapper;
using Voyages.Data;
using Voyages.DTOs.Requests;
using Voyages.DTOs.Responses;

namespace Voyages.Mappings
{
    public class LikedDiariesMappingProfile : Profile
    {
        public LikedDiariesMappingProfile()
        {
            CreateMap<CreateLikedDiaryRequest, LikedDiary>();
            CreateMap<LikedDiary, LikedDiaryResponse>();
        }
    }
}
