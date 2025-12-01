using System;

using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
/// Validator class for <see cref="VStoreWithDemographicsCreateModel"/> .
/// </summary>
[RegisterSingleton<IValidator<VStoreWithDemographicsCreateModel>>]
public partial class VStoreWithDemographicsCreateModelValidator
    : AbstractValidator<VStoreWithDemographicsCreateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="VStoreWithDemographicsCreateModelValidator"/> class.
    /// </summary>
    public VStoreWithDemographicsCreateModelValidator()
    {
        #region Generated Constructor
        RuleFor(p => p.Name).NotEmpty();
        RuleFor(p => p.Name).MaximumLength(50);
        RuleFor(p => p.BankName).MaximumLength(50);
        RuleFor(p => p.BusinessType).MaximumLength(5);
        RuleFor(p => p.Specialty).MaximumLength(50);
        RuleFor(p => p.Brands).MaximumLength(30);
        RuleFor(p => p.Internet).MaximumLength(30);
        #endregion
    }

}
