using System;

using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
/// Validator class for <see cref="ProductVendorUpdateModel"/> .
/// </summary>
[RegisterSingleton<IValidator<ProductVendorUpdateModel>>]
public partial class ProductVendorUpdateModelValidator
    : AbstractValidator<ProductVendorUpdateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ProductVendorUpdateModelValidator"/> class.
    /// </summary>
    public ProductVendorUpdateModelValidator()
    {
        #region Generated Constructor
        RuleFor(p => p.UnitMeasureCode).NotEmpty();
        RuleFor(p => p.UnitMeasureCode).MaximumLength(3);
        #endregion
    }

}
