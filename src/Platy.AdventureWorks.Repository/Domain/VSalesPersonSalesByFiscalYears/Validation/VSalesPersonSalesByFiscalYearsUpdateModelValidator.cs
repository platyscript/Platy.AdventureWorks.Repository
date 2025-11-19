using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
///   Validator class for <see cref="VSalesPersonSalesByFiscalYearsUpdateModel" /> .
/// </summary>
[RegisterSingleton<IValidator<VSalesPersonSalesByFiscalYearsUpdateModel>>]
public class VSalesPersonSalesByFiscalYearsUpdateModelValidator
  : AbstractValidator<VSalesPersonSalesByFiscalYearsUpdateModel>
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="VSalesPersonSalesByFiscalYearsUpdateModelValidator" /> class.
  /// </summary>
  public VSalesPersonSalesByFiscalYearsUpdateModelValidator()
  {
    #region Generated Constructor

    RuleFor(p => p.FullName).MaximumLength(152);
    RuleFor(p => p.JobTitle).NotEmpty();
    RuleFor(p => p.JobTitle).MaximumLength(50);
    RuleFor(p => p.SalesTerritory).NotEmpty();
    RuleFor(p => p.SalesTerritory).MaximumLength(50);

    #endregion
  }
}
