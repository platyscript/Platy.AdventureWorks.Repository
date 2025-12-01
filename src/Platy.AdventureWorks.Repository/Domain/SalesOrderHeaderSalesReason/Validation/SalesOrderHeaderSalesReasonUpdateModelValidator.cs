using System;

using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
/// Validator class for <see cref="SalesOrderHeaderSalesReasonUpdateModel"/> .
/// </summary>
[RegisterSingleton<IValidator<SalesOrderHeaderSalesReasonUpdateModel>>]
public partial class SalesOrderHeaderSalesReasonUpdateModelValidator
    : AbstractValidator<SalesOrderHeaderSalesReasonUpdateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SalesOrderHeaderSalesReasonUpdateModelValidator"/> class.
    /// </summary>
    public SalesOrderHeaderSalesReasonUpdateModelValidator()
    {
        #region Generated Constructor
        #endregion
    }

}
