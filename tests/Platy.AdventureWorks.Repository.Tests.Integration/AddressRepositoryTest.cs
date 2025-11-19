using Ardalis.Result;
using Microsoft.Extensions.DependencyInjection;
using Platy.AdventureWorks.Repository.Domain.Models;
using Shouldly;

namespace Platy.AdventureWorks.Repository.Tests.Integration;

/// <summary>
///   Unit tests for the AddressRepository.
///   Methods should follow the naming convention:- [MethodWeTest_StateUnderTest_ExpectedBehavior]
///   [HTTPMethod]_[MethodName]_[StateUnderTest]_ThenTheAPIReturnsExpected[Http_Code]
/// </summary>
[Collection("Database collection")]
public class AddressRepositoryTest
{
  private readonly DatabaseFixture _fixture;
  private readonly ServiceProvider _serviceProvider;

  public AddressRepositoryTest(DatabaseFixture fixture)
  {
    _fixture = fixture;
    _serviceProvider = fixture.ServiceProvider;
  }

  [Fact]
  public async Task GetAsync_ValidAddressId_ReturnsValidAddress()
  {
    // Arrange
    var addressRepository = _serviceProvider.GetService<IAddressRepository>();

    // Act
    var addressReadModel = await addressRepository!.GetAsync(123, CancellationToken.None);

    // Assert
    addressReadModel.Value.Id.ShouldBe(123);
  }

  [Fact]
  private async Task CreateAsync_InvalidPostalCode_ReturnsValidationErrors()
  {
    // Arrange
    var addressRepository = _serviceProvider.GetService<IAddressRepository>();
    var readModel = await addressRepository!.GetAsync(1, CancellationToken.None);
    var newModel = new AddressCreateModel
    {
      AddressLine1 = readModel.Value.AddressLine2 + "test" + Random.Shared.NextInt64(),
      AddressLine2 = readModel.Value.AddressLine2 + "test" + Random.Shared.NextInt64(),
      City = readModel.Value.City + "test" + Random.Shared.NextInt64(),
      PostalCode = readModel.Value.PostalCode + "test" + Random.Shared.NextInt64(),
      StateProvinceId = readModel.Value.StateProvinceId
    };

    // Act
    var addressReadModel = await addressRepository.CreateAsync(newModel, CancellationToken.None);

    // Assert
    addressReadModel.IsInvalid().ShouldBe(true);
    addressReadModel.ValidationErrors.Count().ShouldBe(1);
  }

  [Fact]
  private async Task CreateAsync_ValidAddressValues_ReturnsSuccess()
  {
    // Arrange
    var addressRepository = _serviceProvider.GetService<IAddressRepository>();
    var readModel = await addressRepository!.GetAsync(1, CancellationToken.None);
    var newModel = new AddressCreateModel
    {
      AddressLine1 = readModel.Value.AddressLine2 + "test" + Random.Shared.NextInt64(),
      AddressLine2 = readModel.Value.AddressLine2 + "test" + Random.Shared.NextInt64(),
      City = readModel.Value.City + "test" + Random.Shared.NextInt64(),
      PostalCode = readModel.Value.PostalCode,
      StateProvinceId = readModel.Value.StateProvinceId
    };

    // Act
    var addressReadModel = await addressRepository.CreateAsync(newModel, CancellationToken.None);

    // Assert
    addressReadModel.IsInvalid().ShouldBe(false);
    addressReadModel.Errors.Count().ShouldBe(0);
    addressReadModel.Value.AddressLine1.ShouldBe(newModel.AddressLine1);
  }
}
