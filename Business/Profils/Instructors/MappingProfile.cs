using AutoMapper;
using Business.Requests.Instructors;
using Business.Responses.Instructors;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profils.Instructors
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Instructor, CreateInstructorRequest>().ReverseMap();
            CreateMap<Instructor, DeleteInstructorRequest>().ReverseMap();
            CreateMap<Instructor, UpdateInstructorRequest>().ReverseMap();

            CreateMap<Instructor, CreateInstructorResponse>().ReverseMap();
            CreateMap<Instructor, DeleteInstructorResponse>().ReverseMap();
            CreateMap<Instructor, UpdateInstructorResponse>().ReverseMap();
            CreateMap<Instructor, GetAllInstructorResponse>().ReverseMap();
            CreateMap<Instructor, GetByIdInstructorResponse>().ReverseMap();
        }
    }
}
