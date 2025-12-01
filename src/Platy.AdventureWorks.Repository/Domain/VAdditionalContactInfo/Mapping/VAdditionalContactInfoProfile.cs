using System;

using AutoMapper;

using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="VAdditionalContactInfo"/> .
/// </summary>
public partial class VAdditionalContactInfoProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="VAdditionalContactInfoProfile"/> class.
    /// </summary>
    public VAdditionalContactInfoProfile()
    {
        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.VAdditionalContactInfo, Platy.AdventureWorks.Repository.Domain.Models.VAdditionalContactInfoReadModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.VAdditionalContactInfoCreateModel, Platy.AdventureWorks.Repository.Data.Entities.VAdditionalContactInfo>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.VAdditionalContactInfo, Platy.AdventureWorks.Repository.Domain.Models.VAdditionalContactInfoCreateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.VAdditionalContactInfo, Platy.AdventureWorks.Repository.Domain.Models.VAdditionalContactInfoUpdateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.VAdditionalContactInfoUpdateModel, Platy.AdventureWorks.Repository.Data.Entities.VAdditionalContactInfo>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.VAdditionalContactInfoReadModel, Platy.AdventureWorks.Repository.Domain.Models.VAdditionalContactInfoUpdateModel>();

    }

}
