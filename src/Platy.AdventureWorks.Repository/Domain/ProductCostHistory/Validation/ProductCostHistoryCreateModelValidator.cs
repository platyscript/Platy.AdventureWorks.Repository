using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
///   Validator class for <see cref="ProductCostHistoryCreateModel" /> .
/// </summary>
[RegisterSingleton<IValidator<ProductCostHistoryCreateModel>>]
public class ProductCostHistoryCreateModelValidator
  : AbstractValidator<ProductCostHistoryCreateModel>
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="ProductCostHistoryCreateModelValidator" /> class.
  /// </summary>
  public ProductCostHistoryCreateModelValidator()
  {
  }
}
