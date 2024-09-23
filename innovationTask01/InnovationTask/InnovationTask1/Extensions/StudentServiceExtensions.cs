using InnovationTask.Bll.Interface;
using InnovationTask.Bll.Repository;
using InnovationTask.DAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace InnovationTask1.Extensions
{
    public static class StudentServiceExtensions 
    {
        public static IServiceCollection AddStudentServices(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork,UnitOfWork>();
            return services;
        }
    }
}