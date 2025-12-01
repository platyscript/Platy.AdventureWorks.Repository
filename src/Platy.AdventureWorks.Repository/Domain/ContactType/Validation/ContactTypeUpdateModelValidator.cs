using System;

using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
/// Validator class for <see cref="ContactTypeUpdateModel"/> .
/// </summary>
[RegisterSingleton<IValidator<ContactTypeUpdateModel>>]
public partial class ContactTypeUpdateModelValidator
    : AbstractValidator<ContactTypeUpdateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ContactTypeUpdateModelValidator"/> class.
    /// </summary>
    public ContactTypeUpdateModelValidator()
    {
        #region Generated Constructor
        RuleFor(p => p.Name).NotEmpty();
        RuleFor(p => p.Name).MaximumLength(50);
        #endregion
    }

}
