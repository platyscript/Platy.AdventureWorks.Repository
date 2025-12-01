using System;

using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
/// Validator class for <see cref="AddressTypeUpdateModel"/> .
/// </summary>
[RegisterSingleton<IValidator<AddressTypeUpdateModel>>]
public partial class AddressTypeUpdateModelValidator
    : AbstractValidator<AddressTypeUpdateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AddressTypeUpdateModelValidator"/> class.
    /// </summary>
    public AddressTypeUpdateModelValidator()
    {
        #region Generated Constructor
        RuleFor(p => p.Name).NotEmpty();
        RuleFor(p => p.Name).MaximumLength(50);
        #endregion
    }

}
