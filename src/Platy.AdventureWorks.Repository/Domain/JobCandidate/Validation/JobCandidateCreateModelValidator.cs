using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
///   Validator class for <see cref="JobCandidateCreateModel" /> .
/// </summary>
[RegisterSingleton<IValidator<JobCandidateCreateModel>>]
public class JobCandidateCreateModelValidator
  : AbstractValidator<JobCandidateCreateModel>
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="JobCandidateCreateModelValidator" /> class.
  /// </summary>
  public JobCandidateCreateModelValidator()
  {
  }
}
