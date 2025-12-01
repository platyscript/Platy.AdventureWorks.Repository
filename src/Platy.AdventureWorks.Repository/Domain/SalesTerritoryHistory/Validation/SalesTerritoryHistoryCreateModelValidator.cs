using System;

using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
/// Validator class for <see cref="SalesTerritoryHistoryCreateModel"/> .
/// </summary>
[RegisterSingleton<IValidator<SalesTerritoryHistoryCreateModel>>]
public partial class SalesTerritoryHistoryCreateModelValidator
    : AbstractValidator<SalesTerritoryHistoryCreateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SalesTerritoryHistoryCreateModelValidator"/> class.
    /// </summary>
    public SalesTerritoryHistoryCreateModelValidator()
    {
        #region Generated Constructor
        #endregion
    }

}
