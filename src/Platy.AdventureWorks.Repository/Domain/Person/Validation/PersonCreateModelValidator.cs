using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
///   Validator class for <see cref="PersonCreateModel" /> .
/// </summary>
[RegisterSingleton<IValidator<PersonCreateModel>>]
public class PersonCreateModelValidator
  : AbstractValidator<PersonCreateModel>
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="PersonCreateModelValidator" /> class.
  /// </summary>
  public PersonCreateModelValidator()
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
