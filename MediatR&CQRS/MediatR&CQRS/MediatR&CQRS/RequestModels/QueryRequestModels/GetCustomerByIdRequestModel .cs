using MediatRCQRS.ResponseModels.QueryResponseModels;
using MediatR;

namespace MediatRCQRS.RequestModels.QueryRequestModels
{
    //查询对象，可以通过id等去查询
    //请求需要继承IRequest<ResponseModel>,泛型里面是相应类
    public class GetCustomerByIdRequestModel : IRequest<GetCustomerByIdResponseModel>
    {
        public int CustomerId { get; set; }
    }
}
