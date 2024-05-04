using Ecmanage.eProcessor.BuildingBlocks.BuildingBlocks.CQRS;
using FluentValidation;
using Ecmanage.eProcessor.Services.Fetch.Fetch.Application.Dtos;

namespace Ecmanage.eProcessor.Services.Fetch.Fetch.Application.Orders.Commands.UpdateOrder;
public record UpdateOrderCommand(OrderDto Order)
    : ICommand<UpdateOrderResult>;

public record UpdateOrderResult(bool IsSuccess);

public class UpdateOrderCommandValidator : AbstractValidator<UpdateOrderCommand>
{
    public UpdateOrderCommandValidator()
    {
        RuleFor(x => x.Order.Id).NotEmpty().WithMessage("Id is required");
        RuleFor(x => x.Order.OrderName).NotEmpty().WithMessage("Name is required");
        RuleFor(x => x.Order.CustomerId).NotNull().WithMessage("CustomerId is required");
    }
}

