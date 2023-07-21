using MediatR;
using MediatRCQRS.Webapi.Application.Handlers.QueryHandlers;
using MediatRCQRS.Webapi.newApp.Commands;
using MediatRCQRS.Webapi.newApp.Queries;
using MediatRCQRS.Webapi.newApp.Record;
using Microsoft.AspNetCore.Mvc;

namespace MediatRCQRS.Controller
{
    [Route("[controller]")]
    [ApiController]
    public class QueriesController : ControllerBase
    {
        IMediator _mediator;
       public QueriesController(IMediator mediator) => _mediator = mediator;

        //在ASP.NET Core应用程序中，接收表单数据应该使用[FromForm]特性，而不是[FromBody]特性，

        // 如果想要在控制器中使用[FromBody] 特性，那么你的请求头信息中Content-Type必须是application/json
        [HttpGet]
        public async Task<IActionResult> QueryById([FromQuery] ProductByIdQuery product) //FromBody 导致 415 (Unsupported Media Type)问题
        {
            var response = await _mediator.Send(product);
            return Ok(response);
        }


        [HttpGet("record/{id:int}", Name = "GetProductById")]//{id:int}
        public async Task<ActionResult> GetProductById(int id)
        {
            var product = await _mediator.Send(new GetProductByIdQuery(id));

            return Ok(product);
        }

        [HttpPost]
        public async Task<IActionResult> Save([FromBody] NoReturnIRequest product)
        {
            await _mediator.Send(product);
            return Ok();
        }  
    }
}
