using AutoMapper;
using Business.Requests.Users;
using Business.Responses.Users;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profils.Users
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, CreateUserRequest>().ReverseMap();
            CreateMap<User, DeleteUserRequest>().ReverseMap();
            CreateMap<User, UpdateUserRequest>().ReverseMap();

            CreateMap<User, CreatedUserResponse>().ReverseMap();
            CreateMap<User, DeletedUserResponse>().ReverseMap();
            CreateMap<User, UpdatedUserResponse>().ReverseMap();
            CreateMap<User, GetAllUserResponse>().ReverseMap();
            CreateMap<User, GetByIdUserResponse>().ReverseMap();
        }
    }
}
