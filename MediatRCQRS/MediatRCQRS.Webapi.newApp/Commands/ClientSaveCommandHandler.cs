﻿using MassTransit;
using MediatR;
using MediatRCQRS.Webapi.newApp.Consumers;
using Serilog;

namespace MediatRCQRS.Webapi.newApp.Commands
{
    public class ClientSaveCommandHandler : IRequestHandler<ClientSaveCommand, bool>
    {
        private readonly IPublishEndpoint _publish;

        public ClientSaveCommandHandler(IPublishEndpoint publish)
        {
            _publish = publish;
        }

        public async Task<bool> Handle(ClientSaveCommand request, CancellationToken cancellationToken)
        {
            //validações

            //insert product in database
            Log.Information($"Client saved successfully. Id: {request.Id}");

            //envia notificação de forma assíncrona
            await _publish.Publish(new SendEmailEvent { Email = "teste@email.com" }, cancellationToken);

            return await Task.FromResult(true);
        }
    }

    public class ClientSaveCommand : IRequest<bool>
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Description { get; set; }
    }
}
