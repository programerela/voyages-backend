using AutoMapper;
using Voyages.Data;
using Voyages.DTOs.Requests;
using Voyages.DTOs.Responses;

namespace Voyages.Mappings
{
    public class UserMappingProfile : Profile
    {
        public UserMappingProfile()
        {
            CreateMap<CreateUserRequest, AppUser>();
            CreateMap<AppUser, UserResponse>();
        }
    }
}
