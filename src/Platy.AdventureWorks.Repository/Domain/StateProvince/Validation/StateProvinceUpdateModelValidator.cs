using System;

using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
/// Validator class for <see cref="StateProvinceUpdateModel"/> .
/// </summary>
[RegisterSingleton<IValidator<StateProvinceUpdateModel>>]
public partial class StateProvinceUpdateModelValidator
    : AbstractValidator<StateProvinceUpdateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="StateProvinceUpdateModelValidator"/> class.
    /// </summary>
    public StateProvinceUpdateModelValidator()
    {
        #region Generated Constructor
        RuleFor(p => p.StateProvinceCode).NotEmpty();
        RuleFor(p => p.StateProvinceCode).MaximumLength(3);
        RuleFor(p => p.CountryRegionCode).NotEmpty();
        RuleFor(p => p.CountryRegionCode).MaximumLength(3);
        RuleFor(p => p.Name).NotEmpty();
        RuleFor(p => p.Name).MaximumLength(50);
        #endregion
    }

}
