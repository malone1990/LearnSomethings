using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Serilog;

namespace MediatRCQRS.Webapi.newApp.Notifications;

public class ProductSavedNotificationHandler : INotificationHandler<ProductSavedNotification>
{
    public Task Handle(ProductSavedNotification notification, CancellationToken cancellationToken)
    {
        // 验证


        //可以调用其他处理程序


        //在数据库中插入记录

        return Task.Run(() => Log.Information($"Successful product event. Id: {notification.Id}"));
    }
}

public class ProductSavedNotification : INotification
{
    public Guid Id { get; set; }
}
