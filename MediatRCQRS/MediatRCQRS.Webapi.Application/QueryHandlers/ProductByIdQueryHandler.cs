﻿using MediatR;
using Serilog;

namespace MediatRCQRS.Webapi.Application.QueryHandlers
{
    public class ProductByIdQueryHandler : IRequestHandler<ProductByIdQuery, ProductByIdQueryResult>
    {
        public async Task<ProductByIdQueryResult> Handle(ProductByIdQuery request, CancellationToken cancellationToken)
        {
            Log.Information("Query performed successfully");

            return await Task.FromResult(new ProductByIdQueryResult { Id = request.Id, Description = $"Description {request.Id}" });
        }
    }

    public class ProductByIdQuery : IRequest<ProductByIdQueryResult>
    {
        public long Id { get; set; }
    }

    public class ProductByIdQueryResult
    {
        public long Id { get; set; }
        public string Description { get; set; }
    }
}
