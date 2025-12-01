using System;

using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
/// Validator class for <see cref="AddressUpdateModel"/> .
/// </summary>
[RegisterSingleton<IValidator<AddressUpdateModel>>]
public partial class AddressUpdateModelValidator
    : AbstractValidator<AddressUpdateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AddressUpdateModelValidator"/> class.
    /// </summary>
    public AddressUpdateModelValidator()
    {
        #region Generated Constructor
        RuleFor(p => p.AddressLine1).NotEmpty();
        RuleFor(p => p.AddressLine1).MaximumLength(60);
        RuleFor(p => p.AddressLine2).MaximumLength(60);
        RuleFor(p => p.City).NotEmpty();
        RuleFor(p => p.City).MaximumLength(30);
        RuleFor(p => p.PostalCode).NotEmpty();
        RuleFor(p => p.PostalCode).MaximumLength(15);
        #endregion
    }

}
