using MediatRCQRS.RequestModels;
using MediatRCQRS.RequestModels.CommandRequestModels;
using MediatRCQRS.RequestModels.QueryRequestModels;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MediatRCQRS.Controller
{
    [Route("[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IMediator _mediator;
        public CustomerController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        public IActionResult MakeCustomer([FromBody] MakeCustomerRequestModel requestModel)
        {
            var response = _mediator.Send(requestModel).Result;
            return Ok(response);
        }

        [HttpGet]
        public IActionResult CustomerDetails(int id)
        {
            var response = _mediator.Send(new GetCustomerByIdRequestModel { CustomerId = id }).Result;
            // var response = _mediator.Publish(new NotificationModel("Ttile","test"));
            return Ok(response);
        }
    }
}
