using System;

using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
/// Validator class for <see cref="BusinessEntityContactUpdateModel"/> .
/// </summary>
[RegisterSingleton<IValidator<BusinessEntityContactUpdateModel>>]
public partial class BusinessEntityContactUpdateModelValidator
    : AbstractValidator<BusinessEntityContactUpdateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BusinessEntityContactUpdateModelValidator"/> class.
    /// </summary>
    public BusinessEntityContactUpdateModelValidator()
    {
        #region Generated Constructor
        #endregion
    }

}
