using System;

using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
/// Validator class for <see cref="VPersonDemographicsUpdateModel"/> .
/// </summary>
[RegisterSingleton<IValidator<VPersonDemographicsUpdateModel>>]
public partial class VPersonDemographicsUpdateModelValidator
    : AbstractValidator<VPersonDemographicsUpdateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="VPersonDemographicsUpdateModelValidator"/> class.
    /// </summary>
    public VPersonDemographicsUpdateModelValidator()
    {
        #region Generated Constructor
        RuleFor(p => p.MaritalStatus).MaximumLength(1);
        RuleFor(p => p.YearlyIncome).MaximumLength(30);
        RuleFor(p => p.Gender).MaximumLength(1);
        RuleFor(p => p.Education).MaximumLength(30);
        RuleFor(p => p.Occupation).MaximumLength(30);
        #endregion
    }

}
