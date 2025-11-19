using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
///   Validator class for <see cref="SalesOrderHeaderSalesReasonCreateModel" /> .
/// </summary>
[RegisterSingleton<IValidator<SalesOrderHeaderSalesReasonCreateModel>>]
public class SalesOrderHeaderSalesReasonCreateModelValidator
  : AbstractValidator<SalesOrderHeaderSalesReasonCreateModel>
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="SalesOrderHeaderSalesReasonCreateModelValidator" /> class.
  /// </summary>
  public SalesOrderHeaderSalesReasonCreateModelValidator()
  {
  }
}
