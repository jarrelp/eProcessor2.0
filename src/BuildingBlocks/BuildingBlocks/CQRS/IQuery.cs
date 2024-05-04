using MediatR;

namespace Ecmanage.eProcessor.BuildingBlocks.BuildingBlocks.CQRS;
public interface IQuery<out TResponse> : IRequest<TResponse>
    where TResponse : notnull
{
}
