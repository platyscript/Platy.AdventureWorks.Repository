using System;

using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
/// Validator class for <see cref="ProductPhotoCreateModel"/> .
/// </summary>
[RegisterSingleton<IValidator<ProductPhotoCreateModel>>]
public partial class ProductPhotoCreateModelValidator
    : AbstractValidator<ProductPhotoCreateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ProductPhotoCreateModelValidator"/> class.
    /// </summary>
    public ProductPhotoCreateModelValidator()
    {
        #region Generated Constructor
        RuleFor(p => p.ThumbnailPhotoFileName).MaximumLength(50);
        RuleFor(p => p.LargePhotoFileName).MaximumLength(50);
        #endregion
    }

}
