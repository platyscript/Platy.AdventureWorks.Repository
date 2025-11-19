using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
///   Validator class for <see cref="BusinessEntityAddressCreateModel" /> .
/// </summary>
[RegisterSingleton<IValidator<BusinessEntityAddressCreateModel>>]
public class BusinessEntityAddressCreateModelValidator
  : AbstractValidator<BusinessEntityAddressCreateModel>
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="BusinessEntityAddressCreateModelValidator" /> class.
  /// </summary>
  public BusinessEntityAddressCreateModelValidator()
  {
  }
}
