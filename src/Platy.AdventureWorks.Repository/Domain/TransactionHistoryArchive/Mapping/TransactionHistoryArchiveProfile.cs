using System;

using AutoMapper;

using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="TransactionHistoryArchive"/> .
/// </summary>
public partial class TransactionHistoryArchiveProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TransactionHistoryArchiveProfile"/> class.
    /// </summary>
    public TransactionHistoryArchiveProfile()
    {
        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.TransactionHistoryArchive, Platy.AdventureWorks.Repository.Domain.Models.TransactionHistoryArchiveReadModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.TransactionHistoryArchiveCreateModel, Platy.AdventureWorks.Repository.Data.Entities.TransactionHistoryArchive>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.TransactionHistoryArchive, Platy.AdventureWorks.Repository.Domain.Models.TransactionHistoryArchiveCreateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.TransactionHistoryArchive, Platy.AdventureWorks.Repository.Domain.Models.TransactionHistoryArchiveUpdateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.TransactionHistoryArchiveUpdateModel, Platy.AdventureWorks.Repository.Data.Entities.TransactionHistoryArchive>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.TransactionHistoryArchiveReadModel, Platy.AdventureWorks.Repository.Domain.Models.TransactionHistoryArchiveUpdateModel>();

    }

}
