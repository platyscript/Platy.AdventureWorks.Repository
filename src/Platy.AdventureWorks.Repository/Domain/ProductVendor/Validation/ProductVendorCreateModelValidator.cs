using System;

using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
/// Validator class for <see cref="ProductVendorCreateModel"/> .
/// </summary>
[RegisterSingleton<IValidator<ProductVendorCreateModel>>]
public partial class ProductVendorCreateModelValidator
    : AbstractValidator<ProductVendorCreateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ProductVendorCreateModelValidator"/> class.
    /// </summary>
    public ProductVendorCreateModelValidator()
    {
        #region Generated Constructor
        RuleFor(p => p.UnitMeasureCode).NotEmpty();
        RuleFor(p => p.UnitMeasureCode).MaximumLength(3);
        #endregion
    }

}
