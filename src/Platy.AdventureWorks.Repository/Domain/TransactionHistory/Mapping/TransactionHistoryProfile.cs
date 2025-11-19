using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
///   Mapper class for entity <see cref="TransactionHistory" /> .
/// </summary>
public class TransactionHistoryProfile
  : Profile
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="TransactionHistoryProfile" /> class.
  /// </summary>
  public TransactionHistoryProfile()
  {
    CreateMap<TransactionHistory, TransactionHistoryReadModel>();

    CreateMap<TransactionHistoryCreateModel, TransactionHistory>();

    CreateMap<TransactionHistory, TransactionHistoryCreateModel>();

    CreateMap<TransactionHistory, TransactionHistoryUpdateModel>();

    CreateMap<TransactionHistoryUpdateModel, TransactionHistory>();

    CreateMap<TransactionHistoryReadModel, TransactionHistoryUpdateModel>();
  }
}
