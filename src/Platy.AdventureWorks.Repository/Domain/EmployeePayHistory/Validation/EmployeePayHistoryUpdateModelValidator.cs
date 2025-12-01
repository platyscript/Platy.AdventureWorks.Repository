using System;

using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
/// Validator class for <see cref="EmployeePayHistoryUpdateModel"/> .
/// </summary>
[RegisterSingleton<IValidator<EmployeePayHistoryUpdateModel>>]
public partial class EmployeePayHistoryUpdateModelValidator
    : AbstractValidator<EmployeePayHistoryUpdateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EmployeePayHistoryUpdateModelValidator"/> class.
    /// </summary>
    public EmployeePayHistoryUpdateModelValidator()
    {
        #region Generated Constructor
        #endregion
    }

}
