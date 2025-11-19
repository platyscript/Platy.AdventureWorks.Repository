using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
///   Validator class for <see cref="SalesPersonQuotaHistoryCreateModel" /> .
/// </summary>
[RegisterSingleton<IValidator<SalesPersonQuotaHistoryCreateModel>>]
public class SalesPersonQuotaHistoryCreateModelValidator
  : AbstractValidator<SalesPersonQuotaHistoryCreateModel>
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="SalesPersonQuotaHistoryCreateModelValidator" /> class.
  /// </summary>
  public SalesPersonQuotaHistoryCreateModelValidator()
  {
  }
}
