using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
///   Mapper class for entity <see cref="TransactionHistoryArchive" /> .
/// </summary>
public class TransactionHistoryArchiveProfile
  : Profile
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="TransactionHistoryArchiveProfile" /> class.
  /// </summary>
  public TransactionHistoryArchiveProfile()
  {
    CreateMap<TransactionHistoryArchive, TransactionHistoryArchiveReadModel>();

    CreateMap<TransactionHistoryArchiveCreateModel, TransactionHistoryArchive>();

    CreateMap<TransactionHistoryArchive, TransactionHistoryArchiveCreateModel>();

    CreateMap<TransactionHistoryArchive, TransactionHistoryArchiveUpdateModel>();

    CreateMap<TransactionHistoryArchiveUpdateModel, TransactionHistoryArchive>();

    CreateMap<TransactionHistoryArchiveReadModel, TransactionHistoryArchiveUpdateModel>();
  }
}
