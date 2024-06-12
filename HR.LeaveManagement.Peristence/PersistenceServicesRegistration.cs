using System;
using System.Collections.Generic;
using System.Text;
using Hr.LeaveManagement.Application.Persistence.Contracts;
using HR.LeaveManagement.Peristence.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace HR.LeaveManagement.Peristence
{
    public static class PersistenceServicesRegistration
    {
        public static IServiceCollection ConfigurePersistenceServices(this IServiceCollection services,
            IConfiguration configuration)
        {
            //services.AddDbContext<LeaveManagementDbContext>(options =>
            //    options.UseSqlServer(
            //        configuration.GetConnectionString("LeaveManagementConnectionString")));


            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

            services.AddScoped<ILeaveRequestRepository, LeaveRequestRepository>();
            services.AddScoped<ILeaveAllocationRepository, LeaveAllocationRepository>();

            return services;
        }
    }
}
