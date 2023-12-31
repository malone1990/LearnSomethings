using System.IO;
using System.Threading;
using System.Threading.Tasks;
using MediatR.Pipeline;
using Serilog;

namespace MediatRCQRS.Webapi.Pipeline;

public class GenericRequestPreProcessor<TRequest> : IRequestPreProcessor<TRequest>
{

    public Task Process(TRequest request, CancellationToken cancellationToken)
    {
        return Task.Run(()=>Log.Information("- Starting Up"));
    }
}