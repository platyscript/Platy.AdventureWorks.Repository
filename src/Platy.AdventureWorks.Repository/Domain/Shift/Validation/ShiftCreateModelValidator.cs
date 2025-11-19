using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
///   Validator class for <see cref="ShiftCreateModel" /> .
/// </summary>
[RegisterSingleton<IValidator<ShiftCreateModel>>]
public class ShiftCreateModelValidator
  : AbstractValidator<ShiftCreateModel>
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="ShiftCreateModelValidator" /> class.
  /// </summary>
  public ShiftCreateModelValidator()
  {
    #region Generated Constructor

    RuleFor(p => p.Name).NotEmpty();
    RuleFor(p => p.Name).MaximumLength(50);

    #endregion
  }
}
