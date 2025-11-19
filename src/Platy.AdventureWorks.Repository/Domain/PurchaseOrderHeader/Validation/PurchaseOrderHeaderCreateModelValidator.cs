using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
///   Validator class for <see cref="PurchaseOrderHeaderCreateModel" /> .
/// </summary>
[RegisterSingleton<IValidator<PurchaseOrderHeaderCreateModel>>]
public class PurchaseOrderHeaderCreateModelValidator
  : AbstractValidator<PurchaseOrderHeaderCreateModel>
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="PurchaseOrderHeaderCreateModelValidator" /> class.
  /// </summary>
  public PurchaseOrderHeaderCreateModelValidator()
  {
  }
}
