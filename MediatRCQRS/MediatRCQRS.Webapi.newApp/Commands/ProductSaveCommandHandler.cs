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
    public class ProductSaveCommandHandler : IRequestHandler<ProductSaveCommand, bool>
    {
        private readonly IMediator _mediator;

        public ProductSaveCommandHandler(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<bool> Handle(ProductSaveCommand request, CancellationToken cancellationToken)
        {
            //生效

            //在数据库中插入产品
            Log.Information($"Product saved successfully. Id: {request.Id}");

            //同步发送通知
            await _mediator.Publish(new ProductSavedNotification { Id = request.Id }, cancellationToken);
            await _mediator.Publish(new SendEmailNotification { Email = "test@mail.com" }, cancellationToken);

            return await Task.FromResult(true);
        }
    }

    public class ProductSaveCommand : IRequest<bool>
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Description { get; set; }
    }
}
