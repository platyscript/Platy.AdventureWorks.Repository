using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
///   Validator class for <see cref="SalesPersonUpdateModel" /> .
/// </summary>
[RegisterSingleton<IValidator<SalesPersonUpdateModel>>]
public class SalesPersonUpdateModelValidator
  : AbstractValidator<SalesPersonUpdateModel>
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="SalesPersonUpdateModelValidator" /> class.
  /// </summary>
  public SalesPersonUpdateModelValidator()
  {
  }
}
