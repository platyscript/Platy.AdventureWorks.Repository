using System;

using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
/// Validator class for <see cref="BusinessEntityContactCreateModel"/> .
/// </summary>
[RegisterSingleton<IValidator<BusinessEntityContactCreateModel>>]
public partial class BusinessEntityContactCreateModelValidator
    : AbstractValidator<BusinessEntityContactCreateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BusinessEntityContactCreateModelValidator"/> class.
    /// </summary>
    public BusinessEntityContactCreateModelValidator()
    {
        #region Generated Constructor
        #endregion
    }

}
