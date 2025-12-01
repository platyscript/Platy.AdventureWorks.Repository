using System;

using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
/// Validator class for <see cref="WorkOrderCreateModel"/> .
/// </summary>
[RegisterSingleton<IValidator<WorkOrderCreateModel>>]
public partial class WorkOrderCreateModelValidator
    : AbstractValidator<WorkOrderCreateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="WorkOrderCreateModelValidator"/> class.
    /// </summary>
    public WorkOrderCreateModelValidator()
    {
        #region Generated Constructor
        #endregion
    }

}
