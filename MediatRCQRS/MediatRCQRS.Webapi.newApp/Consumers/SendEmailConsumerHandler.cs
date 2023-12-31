using MassTransit;
using MediatR;
using MediatRCQRS.Webapi.newApp.Commands;

namespace MediatRCQRS.Webapi.newApp.Consumers;

public class SendEmailConsumerHandler : IConsumer<SendEmailEvent>
{
    private readonly IMediator _mediator;

    public SendEmailConsumerHandler(IMediator mediator)
    {
        _mediator = mediator;
    }

    public Task Consume(ConsumeContext<SendEmailEvent> context)
    {
        // 验证



        //可以调用其他处理程序



        //在数据库中插入记录

        _mediator.Send(new ProductSaveCommand { Description = "teste" });
        return Task.CompletedTask;
    }
}

public class SendEmailEvent
{
    public string Email { get; set; }
}

public class SendEmailConsumerHandlerDefinition : ConsumerDefinition<SendEmailConsumerHandler>
{
    protected override void ConfigureConsumer(IReceiveEndpointConfigurator endpointConfigurator, IConsumerConfigurator<SendEmailConsumerHandler> consumerConfigurator)
    {
        consumerConfigurator.UseMessageRetry(retry => retry.Interval(3, TimeSpan.FromSeconds(3)));
    }
}
