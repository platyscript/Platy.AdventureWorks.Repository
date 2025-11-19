using Microsoft.EntityFrameworkCore.Diagnostics;
using Platy.AdventureWorks.Repository.Data;

namespace Platy.AdventureWorks.Repository.EfInterceptors;

/// <summary>
///   Intercepts SaveChanges to dispatch domain events after changes are successfully saved.
/// </summary>
/// <param name="domainEventDispatcher"></param>
[RegisterScoped]
public class EventDispatchInterceptor(IDomainEventDispatcher domainEventDispatcher) : SaveChangesInterceptor
{
  // Called after SaveChangesAsync has completed successfully
  public override async ValueTask<int> SavedChangesAsync(SaveChangesCompletedEventData eventData, int result,
    CancellationToken cancellationToken = new())
  {
    var context = eventData.Context;
    if (context is not AdventureWorksContext appDbContext)
    {
      return await base.SavedChangesAsync(eventData, result, cancellationToken).ConfigureAwait(false);
    }

    // Retrieve all tracked entities that have domain events
    var entitiesWithEvents = appDbContext.ChangeTracker.Entries<HasDomainEventsBase>()
      .Select(e => e.Entity)
      .Where(e => e.DomainEvents.Any())
      .ToArray();

    // Dispatch and clear domain events
    await domainEventDispatcher.DispatchAndClearEvents(entitiesWithEvents);

    return await base.SavedChangesAsync(eventData, result, cancellationToken);
  }
}
