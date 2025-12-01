using System;
using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;

namespace Platy.AdventureWorks.Repository.Data.EntityConfiguration;

/// <summary>
/// Allows configuration for an entity type <see cref="Platy.AdventureWorks.Repository.Data.Entities.CountryRegion" />
/// </summary>
internal partial class CountryRegionConfiguration
    : IEntityTypeConfiguration<Platy.AdventureWorks.Repository.Data.Entities.CountryRegion>
{
    /// <summary>
    /// Configures the entity of type <see cref="Platy.AdventureWorks.Repository.Data.Entities.CountryRegion" />
    /// </summary>
    /// <param name="builder">The builder to be used to configure the entity type.</param>
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Platy.AdventureWorks.Repository.Data.Entities.CountryRegion> builder)
    {
        #region Generated Configure
        // table
        builder.ToTable("CountryRegion", "Person");

        // key
        builder.HasKey(t => t.CountryRegionCode);

        // properties
        builder.Property(t => t.CountryRegionCode)
            .IsRequired()
            .HasColumnName("CountryRegionCode")
            .HasColumnType("nvarchar(3)")
            .HasMaxLength(3);

        builder.Property(t => t.Name)
            .IsRequired()
            .HasColumnName("Name")
            .HasColumnType("nvarchar(50)")
            .HasMaxLength(50);

        builder.Property(t => t.ModifiedDate)
            .IsRequired()
            .HasColumnName("ModifiedDate")
            .HasColumnType("datetime")
            .HasDefaultValueSql("(getdate())");

        // relationships
        #endregion
    }

    #region Generated Constants
    internal readonly struct Table
    {
        /// <summary>Table Schema name constant for entity <see cref="Platy.AdventureWorks.Repository.Data.Entities.CountryRegion" /></summary>
        public const string Schema = "Person";
        /// <summary>Table Name constant for entity <see cref="Platy.AdventureWorks.Repository.Data.Entities.CountryRegion" /></summary>
        public const string Name = "CountryRegion";
    }

    internal readonly struct Columns
    {
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.CountryRegion.CountryRegionCode" /></summary>
        public const string CountryRegionCode = "CountryRegionCode";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.CountryRegion.Name" /></summary>
        public const string Name = "Name";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.CountryRegion.ModifiedDate" /></summary>
        public const string ModifiedDate = "ModifiedDate";
    }
    #endregion
}
