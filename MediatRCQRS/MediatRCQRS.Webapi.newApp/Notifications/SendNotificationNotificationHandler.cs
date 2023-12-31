using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Serilog;

namespace MediatRCQRS.Webapi.newApp.Notifications;

public class SendNotificationNotificationHandler : INotificationHandler<SendEmailNotification>
{
    public Task Handle(SendEmailNotification notification, CancellationToken cancellationToken)
    {
        // 验证

        //可以调用其他处理程序

        //在数据库中插入记录

        return Task.Run(() => Log.Information($"Successful email event. To: {notification.Email}"));
    }
}

public class SendEmailNotification : INotification
{
    public string Email { get; set; }
}
