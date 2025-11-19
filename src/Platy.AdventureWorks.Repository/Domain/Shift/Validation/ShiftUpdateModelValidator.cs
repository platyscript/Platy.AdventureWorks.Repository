using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
///   Validator class for <see cref="ShiftUpdateModel" /> .
/// </summary>
[RegisterSingleton<IValidator<ShiftUpdateModel>>]
public class ShiftUpdateModelValidator
  : AbstractValidator<ShiftUpdateModel>
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="ShiftUpdateModelValidator" /> class.
  /// </summary>
  public ShiftUpdateModelValidator()
  {
    #region Generated Constructor

    RuleFor(p => p.Name).NotEmpty();
    RuleFor(p => p.Name).MaximumLength(50);

    #endregion
  }
}
