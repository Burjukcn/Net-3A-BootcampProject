﻿using Core.Exceptions;
using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework.Contexts;
using DataAccess.Concretes.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess;

public static class DataAccessServiceRegistration
{
    public static IServiceCollection AddDataAccessServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<BaseDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("TobetoNet3AConnectionString")));

        //services.AddScoped<IUserRepository, UserRepository>();
        //services.AddScoped<IInstructorRepository, InstructorRepository>();
        //services.AddScoped<IEmployeeRepository, EmployeeRepository>();
        //services.AddScoped<IApplicantRepository, ApplicantRepository>();
        //services.AddScoped<IApplicationRepository, ApplicationRepository>();
        //services.AddScoped<IApplicationStateRepository, ApplicationStateRepository>();
        //services.AddScoped<IBootcampRepository, BootcampRepository>();
        //services.AddScoped<IBootcampStateRepository, BootcampStateRepository>();
        //services.AddScoped<IBlacklistRepository, BlacklistRepository>();

        services.RegisterAssemblyTypes(Assembly.GetExecutingAssembly()).Where(x => x.ServiceType.Name.EndsWith("Repository"));

        return services;
    }
}