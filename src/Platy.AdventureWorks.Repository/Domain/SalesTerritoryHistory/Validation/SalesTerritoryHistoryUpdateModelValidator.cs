using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
///   Validator class for <see cref="SalesTerritoryHistoryUpdateModel" /> .
/// </summary>
[RegisterSingleton<IValidator<SalesTerritoryHistoryUpdateModel>>]
public class SalesTerritoryHistoryUpdateModelValidator
  : AbstractValidator<SalesTerritoryHistoryUpdateModel>
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="SalesTerritoryHistoryUpdateModelValidator" /> class.
  /// </summary>
  public SalesTerritoryHistoryUpdateModelValidator()
  {
  }
}
