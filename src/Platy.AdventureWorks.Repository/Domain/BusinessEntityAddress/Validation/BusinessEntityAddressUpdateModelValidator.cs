using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
///   Validator class for <see cref="BusinessEntityAddressUpdateModel" /> .
/// </summary>
[RegisterSingleton<IValidator<BusinessEntityAddressUpdateModel>>]
public class BusinessEntityAddressUpdateModelValidator
  : AbstractValidator<BusinessEntityAddressUpdateModel>
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="BusinessEntityAddressUpdateModelValidator" /> class.
  /// </summary>
  public BusinessEntityAddressUpdateModelValidator()
  {
  }
}
