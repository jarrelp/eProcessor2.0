using MediatR;

namespace Ecmanage.eProcessor.Services.Fetch.Fetch.Domain.Abstractions;
public interface IDomainEvent : INotification
{
    Guid EventId => Guid.NewGuid();
    public DateTime OccurredOn => DateTime.Now;
    public string? EventType => GetType().AssemblyQualifiedName;
}
