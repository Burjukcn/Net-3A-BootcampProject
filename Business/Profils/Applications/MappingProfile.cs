using AutoMapper;
using Entities.Concretes;
using Business.Responses.Applications;
using Business.Requests.Applications;


namespace Business.Profils.Applications
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Application, CreateApplicationRequest>().ReverseMap();
            CreateMap<Application, DeleteApplicationRequest>().ReverseMap();
            CreateMap<Application, UpdateApplicationRequest>().ReverseMap();

            CreateMap<Application, CreatedApplicationResponse>().ReverseMap();
            CreateMap<Application, DeletedApplicationResponse>().ReverseMap();
            CreateMap<Application, UpdatedApplicationResponse>().ReverseMap();
            CreateMap<Application, GetAllApplicationResponse>().ReverseMap();
            CreateMap<Application, GetByIdApplicationResponse>().ReverseMap();
        }
    }
}
