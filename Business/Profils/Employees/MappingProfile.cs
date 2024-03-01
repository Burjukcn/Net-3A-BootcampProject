﻿using AutoMapper;
using Business.Requests.Employees;
using Business.Responses.Employees;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profils.Employees
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Employee, CreateEmployeeRequest>().ReverseMap();
            CreateMap<Employee, DeleteEmployeeRequest>().ReverseMap();
            CreateMap<Employee, UpdateEmployeeRequest>().ReverseMap();

            CreateMap<Employee, CreateEmployeeResponse>().ReverseMap();
            CreateMap<Employee, DeleteEmployeeResponse>().ReverseMap();
            CreateMap<Employee, UpdateEmployeeResponse>().ReverseMap();
            CreateMap<Employee, GetAllEmployeeResponse>().ReverseMap();
            CreateMap<Employee, GetByIdEmployeeResponse>().ReverseMap();
        }
    }
}
