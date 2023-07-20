namespace MediatRCQRS.ResponseModels.QueryResponseModels
{
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
