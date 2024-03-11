﻿using Core.CrossCuttingConcerns.Rules;
using Core.Exceptions;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;



namespace Business
{
    public static class BusinessServiceRegistration
    {
        public static IServiceCollection AddBusinessServices(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            services.AddSubClassesOfType(Assembly.GetExecutingAssembly(), typeof(BaseBusinessRules));

            //services.AddScoped<IUserService, UserManager>();
            //services.AddScoped<IApplicantService, ApplicantManager>();
            //services.AddScoped<IEmployeeService, EmployeeManager>();
            //services.AddScoped<IInstructorService, InstructorManager>();
            //services.AddScoped<IBootcampService, BootcampManager>();
            //services.AddScoped<IBootcampStateService, BootcampStateManager>();
            //services.AddScoped<IApplicationStateService, ApplicationStateManager>();
            //services.AddScoped<IApplicationService, ApplicationManager>();
            //services.AddScoped<IBlacklistService, BlacklistManager>();

            services.RegisterAssemblyTypes(Assembly.GetExecutingAssembly()).Where(x => x.ServiceType.Name.EndsWith("Manager"));
            return services;
        }
        public static IServiceCollection AddSubClassesOfType
        (this IServiceCollection services, Assembly assembly,
        Type type, Func<IServiceCollection, Type, IServiceCollection>? addWithLifeCycle = null)
        {
            var types = assembly.GetTypes().Where(t => t.IsSubclassOf(type) && type != t).ToList();
            foreach (Type? item in types)
            {
                if (addWithLifeCycle == null) { services.AddScoped(item); }
                else { addWithLifeCycle(services, type); }
            }
            return services;
        }

        public static IServiceCollection RegisterAssemblyTypes
            (this IServiceCollection services, Assembly assembly)
        {
            var types = assembly.GetTypes().Where(t => t.IsClass && !t.IsAbstract);
            foreach (Type? type in types)
            {
                var interfaces = type.GetInterfaces();
                foreach (var @interface in interfaces)
                {
                    services.AddScoped(@interface, type);
                }
            }
            return services;
        }
    }
}