using AutoMapper;
using Business.Requests.Applicants;
using Business.Responses.Applicants;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profils.Applicants
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Applicant, CreateApplicantRequest>().ReverseMap();
            CreateMap<Applicant, DeleteApplicantRequest>().ReverseMap();
            CreateMap<Applicant, UpdateApplicantRequest>().ReverseMap();

            CreateMap<Applicant, CreateApplicantResponse>().ReverseMap();
            CreateMap<Applicant, DeleteApplicantResponse>().ReverseMap();
            CreateMap<Applicant, UpdateApplicantResponse>().ReverseMap();
            CreateMap<Applicant, GetAllApplicantResponse>().ReverseMap();
            CreateMap<Applicant, GetByIdApplicantResponse>().ReverseMap();
        }
    }
}
