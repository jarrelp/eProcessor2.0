namespace Ecmanage.eProcessor.Services.Fetch.Fetch.Application.Dtos;

public record OrderItemDto(Guid OrderId, Guid ProductId, int Quantity, decimal Price);
