using System;

using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
/// Validator class for <see cref="VStoreWithAddressesCreateModel"/> .
/// </summary>
[RegisterSingleton<IValidator<VStoreWithAddressesCreateModel>>]
public partial class VStoreWithAddressesCreateModelValidator
    : AbstractValidator<VStoreWithAddressesCreateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="VStoreWithAddressesCreateModelValidator"/> class.
    /// </summary>
    public VStoreWithAddressesCreateModelValidator()
    {
        #region Generated Constructor
        RuleFor(p => p.Name).NotEmpty();
        RuleFor(p => p.Name).MaximumLength(50);
        RuleFor(p => p.AddressType).NotEmpty();
        RuleFor(p => p.AddressType).MaximumLength(50);
        RuleFor(p => p.AddressLine1).NotEmpty();
        RuleFor(p => p.AddressLine1).MaximumLength(60);
        RuleFor(p => p.AddressLine2).MaximumLength(60);
        RuleFor(p => p.City).NotEmpty();
        RuleFor(p => p.City).MaximumLength(30);
        RuleFor(p => p.StateProvinceName).NotEmpty();
        RuleFor(p => p.StateProvinceName).MaximumLength(50);
        RuleFor(p => p.PostalCode).NotEmpty();
        RuleFor(p => p.PostalCode).MaximumLength(15);
        RuleFor(p => p.CountryRegionName).NotEmpty();
        RuleFor(p => p.CountryRegionName).MaximumLength(50);
        #endregion
    }

}
