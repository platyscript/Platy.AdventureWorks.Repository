using System;

using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
/// Validator class for <see cref="BusinessEntityUpdateModel"/> .
/// </summary>
[RegisterSingleton<IValidator<BusinessEntityUpdateModel>>]
public partial class BusinessEntityUpdateModelValidator
    : AbstractValidator<BusinessEntityUpdateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BusinessEntityUpdateModelValidator"/> class.
    /// </summary>
    public BusinessEntityUpdateModelValidator()
    {
        #region Generated Constructor
        #endregion
    }

}
