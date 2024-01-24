using AutoMapper;
using Voyages.Data;
using Voyages.DTOs.Requests;
using Voyages.DTOs.Responses;

namespace Voyages.Mappings
{
    public class DiariesMappingProfile : Profile
    {
        public DiariesMappingProfile()
        {
            CreateMap<CreateDiaryRequest, Diary>();
            CreateMap<UpdateDiaryRequest, Diary>();
            CreateMap<Diary, DiaryResponse>();
        }
    }
}
