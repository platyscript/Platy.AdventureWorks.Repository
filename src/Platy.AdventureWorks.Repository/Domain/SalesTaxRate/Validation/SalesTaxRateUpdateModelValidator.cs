using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
///   Validator class for <see cref="SalesTaxRateUpdateModel" /> .
/// </summary>
[RegisterSingleton<IValidator<SalesTaxRateUpdateModel>>]
public class SalesTaxRateUpdateModelValidator
  : AbstractValidator<SalesTaxRateUpdateModel>
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="SalesTaxRateUpdateModelValidator" /> class.
  /// </summary>
  public SalesTaxRateUpdateModelValidator()
  {
    #region Generated Constructor

    RuleFor(p => p.Name).NotEmpty();
    RuleFor(p => p.Name).MaximumLength(50);

    #endregion
  }
}
