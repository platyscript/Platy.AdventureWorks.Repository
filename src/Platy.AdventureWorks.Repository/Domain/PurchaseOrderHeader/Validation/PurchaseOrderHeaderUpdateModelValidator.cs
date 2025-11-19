using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
///   Validator class for <see cref="PurchaseOrderHeaderUpdateModel" /> .
/// </summary>
[RegisterSingleton<IValidator<PurchaseOrderHeaderUpdateModel>>]
public class PurchaseOrderHeaderUpdateModelValidator
  : AbstractValidator<PurchaseOrderHeaderUpdateModel>
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="PurchaseOrderHeaderUpdateModelValidator" /> class.
  /// </summary>
  public PurchaseOrderHeaderUpdateModelValidator()
  {
  }
}
