namespace Ecmanage.eProcessor.Services.Fetch.Fetch.Domain.Events;

public record OrderUpdatedEvent(Order order) : IDomainEvent;
