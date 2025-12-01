using System;

using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
/// Validator class for <see cref="TransactionHistoryCreateModel"/> .
/// </summary>
[RegisterSingleton<IValidator<TransactionHistoryCreateModel>>]
public partial class TransactionHistoryCreateModelValidator
    : AbstractValidator<TransactionHistoryCreateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TransactionHistoryCreateModelValidator"/> class.
    /// </summary>
    public TransactionHistoryCreateModelValidator()
    {
        #region Generated Constructor
        RuleFor(p => p.TransactionType).NotEmpty();
        RuleFor(p => p.TransactionType).MaximumLength(1);
        #endregion
    }

}
