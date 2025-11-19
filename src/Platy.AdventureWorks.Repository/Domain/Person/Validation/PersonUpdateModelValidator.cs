using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
///   Validator class for <see cref="PersonUpdateModel" /> .
/// </summary>
[RegisterSingleton<IValidator<PersonUpdateModel>>]
public class PersonUpdateModelValidator
  : AbstractValidator<PersonUpdateModel>
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="PersonUpdateModelValidator" /> class.
  /// </summary>
  public PersonUpdateModelValidator()
  {
    #region Generated Constructor

    RuleFor(p => p.PersonType).NotEmpty();
    RuleFor(p => p.PersonType).MaximumLength(2);
    RuleFor(p => p.Title).MaximumLength(8);
    RuleFor(p => p.FirstName).NotEmpty();
    RuleFor(p => p.FirstName).MaximumLength(50);
    RuleFor(p => p.MiddleName).MaximumLength(50);
    RuleFor(p => p.LastName).NotEmpty();
    RuleFor(p => p.LastName).MaximumLength(50);
    RuleFor(p => p.Suffix).MaximumLength(10);

    #endregion
  }
}
