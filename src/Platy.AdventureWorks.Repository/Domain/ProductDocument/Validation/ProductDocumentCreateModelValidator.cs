using System;

using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
/// Validator class for <see cref="ProductDocumentCreateModel"/> .
/// </summary>
[RegisterSingleton<IValidator<ProductDocumentCreateModel>>]
public partial class ProductDocumentCreateModelValidator
    : AbstractValidator<ProductDocumentCreateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ProductDocumentCreateModelValidator"/> class.
    /// </summary>
    public ProductDocumentCreateModelValidator()
    {
        #region Generated Constructor
        #endregion
    }

}
