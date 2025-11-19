using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
///   Validator class for <see cref="VProductAndDescriptionCreateModel" /> .
/// </summary>
[RegisterSingleton<IValidator<VProductAndDescriptionCreateModel>>]
public class VProductAndDescriptionCreateModelValidator
  : AbstractValidator<VProductAndDescriptionCreateModel>
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="VProductAndDescriptionCreateModelValidator" /> class.
  /// </summary>
  public VProductAndDescriptionCreateModelValidator()
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
