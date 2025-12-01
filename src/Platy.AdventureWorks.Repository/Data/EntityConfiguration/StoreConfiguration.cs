using System;
using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;

namespace Platy.AdventureWorks.Repository.Data.EntityConfiguration;

/// <summary>
/// Allows configuration for an entity type <see cref="Platy.AdventureWorks.Repository.Data.Entities.Store" />
/// </summary>
internal partial class StoreConfiguration
    : IEntityTypeConfiguration<Platy.AdventureWorks.Repository.Data.Entities.Store>
{
    /// <summary>
    /// Configures the entity of type <see cref="Platy.AdventureWorks.Repository.Data.Entities.Store" />
    /// </summary>
    /// <param name="builder">The builder to be used to configure the entity type.</param>
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Platy.AdventureWorks.Repository.Data.Entities.Store> builder)
    {
        #region Generated Configure
        // table
        builder.ToTable("Store", "Sales");

        // key
        builder.HasKey(t => t.BusinessEntityId);

        // properties
        builder.Property(t => t.BusinessEntityId)
            .IsRequired()
            .HasColumnName("BusinessEntityID")
            .HasColumnType("int");

        builder.Property(t => t.Name)
            .IsRequired()
            .HasColumnName("Name")
            .HasColumnType("nvarchar(50)")
            .HasMaxLength(50);

        builder.Property(t => t.SalesPersonId)
            .HasColumnName("SalesPersonID")
            .HasColumnType("int");

        builder.Property(t => t.Demographics)
            .HasColumnName("Demographics")
            .HasColumnType("xml");

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
        builder.HasOne(t => t.BusinessEntity)
            .WithOne(t => t.Store)
            .HasForeignKey<Platy.AdventureWorks.Repository.Data.Entities.Store>(d => d.BusinessEntityId)
            .HasConstraintName("FK_Store_BusinessEntity_BusinessEntityID");

        builder.HasOne(t => t.SalesPerson)
            .WithMany(t => t.Stores)
            .HasForeignKey(d => d.SalesPersonId)
            .HasConstraintName("FK_Store_SalesPerson_SalesPersonID");

        #endregion
    }

    #region Generated Constants
    internal readonly struct Table
    {
        /// <summary>Table Schema name constant for entity <see cref="Platy.AdventureWorks.Repository.Data.Entities.Store" /></summary>
        public const string Schema = "Sales";
        /// <summary>Table Name constant for entity <see cref="Platy.AdventureWorks.Repository.Data.Entities.Store" /></summary>
        public const string Name = "Store";
    }

    internal readonly struct Columns
    {
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.Store.BusinessEntityId" /></summary>
        public const string BusinessEntityId = "BusinessEntityID";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.Store.Name" /></summary>
        public const string Name = "Name";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.Store.SalesPersonId" /></summary>
        public const string SalesPersonId = "SalesPersonID";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.Store.Demographics" /></summary>
        public const string Demographics = "Demographics";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.Store.Rowguid" /></summary>
        public const string Rowguid = "rowguid";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.Store.ModifiedDate" /></summary>
        public const string ModifiedDate = "ModifiedDate";
    }
    #endregion
}
