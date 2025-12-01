using System;

using AutoMapper;

using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="Password"/> .
/// </summary>
public partial class PasswordProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PasswordProfile"/> class.
    /// </summary>
    public PasswordProfile()
    {
        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.Password, Platy.AdventureWorks.Repository.Domain.Models.PasswordReadModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.PasswordCreateModel, Platy.AdventureWorks.Repository.Data.Entities.Password>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.Password, Platy.AdventureWorks.Repository.Domain.Models.PasswordCreateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.Password, Platy.AdventureWorks.Repository.Domain.Models.PasswordUpdateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.PasswordUpdateModel, Platy.AdventureWorks.Repository.Data.Entities.Password>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.PasswordReadModel, Platy.AdventureWorks.Repository.Domain.Models.PasswordUpdateModel>();

    }

}
