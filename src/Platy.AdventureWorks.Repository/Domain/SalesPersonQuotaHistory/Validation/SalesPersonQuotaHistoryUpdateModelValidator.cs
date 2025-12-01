using System;

using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
/// Validator class for <see cref="SalesPersonQuotaHistoryUpdateModel"/> .
/// </summary>
[RegisterSingleton<IValidator<SalesPersonQuotaHistoryUpdateModel>>]
public partial class SalesPersonQuotaHistoryUpdateModelValidator
    : AbstractValidator<SalesPersonQuotaHistoryUpdateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SalesPersonQuotaHistoryUpdateModelValidator"/> class.
    /// </summary>
    public SalesPersonQuotaHistoryUpdateModelValidator()
    {
        #region Generated Constructor
        #endregion
    }

}
