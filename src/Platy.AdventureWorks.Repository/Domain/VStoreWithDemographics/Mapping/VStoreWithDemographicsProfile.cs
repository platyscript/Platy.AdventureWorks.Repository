using System;

using AutoMapper;

using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="VStoreWithDemographics"/> .
/// </summary>
public partial class VStoreWithDemographicsProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="VStoreWithDemographicsProfile"/> class.
    /// </summary>
    public VStoreWithDemographicsProfile()
    {
        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.VStoreWithDemographics, Platy.AdventureWorks.Repository.Domain.Models.VStoreWithDemographicsReadModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.VStoreWithDemographicsCreateModel, Platy.AdventureWorks.Repository.Data.Entities.VStoreWithDemographics>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.VStoreWithDemographics, Platy.AdventureWorks.Repository.Domain.Models.VStoreWithDemographicsCreateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.VStoreWithDemographics, Platy.AdventureWorks.Repository.Domain.Models.VStoreWithDemographicsUpdateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.VStoreWithDemographicsUpdateModel, Platy.AdventureWorks.Repository.Data.Entities.VStoreWithDemographics>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.VStoreWithDemographicsReadModel, Platy.AdventureWorks.Repository.Domain.Models.VStoreWithDemographicsUpdateModel>();

    }

}
