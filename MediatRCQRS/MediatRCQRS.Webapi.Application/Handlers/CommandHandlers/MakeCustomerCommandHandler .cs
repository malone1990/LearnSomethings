using MediatRCQRS.RequestModels.CommandRequestModels;
using MediatRCQRS.ResponseModels.CommandResponseModels;
using MediatR;

namespace MediatRCQRS.Handlers.CommandHandlers
{
    //命令处理，需要继承IRequestHandler泛型，和实现Handle方法，如下
    public class MakeCustomerCommandHandler : IRequestHandler<MakeCustomerRequestModel, MakeCustomerResponseModel>
    {
        public Task<MakeCustomerResponseModel> Handle(MakeCustomerRequestModel request, CancellationToken cancellationToken)
        {
            var result = new MakeCustomerResponseModel
            {
                IsSuccess = true,
                CustomerId = new Guid("4ED8843E-7718-40D1-B8E0-B813FE4E0A68")
            };
            // 业务逻辑
            return Task.FromResult(result);
        }
    }
}
