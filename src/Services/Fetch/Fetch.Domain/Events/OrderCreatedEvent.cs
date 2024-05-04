namespace Ecmanage.eProcessor.Services.Fetch.Fetch.Domain.Events;

public record OrderCreatedEvent(Order order) : IDomainEvent;
