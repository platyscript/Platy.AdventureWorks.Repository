using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
///   Validator class for <see cref="CustomerUpdateModel" /> .
/// </summary>
[RegisterSingleton<IValidator<CustomerUpdateModel>>]
public class CustomerUpdateModelValidator
  : AbstractValidator<CustomerUpdateModel>
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="CustomerUpdateModelValidator" /> class.
  /// </summary>
  public CustomerUpdateModelValidator()
  {
  }
}
