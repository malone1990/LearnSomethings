using MediatR;
using System.Diagnostics;

namespace MediatRCQRS.RequestModels
{
    //创建一个消息通知对象
    public class NotificationModel : INotification
    {
        public string Title { get; set; }
        public string Content { get; set; }

        public NotificationModel(string title, string content)
        {
            Title = title;
            Content = content;
        }
    }

    // 创建消息处理对象
    public class GeneralNotificationHandler : INotificationHandler<NotificationModel>
    {
        public Task Handle(NotificationModel notificationModel, CancellationToken cancellationToken)
        {
            Debug.WriteLine($"{notificationModel.Title} : {notificationModel.Content}");
            return Task.CompletedTask;
        }
    }
}
