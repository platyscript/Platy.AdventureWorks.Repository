using System;

using AutoMapper;

using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="TransactionHistory"/> .
/// </summary>
public partial class TransactionHistoryProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TransactionHistoryProfile"/> class.
    /// </summary>
    public TransactionHistoryProfile()
    {
        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.TransactionHistory, Platy.AdventureWorks.Repository.Domain.Models.TransactionHistoryReadModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.TransactionHistoryCreateModel, Platy.AdventureWorks.Repository.Data.Entities.TransactionHistory>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.TransactionHistory, Platy.AdventureWorks.Repository.Domain.Models.TransactionHistoryCreateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.TransactionHistory, Platy.AdventureWorks.Repository.Domain.Models.TransactionHistoryUpdateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.TransactionHistoryUpdateModel, Platy.AdventureWorks.Repository.Data.Entities.TransactionHistory>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.TransactionHistoryReadModel, Platy.AdventureWorks.Repository.Domain.Models.TransactionHistoryUpdateModel>();

    }

}
