using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
///   Validator class for <see cref="ProductCostHistoryUpdateModel" /> .
/// </summary>
[RegisterSingleton<IValidator<ProductCostHistoryUpdateModel>>]
public class ProductCostHistoryUpdateModelValidator
  : AbstractValidator<ProductCostHistoryUpdateModel>
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="ProductCostHistoryUpdateModelValidator" /> class.
  /// </summary>
  public ProductCostHistoryUpdateModelValidator()
  {
  }
}
