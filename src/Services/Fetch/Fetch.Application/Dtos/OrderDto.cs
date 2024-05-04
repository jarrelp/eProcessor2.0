using Ecmanage.eProcessor.Services.Fetch.Fetch.Domain.Enums;

namespace Ecmanage.eProcessor.Services.Fetch.Fetch.Application.Dtos;

public record OrderDto(
    Guid Id,
    Guid CustomerId,
    string OrderName,
    AddressDto ShippingAddress,
    AddressDto BillingAddress,
    PaymentDto Payment,
    OrderStatus Status,
    List<OrderItemDto> OrderItems);
