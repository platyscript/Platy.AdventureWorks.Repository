using System;

using AutoMapper;

using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="VPersonDemographics"/> .
/// </summary>
public partial class VPersonDemographicsProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="VPersonDemographicsProfile"/> class.
    /// </summary>
    public VPersonDemographicsProfile()
    {
        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.VPersonDemographics, Platy.AdventureWorks.Repository.Domain.Models.VPersonDemographicsReadModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.VPersonDemographicsCreateModel, Platy.AdventureWorks.Repository.Data.Entities.VPersonDemographics>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.VPersonDemographics, Platy.AdventureWorks.Repository.Domain.Models.VPersonDemographicsCreateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.VPersonDemographics, Platy.AdventureWorks.Repository.Domain.Models.VPersonDemographicsUpdateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.VPersonDemographicsUpdateModel, Platy.AdventureWorks.Repository.Data.Entities.VPersonDemographics>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.VPersonDemographicsReadModel, Platy.AdventureWorks.Repository.Domain.Models.VPersonDemographicsUpdateModel>();

    }

}
