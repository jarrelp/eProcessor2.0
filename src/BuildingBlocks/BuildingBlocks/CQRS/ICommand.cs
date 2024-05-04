using MediatR;

namespace Ecmanage.eProcessor.BuildingBlocks.BuildingBlocks.CQRS;

public interface ICommand : ICommand<Unit>
{
}

public interface ICommand<out TResponse> : IRequest<TResponse>
{
}
