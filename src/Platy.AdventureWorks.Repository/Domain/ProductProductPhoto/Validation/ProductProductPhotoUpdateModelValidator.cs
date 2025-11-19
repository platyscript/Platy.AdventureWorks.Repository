using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
///   Validator class for <see cref="ProductProductPhotoUpdateModel" /> .
/// </summary>
[RegisterSingleton<IValidator<ProductProductPhotoUpdateModel>>]
public class ProductProductPhotoUpdateModelValidator
  : AbstractValidator<ProductProductPhotoUpdateModel>
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="ProductProductPhotoUpdateModelValidator" /> class.
  /// </summary>
  public ProductProductPhotoUpdateModelValidator()
  {
  }
}
