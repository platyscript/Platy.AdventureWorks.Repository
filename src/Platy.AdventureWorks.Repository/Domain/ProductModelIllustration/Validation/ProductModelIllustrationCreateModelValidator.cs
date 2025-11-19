using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
///   Validator class for <see cref="ProductModelIllustrationCreateModel" /> .
/// </summary>
[RegisterSingleton<IValidator<ProductModelIllustrationCreateModel>>]
public class ProductModelIllustrationCreateModelValidator
  : AbstractValidator<ProductModelIllustrationCreateModel>
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="ProductModelIllustrationCreateModelValidator" /> class.
  /// </summary>
  public ProductModelIllustrationCreateModelValidator()
  {
  }
}
