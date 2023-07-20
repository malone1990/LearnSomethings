using MediatRCQRS.RequestModels.QueryRequestModels;
using MediatRCQRS.ResponseModels.QueryResponseModels;
using MediatR;

namespace MediatRCQRS.Handlers.QueryHandlers
{
    public class GetCustomerByIdQueryHandller : IRequestHandler<GetCustomerByIdRequestModel, GetCustomerByIdResponseModel>
    {
        public Task<GetCustomerByIdResponseModel> Handle(GetCustomerByIdRequestModel request, CancellationToken cancellationToken)
        {
            var result = new GetCustomerByIdResponseModel();

            return Task.FromResult(result);
        }
    }
}
