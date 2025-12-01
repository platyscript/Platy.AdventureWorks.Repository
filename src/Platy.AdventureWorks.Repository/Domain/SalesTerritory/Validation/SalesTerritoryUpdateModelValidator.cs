using System;

using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
/// Validator class for <see cref="SalesTerritoryUpdateModel"/> .
/// </summary>
[RegisterSingleton<IValidator<SalesTerritoryUpdateModel>>]
public partial class SalesTerritoryUpdateModelValidator
    : AbstractValidator<SalesTerritoryUpdateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SalesTerritoryUpdateModelValidator"/> class.
    /// </summary>
    public SalesTerritoryUpdateModelValidator()
    {
        #region Generated Constructor
        RuleFor(p => p.Name).NotEmpty();
        RuleFor(p => p.Name).MaximumLength(50);
        RuleFor(p => p.CountryRegionCode).NotEmpty();
        RuleFor(p => p.CountryRegionCode).MaximumLength(3);
        RuleFor(p => p.Group).NotEmpty();
        RuleFor(p => p.Group).MaximumLength(50);
        #endregion
    }

}
