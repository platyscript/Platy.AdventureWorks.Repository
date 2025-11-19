using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
///   Validator class for <see cref="ProductPhotoUpdateModel" /> .
/// </summary>
[RegisterSingleton<IValidator<ProductPhotoUpdateModel>>]
public class ProductPhotoUpdateModelValidator
  : AbstractValidator<ProductPhotoUpdateModel>
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="ProductPhotoUpdateModelValidator" /> class.
  /// </summary>
  public ProductPhotoUpdateModelValidator()
  {
    #region Generated Constructor

    RuleFor(p => p.ThumbnailPhotoFileName).MaximumLength(50);
    RuleFor(p => p.LargePhotoFileName).MaximumLength(50);

    #endregion
  }
}
