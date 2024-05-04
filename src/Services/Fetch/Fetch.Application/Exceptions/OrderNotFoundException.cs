using Ecmanage.eProcessor.BuildingBlocks.BuildingBlocks.Exceptions;

namespace Ecmanage.eProcessor.Services.Fetch.Fetch.Application.Exceptions;
public class OrderNotFoundException : NotFoundException
{
    public OrderNotFoundException(Guid id) : base("Order", id)
    {
    }
}
