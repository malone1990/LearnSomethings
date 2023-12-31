using MediatR;
using Serilog;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace MediatRCQRS.Webapi.Pipeline;

public class GenericPipelineBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
{

    public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
    {
        Log.Information("-- Handling Request");
        var response = await next();
        Log.Information("-- Finished Request");
        return response;
    }
}