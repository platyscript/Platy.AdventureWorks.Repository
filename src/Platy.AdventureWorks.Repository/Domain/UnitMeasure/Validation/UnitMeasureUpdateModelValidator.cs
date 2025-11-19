using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
///   Validator class for <see cref="UnitMeasureUpdateModel" /> .
/// </summary>
[RegisterSingleton<IValidator<UnitMeasureUpdateModel>>]
public class UnitMeasureUpdateModelValidator
  : AbstractValidator<UnitMeasureUpdateModel>
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="UnitMeasureUpdateModelValidator" /> class.
  /// </summary>
  public UnitMeasureUpdateModelValidator()
  {
    #region Generated Constructor

    RuleFor(p => p.UnitMeasureCode).NotEmpty();
    RuleFor(p => p.UnitMeasureCode).MaximumLength(3);
    RuleFor(p => p.Name).NotEmpty();
    RuleFor(p => p.Name).MaximumLength(50);

    #endregion
  }
}
