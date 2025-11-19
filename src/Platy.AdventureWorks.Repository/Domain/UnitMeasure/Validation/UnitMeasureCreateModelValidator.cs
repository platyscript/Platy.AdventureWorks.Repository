using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
///   Validator class for <see cref="UnitMeasureCreateModel" /> .
/// </summary>
[RegisterSingleton<IValidator<UnitMeasureCreateModel>>]
public class UnitMeasureCreateModelValidator
  : AbstractValidator<UnitMeasureCreateModel>
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="UnitMeasureCreateModelValidator" /> class.
  /// </summary>
  public UnitMeasureCreateModelValidator()
  {
    #region Generated Constructor

    RuleFor(p => p.UnitMeasureCode).NotEmpty();
    RuleFor(p => p.UnitMeasureCode).MaximumLength(3);
    RuleFor(p => p.Name).NotEmpty();
    RuleFor(p => p.Name).MaximumLength(50);

    #endregion
  }
}
