using AutoMapper;
using DotNet.Testcontainers.Builders;
using DotNet.Testcontainers.Images;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Platy.AdventureWorks.Repository.Domain.Mapping;
using Testcontainers.MsSql;

namespace Platy.AdventureWorks.Repository.Tests.Integration;

public class DatabaseFixture : IDisposable
{
  private IFutureDockerImage? _msSqlImage;
  private MsSqlContainer? _msSqlContainer;

  public DatabaseFixture()
  {
    
    // 1. Start the container in docker using the image chriseaton/adventureworks:lates.
    var msSqlContainer = new MsSqlBuilder()
      .WithImage("chriseaton/adventureworks:latest")
      .WithEnvironment("MSSQL_SA_PASSWORD", "Test123Test*")
      .WithEnvironment("ACCEPT_EULA","Y")
      .WithPortBinding(1433,1433)
      .WithName("adventure-works-db")
      .WithWaitStrategy(Wait.ForUnixContainer().UntilMessageIsLogged("Server is ready."))
      .Build();
    msSqlContainer.StartAsync().ConfigureAwait(false).GetAwaiter().GetResult();
    
    // 1. Create the image and then Start the container in docker using the Dockerfile.
    
    // _msSqlImage = new ImageFromDockerfileBuilder()
    //   .WithDockerfileDirectory(CommonDirectoryPath.GetSolutionDirectory(), "docker")
    //   .WithDockerfile("Dockerfile")
    //   .WithName("platy.repository.tests/adventure-works-db:0.0.1")
    //   .WithCleanUp(true)
    //   .WithDeleteIfExists(true)
    //   .WithBuildArgument("BAK_FILE", "AdventureWorks2022.bak")
    //   .Build();
    // _msSqlImage.CreateAsync().ConfigureAwait(false).GetAwaiter().GetResult();
    // _msSqlContainer = new MsSqlBuilder()
    //   .WithImage("platy.repository.tests/adventure-works-db:0.0.1")
    //   .WithEnvironment("MSSQL_SA_PASSWORD", "Test123Test*")
    //   .WithEnvironment("ACCEPT_EULA","Y")
    //   .WithCleanUp(true)
    //   .WithPortBinding(1433,1433)
    //   .WithName("adventure-works-db")
    //   .WithWaitStrategy(Wait.ForUnixContainer().UntilMessageIsLogged("Server is ready."))
    //   .Build();
    // _msSqlContainer.StartAsync().ConfigureAwait(false).GetAwaiter().GetResult();
    
    // 2. Get the connection string from user secrets
    var config = new ConfigurationBuilder()
      .AddUserSecrets<AddressRepositoryTest>()
      .Build();
    
    var connectionString = $"{config["AdventureWorksDb"]}";

    if (string.IsNullOrEmpty(connectionString))
    {
      connectionString = Environment.GetEnvironmentVariable("ADVENTUREWORKSDB");
    }
    
    // 3. Add the adventureworks database to the service collection
    var serviceCollection = new ServiceCollection();
    serviceCollection.AddAdventureWorkDatabase(connectionString);

    // 4. Create the mapper configuration for the assembly
    serviceCollection.AddAutoMapper(cfg => { }, typeof(AddressProfile));

    ServiceProvider = serviceCollection.BuildServiceProvider();
  }

  public ServiceProvider ServiceProvider { get; set; }

  public void Dispose()
  {
  }
}
