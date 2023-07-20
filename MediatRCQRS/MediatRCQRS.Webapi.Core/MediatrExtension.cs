using MediatRCQRS.Webapi.Application.QueryHandlers;
using Microsoft.Extensions.DependencyInjection;

namespace MediatRCQRS.Webapi.Core
{
    public static class MediatrExtension
    {
        public static void AddMediatR(this IServiceCollection services)
        {
            // builder.Services.AddMediatR(Assembly.GetExecutingAssembly()); // MediatR 11.1.0
            // Assembly.Load("MediatRCQRS.Webapi.Application")
            services.AddMediatR(configuration => configuration.RegisterServicesFromAssemblyContaining<ProductByIdQueryHandler>());
        }
    }
}