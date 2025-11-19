using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
///   Validator class for <see cref="CultureCreateModel" /> .
/// </summary>
[RegisterSingleton<IValidator<CultureCreateModel>>]
public class CultureCreateModelValidator
  : AbstractValidator<CultureCreateModel>
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="CultureCreateModelValidator" /> class.
  /// </summary>
  public CultureCreateModelValidator()
  {
    #region Generated Constructor

    RuleFor(p => p.Id).NotEmpty();
    RuleFor(p => p.Id).MaximumLength(6);
    RuleFor(p => p.Name).NotEmpty();
    RuleFor(p => p.Name).MaximumLength(50);

    #endregion
  }
}
