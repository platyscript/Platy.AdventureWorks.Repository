using System;

using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
/// Validator class for <see cref="PhoneNumberTypeUpdateModel"/> .
/// </summary>
[RegisterSingleton<IValidator<PhoneNumberTypeUpdateModel>>]
public partial class PhoneNumberTypeUpdateModelValidator
    : AbstractValidator<PhoneNumberTypeUpdateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PhoneNumberTypeUpdateModelValidator"/> class.
    /// </summary>
    public PhoneNumberTypeUpdateModelValidator()
    {
        #region Generated Constructor
        RuleFor(p => p.Name).NotEmpty();
        RuleFor(p => p.Name).MaximumLength(50);
        #endregion
    }

}
