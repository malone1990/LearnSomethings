namespace MediatRCQRS.ResponseModels.CommandResponseModels
{
    //命令对象，返回主键ID，和是否查询成功
    public class MakeCustomerResponseModel
    {
        public bool IsSuccess { get; set; }
        public Guid CustomerId { get; set; }
    }
}
