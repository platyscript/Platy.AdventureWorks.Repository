using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
///   Validator class for <see cref="ProductInventoryCreateModel" /> .
/// </summary>
[RegisterSingleton<IValidator<ProductInventoryCreateModel>>]
public class ProductInventoryCreateModelValidator
  : AbstractValidator<ProductInventoryCreateModel>
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="ProductInventoryCreateModelValidator" /> class.
  /// </summary>
  public ProductInventoryCreateModelValidator()
  {
    #region Generated Constructor

    RuleFor(p => p.Shelf).NotEmpty();
    RuleFor(p => p.Shelf).MaximumLength(10);

    #endregion
  }
}
