using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
///   Validator class for <see cref="TransactionHistoryArchiveUpdateModel" /> .
/// </summary>
[RegisterSingleton<IValidator<TransactionHistoryArchiveUpdateModel>>]
public class TransactionHistoryArchiveUpdateModelValidator
  : AbstractValidator<TransactionHistoryArchiveUpdateModel>
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="TransactionHistoryArchiveUpdateModelValidator" /> class.
  /// </summary>
  public TransactionHistoryArchiveUpdateModelValidator()
  {
    #region Generated Constructor

    RuleFor(p => p.TransactionType).NotEmpty();
    RuleFor(p => p.TransactionType).MaximumLength(1);

    #endregion
  }
}
