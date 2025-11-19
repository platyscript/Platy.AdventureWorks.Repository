using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
///   Validator class for <see cref="LocationCreateModel" /> .
/// </summary>
[RegisterSingleton<IValidator<LocationCreateModel>>]
public class LocationCreateModelValidator
  : AbstractValidator<LocationCreateModel>
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="LocationCreateModelValidator" /> class.
  /// </summary>
  public LocationCreateModelValidator()
  {
    #region Generated Constructor

    RuleFor(p => p.Name).NotEmpty();
    RuleFor(p => p.Name).MaximumLength(50);

    #endregion
  }
}
