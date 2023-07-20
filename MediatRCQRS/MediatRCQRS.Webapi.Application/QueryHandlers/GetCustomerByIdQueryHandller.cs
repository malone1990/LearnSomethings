using MediatR;

namespace MediatRCQRS.Application.QueryHandlers
{
    public class GetCustomerByIdQueryHandller : IRequestHandler<GetCustomerByIdRequestModel, GetCustomerByIdResponseModel>
    {
        public Task<GetCustomerByIdResponseModel> Handle(GetCustomerByIdRequestModel request, CancellationToken cancellationToken)
        {
            var result = new GetCustomerByIdResponseModel();

            return Task.FromResult(result);
        }
    }

    //查询对象，可以通过id等去查询
    //请求需要继承IRequest<ResponseModel>,泛型里面是相应类
    public class GetCustomerByIdRequestModel : IRequest<GetCustomerByIdResponseModel>
    {
        public int CustomerId { get; set; }
    }

    //查询对象，返回查询的数据，刚好与前面相反
    public class GetCustomerByIdResponseModel
    {
        public Guid CustomerId { get; set; } = new Guid();
        public string CustomerName { get; set; }
        public Guid BlongId { get; set; }
        public int Quantity { get; set; }
        public double Amount { get; set; }
        public string Phone { get; set; }
        public DateTime CreatTime { get; set; } = DateTime.Now;
    }
}
