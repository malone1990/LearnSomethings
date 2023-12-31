﻿using MediatR;
using MediatRCQRS.RequestModels;
using MediatRCQRS.RequestModels.CommandRequestModels;
using MediatRCQRS.Webapi.Application.Handlers.QueryHandlers;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MediatRCQRS.Controller
{
    [Route("[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {      
        private readonly IMediator _mediator;
        public CustomerController(IMediator mediator) => _mediator = mediator;
        /*
         　a.IRequest、IRequest<T> 只有一个单独的Handler执行
　　      b.Notification，用于多个Handler。

　　      对于每个 request 类型，都有相应的 handler 接口：

            IRequestHandler<T, U> 实现该接口并返回 Task<U>
            RequestHandler<T, U> 继承该类并返回 U
            IRequestHandler<T> 实现该接口并返回 Task<Unit>
            AsyncRequestHandler<T> 继承该类并返回 Task
            RequestHandler<T> 继承该类不返回
　　      Notification
　　        Notification 就是通知，调用者发出一次，然后可以有多个处理者参与处理。
　　        Notification 消息的定义很简单，只需要让你的类继承一个空接口 INotification 即可。而处理程序则实现 INotificationHandler<T> 接口的 Handle 方法
         */
        #region Old code
        [HttpPost]
        public async Task<IActionResult> MakeCustomer([FromBody] MakeCustomerRequestModel requestModel)
        {
            //IRequest、IRequest<T>：命令查询 | 处理类所继承的接口，一个有返回类型，一个无返回类型，一个查询对应一个处理类，程序集只认第一个扫描到的类。
            var response = await _mediator.Send(requestModel);
            return Ok(response);
        }

        [HttpGet]
        public IActionResult CustomerDetails(int id)
        {
            var response = _mediator.Send(new GetCustomerByIdRequestModel { CustomerId = id }).Result;          
            return Ok(response);
        }

        [HttpPost("public")]
        public async Task Publics(string message)
        {
            //广播，订阅（继承INotificationHandler）的均能收到，Handle 方法中处理
            await _mediator.Publish(new NotificationModel("Ttile", message));
        }

        #endregion
    }
}
