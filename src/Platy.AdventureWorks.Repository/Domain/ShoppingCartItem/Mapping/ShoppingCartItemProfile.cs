using System;

using AutoMapper;

using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="ShoppingCartItem"/> .
/// </summary>
public partial class ShoppingCartItemProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ShoppingCartItemProfile"/> class.
    /// </summary>
    public ShoppingCartItemProfile()
    {
        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.ShoppingCartItem, Platy.AdventureWorks.Repository.Domain.Models.ShoppingCartItemReadModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.ShoppingCartItemCreateModel, Platy.AdventureWorks.Repository.Data.Entities.ShoppingCartItem>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.ShoppingCartItem, Platy.AdventureWorks.Repository.Domain.Models.ShoppingCartItemCreateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.ShoppingCartItem, Platy.AdventureWorks.Repository.Domain.Models.ShoppingCartItemUpdateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.ShoppingCartItemUpdateModel, Platy.AdventureWorks.Repository.Data.Entities.ShoppingCartItem>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.ShoppingCartItemReadModel, Platy.AdventureWorks.Repository.Domain.Models.ShoppingCartItemUpdateModel>();

    }

}
