using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
///   Validator class for <see cref="ProductListPriceHistoryCreateModel" /> .
/// </summary>
[RegisterSingleton<IValidator<ProductListPriceHistoryCreateModel>>]
public class ProductListPriceHistoryCreateModelValidator
  : AbstractValidator<ProductListPriceHistoryCreateModel>
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="ProductListPriceHistoryCreateModelValidator" /> class.
  /// </summary>
  public ProductListPriceHistoryCreateModelValidator()
  {
  }
}
