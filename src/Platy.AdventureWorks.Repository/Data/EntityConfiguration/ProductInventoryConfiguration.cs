using System;
using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;

namespace Platy.AdventureWorks.Repository.Data.EntityConfiguration;

/// <summary>
/// Allows configuration for an entity type <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductInventory" />
/// </summary>
internal partial class ProductInventoryConfiguration
    : IEntityTypeConfiguration<Platy.AdventureWorks.Repository.Data.Entities.ProductInventory>
{
    /// <summary>
    /// Configures the entity of type <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductInventory" />
    /// </summary>
    /// <param name="builder">The builder to be used to configure the entity type.</param>
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Platy.AdventureWorks.Repository.Data.Entities.ProductInventory> builder)
    {
        #region Generated Configure
        // table
        builder.ToTable("ProductInventory", "Production");

        // key
        builder.HasKey(t => new { t.ProductId, t.LocationId });

        // properties
        builder.Property(t => t.ProductId)
            .IsRequired()
            .HasColumnName("ProductID")
            .HasColumnType("int");

        builder.Property(t => t.LocationId)
            .IsRequired()
            .HasColumnName("LocationID")
            .HasColumnType("smallint");

        builder.Property(t => t.Shelf)
            .IsRequired()
            .HasColumnName("Shelf")
            .HasColumnType("nvarchar(10)")
            .HasMaxLength(10);

        builder.Property(t => t.Bin)
            .IsRequired()
            .HasColumnName("Bin")
            .HasColumnType("tinyint");

        builder.Property(t => t.Quantity)
            .IsRequired()
            .HasColumnName("Quantity")
            .HasColumnType("smallint")
            .HasDefaultValue(0);

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
        builder.HasOne(t => t.Location)
            .WithMany(t => t.ProductInventories)
            .HasForeignKey(d => d.LocationId)
            .HasConstraintName("FK_ProductInventory_Location_LocationID");

        builder.HasOne(t => t.Product)
            .WithMany(t => t.ProductInventories)
            .HasForeignKey(d => d.ProductId)
            .HasConstraintName("FK_ProductInventory_Product_ProductID");

        #endregion
    }

    #region Generated Constants
    internal readonly struct Table
    {
        /// <summary>Table Schema name constant for entity <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductInventory" /></summary>
        public const string Schema = "Production";
        /// <summary>Table Name constant for entity <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductInventory" /></summary>
        public const string Name = "ProductInventory";
    }

    internal readonly struct Columns
    {
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductInventory.ProductId" /></summary>
        public const string ProductId = "ProductID";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductInventory.LocationId" /></summary>
        public const string LocationId = "LocationID";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductInventory.Shelf" /></summary>
        public const string Shelf = "Shelf";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductInventory.Bin" /></summary>
        public const string Bin = "Bin";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductInventory.Quantity" /></summary>
        public const string Quantity = "Quantity";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductInventory.Rowguid" /></summary>
        public const string Rowguid = "rowguid";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductInventory.ModifiedDate" /></summary>
        public const string ModifiedDate = "ModifiedDate";
    }
    #endregion
}
