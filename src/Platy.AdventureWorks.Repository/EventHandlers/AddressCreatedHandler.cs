using MediatR;
using Platy.AdventureWorks.Repository.Events;

namespace Platy.AdventureWorks.Repository.EventHandlers;

internal class AddressCreatedHandler : INotificationHandler<AddressCreatedEvent>
{
  public Task Handle(AddressCreatedEvent notification, CancellationToken cancellationToken)
  {
    return Task.CompletedTask;
  }
}
