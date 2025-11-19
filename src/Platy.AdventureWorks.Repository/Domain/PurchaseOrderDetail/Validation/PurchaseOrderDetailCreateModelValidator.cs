using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
///   Validator class for <see cref="PurchaseOrderDetailCreateModel" /> .
/// </summary>
[RegisterSingleton<IValidator<PurchaseOrderDetailCreateModel>>]
public class PurchaseOrderDetailCreateModelValidator
  : AbstractValidator<PurchaseOrderDetailCreateModel>
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="PurchaseOrderDetailCreateModelValidator" /> class.
  /// </summary>
  public PurchaseOrderDetailCreateModelValidator()
  {
  }
}
