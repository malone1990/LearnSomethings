﻿using MediatR;
using MediatRCQRS.Webapi.newApp.Notifications;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatRCQRS.Webapi.newApp.Commands
{
    public class NoReturnIRequestHandler : IRequestHandler<NoReturnIRequest>
    {
        private readonly IMediator _mediator;

        public NoReturnIRequestHandler(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task Handle(NoReturnIRequest request, CancellationToken cancellationToken)
        {
            //生效

            //在数据库中插入产品
            Log.Information($"Product saved successfully. Id: {request.Id}");

            //同步发送通知
            await _mediator.Publish(new ProductSavedNotification { Id = request.Id }, cancellationToken);
            await _mediator.Publish(new SendEmailNotification { Email = "test@mail.com" }, cancellationToken);

            await Task.FromResult(true);
        }
        
    }
    public class NoReturnIRequest : IRequest
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Description { get; set; }
    }
}
