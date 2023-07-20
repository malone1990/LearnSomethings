using MediatRCQRS.RequestModels.QueryRequestModels;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddControllers();
        builder.Services.AddMediatR(Assembly.GetExecutingAssembly());


        var app = builder.Build();

        // Configure the HTTP request pipeline.

        app.UseHttpsRedirection();

        app.MapControllers();

        app.Run();
    }
}
