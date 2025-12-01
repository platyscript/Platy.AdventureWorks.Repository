using System;

using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
/// Validator class for <see cref="SalesOrderDetailUpdateModel"/> .
/// </summary>
[RegisterSingleton<IValidator<SalesOrderDetailUpdateModel>>]
public partial class SalesOrderDetailUpdateModelValidator
    : AbstractValidator<SalesOrderDetailUpdateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SalesOrderDetailUpdateModelValidator"/> class.
    /// </summary>
    public SalesOrderDetailUpdateModelValidator()
    {
        #region Generated Constructor
        RuleFor(p => p.CarrierTrackingNumber).MaximumLength(25);
        #endregion
    }

}
