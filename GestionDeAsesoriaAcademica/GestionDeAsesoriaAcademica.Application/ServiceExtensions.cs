using FluentValidation;
using GestionDeAsesoriaAcademica.Application.Behaviours;
using GestionDeAsesoriaAcademica.Application.Helpers;
using GestionDeAsesoriaAcademica.Application.Interfaces;
using GestionDeAsesoriaAcademica.Domain.Entities;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace GestionDeAsesoriaAcademica.Application
{
    public static class ServiceExtensions
    {
        public static void AddApplicationLayer(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));
            services.AddScoped<IDataShapeHelper<Position>, DataShapeHelper<Position>>();
            services.AddScoped<IDataShapeHelper<Employee>, DataShapeHelper<Employee>>();
            services.AddScoped<IModelHelper, ModelHelper>();
        }
    }
}