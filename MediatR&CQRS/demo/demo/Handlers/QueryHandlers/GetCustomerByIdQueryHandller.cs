﻿using demo.RequestModels.QueryRequestModels;
using demo.ResponseModels.QueryResponseModels;
using MediatR;

namespace demo.Handlers.QueryHandlers
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
