using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
///   Validator class for <see cref="ProductUpdateModel" /> .
/// </summary>
[RegisterSingleton<IValidator<ProductUpdateModel>>]
public class ProductUpdateModelValidator
  : AbstractValidator<ProductUpdateModel>
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="ProductUpdateModelValidator" /> class.
  /// </summary>
  public ProductUpdateModelValidator()
  {
    #region Generated Constructor

    RuleFor(p => p.Name).NotEmpty();
    RuleFor(p => p.Name).MaximumLength(50);
    RuleFor(p => p.ProductNumber).NotEmpty();
    RuleFor(p => p.ProductNumber).MaximumLength(25);
    RuleFor(p => p.Color).MaximumLength(15);
    RuleFor(p => p.Size).MaximumLength(5);
    RuleFor(p => p.SizeUnitMeasureCode).MaximumLength(3);
    RuleFor(p => p.WeightUnitMeasureCode).MaximumLength(3);
    RuleFor(p => p.ProductLine).MaximumLength(2);
    RuleFor(p => p.Class).MaximumLength(2);
    RuleFor(p => p.Style).MaximumLength(2);

    #endregion
  }
}
