using System;
using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;

namespace Platy.AdventureWorks.Repository.Data.EntityConfiguration;

/// <summary>
/// Allows configuration for an entity type <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesTerritoryHistory" />
/// </summary>
internal partial class SalesTerritoryHistoryConfiguration
    : IEntityTypeConfiguration<Platy.AdventureWorks.Repository.Data.Entities.SalesTerritoryHistory>
{
    /// <summary>
    /// Configures the entity of type <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesTerritoryHistory" />
    /// </summary>
    /// <param name="builder">The builder to be used to configure the entity type.</param>
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Platy.AdventureWorks.Repository.Data.Entities.SalesTerritoryHistory> builder)
    {
        #region Generated Configure
        // table
        builder.ToTable("SalesTerritoryHistory", "Sales");

        // key
        builder.HasKey(t => new { t.BusinessEntityId, t.TerritoryId, t.StartDate });

        // properties
        builder.Property(t => t.BusinessEntityId)
            .IsRequired()
            .HasColumnName("BusinessEntityID")
            .HasColumnType("int");

        builder.Property(t => t.TerritoryId)
            .IsRequired()
            .HasColumnName("TerritoryID")
            .HasColumnType("int");

        builder.Property(t => t.StartDate)
            .IsRequired()
            .HasColumnName("StartDate")
            .HasColumnType("datetime");

        builder.Property(t => t.EndDate)
            .HasColumnName("EndDate")
            .HasColumnType("datetime");

        builder.Property(t => t.Rowguid)
            .IsRequired()
            .HasColumnName("rowguid")
            .HasColumnType("uniqueidentifier")
            .HasDefaultValueSql("(newid())");

        builder.Property(t => t.ModifiedDate)
            .IsRequired()
            .HasColumnName("ModifiedDate")
            .HasColumnType("datetime")
            .HasDefaultValueSql("(getdate())");

        // relationships
        builder.HasOne(t => t.SalesPerson)
            .WithMany(t => t.SalesTerritoryHistories)
            .HasForeignKey(d => d.BusinessEntityId)
            .HasConstraintName("FK_SalesTerritoryHistory_SalesPerson_BusinessEntityID");

        builder.HasOne(t => t.SalesTerritory)
            .WithMany(t => t.SalesTerritoryHistories)
            .HasForeignKey(d => d.TerritoryId)
            .HasConstraintName("FK_SalesTerritoryHistory_SalesTerritory_TerritoryID");

        #endregion
    }

    #region Generated Constants
    internal readonly struct Table
    {
        /// <summary>Table Schema name constant for entity <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesTerritoryHistory" /></summary>
        public const string Schema = "Sales";
        /// <summary>Table Name constant for entity <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesTerritoryHistory" /></summary>
        public const string Name = "SalesTerritoryHistory";
    }

    internal readonly struct Columns
    {
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesTerritoryHistory.BusinessEntityId" /></summary>
        public const string BusinessEntityId = "BusinessEntityID";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesTerritoryHistory.TerritoryId" /></summary>
        public const string TerritoryId = "TerritoryID";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesTerritoryHistory.StartDate" /></summary>
        public const string StartDate = "StartDate";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesTerritoryHistory.EndDate" /></summary>
        public const string EndDate = "EndDate";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesTerritoryHistory.Rowguid" /></summary>
        public const string Rowguid = "rowguid";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesTerritoryHistory.ModifiedDate" /></summary>
        public const string ModifiedDate = "ModifiedDate";
    }
    #endregion
}
