using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
///   Validator class for <see cref="SalesTaxRateCreateModel" /> .
/// </summary>
[RegisterSingleton<IValidator<SalesTaxRateCreateModel>>]
public class SalesTaxRateCreateModelValidator
  : AbstractValidator<SalesTaxRateCreateModel>
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="SalesTaxRateCreateModelValidator" /> class.
  /// </summary>
  public SalesTaxRateCreateModelValidator()
  {
    #region Generated Constructor

    RuleFor(p => p.Name).NotEmpty();
    RuleFor(p => p.Name).MaximumLength(50);

    #endregion
  }
}
