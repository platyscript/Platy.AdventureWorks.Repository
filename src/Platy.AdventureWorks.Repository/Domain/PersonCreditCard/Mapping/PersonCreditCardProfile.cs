using System;

using AutoMapper;

using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="PersonCreditCard"/> .
/// </summary>
public partial class PersonCreditCardProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PersonCreditCardProfile"/> class.
    /// </summary>
    public PersonCreditCardProfile()
    {
        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.PersonCreditCard, Platy.AdventureWorks.Repository.Domain.Models.PersonCreditCardReadModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.PersonCreditCardCreateModel, Platy.AdventureWorks.Repository.Data.Entities.PersonCreditCard>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.PersonCreditCard, Platy.AdventureWorks.Repository.Domain.Models.PersonCreditCardCreateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.PersonCreditCard, Platy.AdventureWorks.Repository.Domain.Models.PersonCreditCardUpdateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.PersonCreditCardUpdateModel, Platy.AdventureWorks.Repository.Data.Entities.PersonCreditCard>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.PersonCreditCardReadModel, Platy.AdventureWorks.Repository.Domain.Models.PersonCreditCardUpdateModel>();

    }

}
