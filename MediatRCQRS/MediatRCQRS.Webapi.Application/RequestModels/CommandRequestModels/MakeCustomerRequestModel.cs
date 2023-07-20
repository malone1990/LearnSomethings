using MediatRCQRS.ResponseModels.CommandResponseModels;
using MediatR;

namespace MediatRCQRS.RequestModels.CommandRequestModels
{
    //命令对象，也就是增加或者修改传入的模型，正常情况下可以增加验证的功能
    //请求需要继承IRequest<ResponseModel>,泛型里面是相应类
    public class MakeCustomerRequestModel : IRequest<MakeCustomerResponseModel>
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
