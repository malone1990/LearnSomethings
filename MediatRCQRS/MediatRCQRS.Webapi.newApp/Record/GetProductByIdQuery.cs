using MediatR;
using MediatRCQRS.Webapi.newApp.Record;

namespace MediatRCQRS.Webapi.newApp.Record
{
    public record GetProductByIdQuery(int Id) : IRequest<Product>;
}
