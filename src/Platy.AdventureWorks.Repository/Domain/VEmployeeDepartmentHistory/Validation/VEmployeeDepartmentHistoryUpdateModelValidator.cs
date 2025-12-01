using System;

using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
/// Validator class for <see cref="VEmployeeDepartmentHistoryUpdateModel"/> .
/// </summary>
[RegisterSingleton<IValidator<VEmployeeDepartmentHistoryUpdateModel>>]
public partial class VEmployeeDepartmentHistoryUpdateModelValidator
    : AbstractValidator<VEmployeeDepartmentHistoryUpdateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="VEmployeeDepartmentHistoryUpdateModelValidator"/> class.
    /// </summary>
    public VEmployeeDepartmentHistoryUpdateModelValidator()
    {
        #region Generated Constructor
        RuleFor(p => p.Title).MaximumLength(8);
        RuleFor(p => p.FirstName).NotEmpty();
        RuleFor(p => p.FirstName).MaximumLength(50);
        RuleFor(p => p.MiddleName).MaximumLength(50);
        RuleFor(p => p.LastName).NotEmpty();
        RuleFor(p => p.LastName).MaximumLength(50);
        RuleFor(p => p.Suffix).MaximumLength(10);
        RuleFor(p => p.Shift).NotEmpty();
        RuleFor(p => p.Shift).MaximumLength(50);
        RuleFor(p => p.Department).NotEmpty();
        RuleFor(p => p.Department).MaximumLength(50);
        RuleFor(p => p.GroupName).NotEmpty();
        RuleFor(p => p.GroupName).MaximumLength(50);
        #endregion
    }

}
