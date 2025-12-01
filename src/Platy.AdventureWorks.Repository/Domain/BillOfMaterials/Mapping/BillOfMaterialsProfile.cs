using System;

using AutoMapper;

using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="BillOfMaterials"/> .
/// </summary>
public partial class BillOfMaterialsProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BillOfMaterialsProfile"/> class.
    /// </summary>
    public BillOfMaterialsProfile()
    {
        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.BillOfMaterials, Platy.AdventureWorks.Repository.Domain.Models.BillOfMaterialsReadModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.BillOfMaterialsCreateModel, Platy.AdventureWorks.Repository.Data.Entities.BillOfMaterials>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.BillOfMaterials, Platy.AdventureWorks.Repository.Domain.Models.BillOfMaterialsCreateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.BillOfMaterials, Platy.AdventureWorks.Repository.Domain.Models.BillOfMaterialsUpdateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.BillOfMaterialsUpdateModel, Platy.AdventureWorks.Repository.Data.Entities.BillOfMaterials>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.BillOfMaterialsReadModel, Platy.AdventureWorks.Repository.Domain.Models.BillOfMaterialsUpdateModel>();

    }

}
