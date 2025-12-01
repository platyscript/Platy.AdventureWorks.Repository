using System;

using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
/// Validator class for <see cref="CreditCardUpdateModel"/> .
/// </summary>
[RegisterSingleton<IValidator<CreditCardUpdateModel>>]
public partial class CreditCardUpdateModelValidator
    : AbstractValidator<CreditCardUpdateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CreditCardUpdateModelValidator"/> class.
    /// </summary>
    public CreditCardUpdateModelValidator()
    {
        #region Generated Constructor
        RuleFor(p => p.CardType).NotEmpty();
        RuleFor(p => p.CardType).MaximumLength(50);
        RuleFor(p => p.CardNumber).NotEmpty();
        RuleFor(p => p.CardNumber).MaximumLength(25);
        #endregion
    }

}
