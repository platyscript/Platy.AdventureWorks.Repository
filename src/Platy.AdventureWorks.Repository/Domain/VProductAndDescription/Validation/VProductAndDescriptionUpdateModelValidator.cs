using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
///   Validator class for <see cref="VProductAndDescriptionUpdateModel" /> .
/// </summary>
[RegisterSingleton<IValidator<VProductAndDescriptionUpdateModel>>]
public class VProductAndDescriptionUpdateModelValidator
  : AbstractValidator<VProductAndDescriptionUpdateModel>
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="VProductAndDescriptionUpdateModelValidator" /> class.
  /// </summary>
  public VProductAndDescriptionUpdateModelValidator()
  {
    #region Generated Constructor

    RuleFor(p => p.Name).NotEmpty();
    RuleFor(p => p.Name).MaximumLength(50);
    RuleFor(p => p.ProductModel).NotEmpty();
    RuleFor(p => p.ProductModel).MaximumLength(50);
    RuleFor(p => p.CultureId).NotEmpty();
    RuleFor(p => p.CultureId).MaximumLength(6);
    RuleFor(p => p.Description).NotEmpty();
    RuleFor(p => p.Description).MaximumLength(400);

    #endregion
  }
}
