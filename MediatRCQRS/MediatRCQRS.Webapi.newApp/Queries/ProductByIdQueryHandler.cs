﻿using MediatR;
using Serilog;

namespace MediatRCQRS.Webapi.newApp.Queries
{
    public class ProductByIdQueryHandler : IRequestHandler<ProductByIdQuery, ProductByIdQueryResult>
    {
        public async Task<ProductByIdQueryResult> Handle(ProductByIdQuery request, CancellationToken cancellationToken)
        {
            Log.Information("Query performed successfully");

            return await Task.FromResult(new ProductByIdQueryResult { Id = request.Id, Description = $"Description {request.Id}" });
        }
    }
    //查询对象，可以通过id等去查询
    //请求需要继承IRequest<ResponseModel>,泛型里面是相应类
    public class ProductByIdQuery : IRequest<ProductByIdQueryResult>
    {
        public long Id { get; set; }
    }
    //查询对象，返回查询的数据，刚好与前面相反
    public class ProductByIdQueryResult
    {
        public long Id { get; set; }
        public string Description { get; set; }
    }
}
