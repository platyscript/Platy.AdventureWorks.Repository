using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
///   Validator class for <see cref="ProductDescriptionUpdateModel" /> .
/// </summary>
[RegisterSingleton<IValidator<ProductDescriptionUpdateModel>>]
public class ProductDescriptionUpdateModelValidator
  : AbstractValidator<ProductDescriptionUpdateModel>
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="ProductDescriptionUpdateModelValidator" /> class.
  /// </summary>
  public ProductDescriptionUpdateModelValidator()
  {
    #region Generated Constructor

    RuleFor(p => p.Description).NotEmpty();
    RuleFor(p => p.Description).MaximumLength(400);

    #endregion
  }
}
