using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
///   Validator class for <see cref="VProductModelInstructionsUpdateModel" /> .
/// </summary>
[RegisterSingleton<IValidator<VProductModelInstructionsUpdateModel>>]
public class VProductModelInstructionsUpdateModelValidator
  : AbstractValidator<VProductModelInstructionsUpdateModel>
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="VProductModelInstructionsUpdateModelValidator" /> class.
  /// </summary>
  public VProductModelInstructionsUpdateModelValidator()
  {
    #region Generated Constructor

    RuleFor(p => p.Name).NotEmpty();
    RuleFor(p => p.Name).MaximumLength(50);
    RuleFor(p => p.Step).MaximumLength(1024);

    #endregion
  }
}
