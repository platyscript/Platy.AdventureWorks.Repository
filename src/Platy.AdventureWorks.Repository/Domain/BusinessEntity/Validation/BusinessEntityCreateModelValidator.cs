using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
///   Validator class for <see cref="BusinessEntityCreateModel" /> .
/// </summary>
[RegisterSingleton<IValidator<BusinessEntityCreateModel>>]
public class BusinessEntityCreateModelValidator
  : AbstractValidator<BusinessEntityCreateModel>
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="BusinessEntityCreateModelValidator" /> class.
  /// </summary>
  public BusinessEntityCreateModelValidator()
  {
  }
}
