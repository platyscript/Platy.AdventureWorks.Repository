using System;

using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
/// Validator class for <see cref="VStoreWithDemographicsUpdateModel"/> .
/// </summary>
[RegisterSingleton<IValidator<VStoreWithDemographicsUpdateModel>>]
public partial class VStoreWithDemographicsUpdateModelValidator
    : AbstractValidator<VStoreWithDemographicsUpdateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="VStoreWithDemographicsUpdateModelValidator"/> class.
    /// </summary>
    public VStoreWithDemographicsUpdateModelValidator()
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
