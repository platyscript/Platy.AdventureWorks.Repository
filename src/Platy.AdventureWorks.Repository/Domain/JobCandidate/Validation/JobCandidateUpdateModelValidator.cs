using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
///   Validator class for <see cref="JobCandidateUpdateModel" /> .
/// </summary>
[RegisterSingleton<IValidator<JobCandidateUpdateModel>>]
public class JobCandidateUpdateModelValidator
  : AbstractValidator<JobCandidateUpdateModel>
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="JobCandidateUpdateModelValidator" /> class.
  /// </summary>
  public JobCandidateUpdateModelValidator()
  {
  }
}
