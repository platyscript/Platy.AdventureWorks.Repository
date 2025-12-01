using System;

using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
/// Validator class for <see cref="PasswordUpdateModel"/> .
/// </summary>
[RegisterSingleton<IValidator<PasswordUpdateModel>>]
public partial class PasswordUpdateModelValidator
    : AbstractValidator<PasswordUpdateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PasswordUpdateModelValidator"/> class.
    /// </summary>
    public PasswordUpdateModelValidator()
    {
        #region Generated Constructor
        RuleFor(p => p.PasswordHash).NotEmpty();
        RuleFor(p => p.PasswordHash).MaximumLength(128);
        RuleFor(p => p.PasswordSalt).NotEmpty();
        RuleFor(p => p.PasswordSalt).MaximumLength(10);
        #endregion
    }

}
