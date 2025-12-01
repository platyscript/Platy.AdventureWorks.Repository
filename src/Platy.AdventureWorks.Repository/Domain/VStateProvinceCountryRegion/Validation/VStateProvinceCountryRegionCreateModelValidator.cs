using System;

using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
/// Validator class for <see cref="VStateProvinceCountryRegionCreateModel"/> .
/// </summary>
[RegisterSingleton<IValidator<VStateProvinceCountryRegionCreateModel>>]
public partial class VStateProvinceCountryRegionCreateModelValidator
    : AbstractValidator<VStateProvinceCountryRegionCreateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="VStateProvinceCountryRegionCreateModelValidator"/> class.
    /// </summary>
    public VStateProvinceCountryRegionCreateModelValidator()
    {
        #region Generated Constructor
        RuleFor(p => p.StateProvinceCode).NotEmpty();
        RuleFor(p => p.StateProvinceCode).MaximumLength(3);
        RuleFor(p => p.StateProvinceName).NotEmpty();
        RuleFor(p => p.StateProvinceName).MaximumLength(50);
        RuleFor(p => p.CountryRegionCode).NotEmpty();
        RuleFor(p => p.CountryRegionCode).MaximumLength(3);
        RuleFor(p => p.CountryRegionName).NotEmpty();
        RuleFor(p => p.CountryRegionName).MaximumLength(50);
        #endregion
    }

}
