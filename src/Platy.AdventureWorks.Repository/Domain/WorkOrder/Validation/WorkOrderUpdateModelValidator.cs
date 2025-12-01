using System;

using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
/// Validator class for <see cref="WorkOrderUpdateModel"/> .
/// </summary>
[RegisterSingleton<IValidator<WorkOrderUpdateModel>>]
public partial class WorkOrderUpdateModelValidator
    : AbstractValidator<WorkOrderUpdateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="WorkOrderUpdateModelValidator"/> class.
    /// </summary>
    public WorkOrderUpdateModelValidator()
    {
        #region Generated Constructor
        #endregion
    }

}
