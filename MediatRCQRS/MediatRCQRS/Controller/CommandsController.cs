﻿using MediatR;
using MediatRCQRS.Webapi.newApp.Commands;
using Microsoft.AspNetCore.Mvc;

namespace MediatRCQRS.Webapi.Controller
{
    [ApiController]
    [Route("[controller]")]
    public class CommandsController : ControllerBase
    {
        //CQRS（Command Query Responsibility Segregation）命令查询的责任分离。
        //QRS本质上是一种读写分离设计思想，这种框架设计模式将命令型业务和查询型业务分开单独处理。
        //我们运用MediatR就可以轻松的实现CQRS。
        private readonly IMediator _mediator;
        public CommandsController(IMediator mediator) => _mediator = mediator;

        [HttpPost("product")]
        public async Task<IActionResult> PostProductAsync([FromBody] ProductSaveCommand product)
        {
            var command = await _mediator.Send(product);

            return command?Ok(command) : BadRequest(command);
        }

        [HttpPost("client")]
        public async Task<IActionResult> PostClientAsync([FromBody] ClientSaveCommand client)
        {
            var command = await _mediator.Send(client);

            return command ? Ok(command) : BadRequest(command);
        }
    }
}
