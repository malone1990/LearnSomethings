using CqrsMediatrExample.DataStore;
using MediatRCQRS.Webapi.Core;
using Serilog;

internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.AddSerilog("Api  MediatR & CQRS");

            // Add services to the container.

            builder.Services.AddSingleton<FakeDataStore>();
            builder.Services.AddRouting(options => options.LowercaseUrls = true);
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddMassTransitExtension();



            builder.Services.AddMediatR();

            var app = builder.Build();

            // Configure the HTTP request pipeline.

            app.UseHttpsRedirection();

            app.MapControllers();

            app.Run();
        }
        catch (Exception ex)
        {
            Log.Fatal(ex, "Host terminated unexpectedly");
        }
        finally
        {
            Log.Information("Server Shutting down...");
            Log.CloseAndFlush();
        }

    }
}
