﻿using MediatR.Pipeline;
using MediatR;
using MediatRCQRS.Webapi.Application.Handlers.QueryHandlers;
using MediatRCQRS.Webapi.newApp.Queries;
using Microsoft.Extensions.DependencyInjection;
using MediatRCQRS.Webapi.Pipeline;

namespace MediatRCQRS.Webapi.Core
{
    public static class MediatrExtension
    {
        public static void AddMediatR(this IServiceCollection services)
        {
            // builder.Services.AddMediatR(Assembly.GetExecutingAssembly()); // MediatR 11.1.0
            // Assembly.Load("MediatRCQRS.Webapi.Application")
            services.AddMediatR(configuration => { 
                configuration.RegisterServicesFromAssemblyContaining<GetCustomerByIdQueryHandller>();
                configuration.RegisterServicesFromAssemblyContaining<ProductByIdQueryHandler>();
            }); ;
            
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(GenericPipelineBehavior<,>));

            //注入IRequestPreProcessor、IRequestPostProcessor不起作用
            services.AddTransient(typeof(IRequestPreProcessor<>), typeof(GenericRequestPreProcessor<>));
            services.AddTransient(typeof(IRequestPostProcessor<,>), typeof(GenericRequestPostProcessor<,>));
        }
    }
}