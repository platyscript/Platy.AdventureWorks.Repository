using MediatR;
using Platy.AdventureWorks.Repository.Data;
using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.EfInterceptors;

namespace Platy.AdventureWorks.Repository;

public static class AdventureWorksRepositoryRegistration
{
  /// <summary>
  ///   Adds the repository classes required for interacting with the  AdventureWorks database.
  ///   Adds the mediatr(notification) events that get dispatched for every CRUO domain event.
  /// </summary>
  /// <param name="services">The IServiesCollection</param>
  /// <param name="connectionString">The connection string of the database</param>
  /// <returns></returns>
  public static IServiceCollection AddAdventureWorkDatabase(this IServiceCollection services,
    string connectionString)
  {
    // The services added by using the Injectio library. 
    services.AddPlatyAdventureWorksRepository();

    // Add the DbContext
    services.AddDbContext<AdventureWorksContext>((provider, options) =>
    {
      options.UseSqlServer(connectionString)
        .AddInterceptors(provider.GetRequiredService<EventDispatchInterceptor>());
    });

    // Add the mediatr libraries that publish the domain related events.
    var mediatRAssemblies = new[]
    {
      Assembly.GetAssembly(typeof(Address)) // Core
    };

    services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(mediatRAssemblies!))
      .AddScoped(typeof(IPipelineBehavior<,>), typeof(LoggingBehavior<,>))
      .AddScoped<IDomainEventDispatcher, MediatRDomainEventDispatcher>();

    services.AddLogging();
    return services;
  }
}
