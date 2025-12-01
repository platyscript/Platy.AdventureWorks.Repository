using System;

using AutoMapper;

using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="CreditCard"/> .
/// </summary>
public partial class CreditCardProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CreditCardProfile"/> class.
    /// </summary>
    public CreditCardProfile()
    {
        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.CreditCard, Platy.AdventureWorks.Repository.Domain.Models.CreditCardReadModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.CreditCardCreateModel, Platy.AdventureWorks.Repository.Data.Entities.CreditCard>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.CreditCard, Platy.AdventureWorks.Repository.Domain.Models.CreditCardCreateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.CreditCard, Platy.AdventureWorks.Repository.Domain.Models.CreditCardUpdateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.CreditCardUpdateModel, Platy.AdventureWorks.Repository.Data.Entities.CreditCard>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.CreditCardReadModel, Platy.AdventureWorks.Repository.Domain.Models.CreditCardUpdateModel>();

    }

}
