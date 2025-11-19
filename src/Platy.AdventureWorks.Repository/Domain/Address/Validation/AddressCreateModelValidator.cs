using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
///   Validator class for <see cref="AddressCreateModel" /> .
/// </summary>
[RegisterSingleton<IValidator<AddressCreateModel>>]
public class AddressCreateModelValidator
  : AbstractValidator<AddressCreateModel>
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="AddressCreateModelValidator" /> class.
  /// </summary>
  public AddressCreateModelValidator()
  {
    #region Generated Constructor

    RuleFor(p => p.AddressLine1).NotEmpty();
    RuleFor(p => p.AddressLine1).MaximumLength(60);
    RuleFor(p => p.AddressLine2).MaximumLength(60);
    RuleFor(p => p.City).NotEmpty();
    RuleFor(p => p.City).MaximumLength(30);
    RuleFor(p => p.PostalCode).NotEmpty();
    RuleFor(p => p.PostalCode).MaximumLength(15);

    #endregion
  }
}
