using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
///   Validator class for <see cref="ProductProductPhotoCreateModel" /> .
/// </summary>
[RegisterSingleton<IValidator<ProductProductPhotoCreateModel>>]
public class ProductProductPhotoCreateModelValidator
  : AbstractValidator<ProductProductPhotoCreateModel>
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="ProductProductPhotoCreateModelValidator" /> class.
  /// </summary>
  public ProductProductPhotoCreateModelValidator()
  {
  }
}
