using MediatR;
using Serilog;

namespace MediatRCQRS.Webapi.newApp;

public class GenericHandler : INotificationHandler<INotification>
{

    public Task Handle(INotification notification, CancellationToken cancellationToken)
    {
        Console.WriteLine("Got notified.");
        
        return Task.Run(()=> Log.Information("Got notified."));
    }
}