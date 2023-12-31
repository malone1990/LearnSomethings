using System.IO;
using System.Threading;
using System.Threading.Tasks;
using MediatR.Pipeline;
using Serilog;

namespace MediatRCQRS.Webapi.Pipeline;

public class GenericRequestPostProcessor<TRequest, TResponse> : IRequestPostProcessor<TRequest, TResponse>
{

    public Task Process(TRequest request, TResponse response, CancellationToken cancellationToken)
    {
        return Task.Run(()=>Log.Information("- All Done"));
    }
}