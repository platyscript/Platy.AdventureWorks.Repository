using System;
using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;

namespace Platy.AdventureWorks.Repository.Data.EntityConfiguration;

/// <summary>
/// Allows configuration for an entity type <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductListPriceHistory" />
/// </summary>
internal partial class ProductListPriceHistoryConfiguration
    : IEntityTypeConfiguration<Platy.AdventureWorks.Repository.Data.Entities.ProductListPriceHistory>
{
    /// <summary>
    /// Configures the entity of type <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductListPriceHistory" />
    /// </summary>
    /// <param name="builder">The builder to be used to configure the entity type.</param>
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Platy.AdventureWorks.Repository.Data.Entities.ProductListPriceHistory> builder)
    {
        #region Generated Configure
        // table
        builder.ToTable("ProductListPriceHistory", "Production");

        // key
        builder.HasKey(t => new { t.ProductId, t.StartDate });

        // properties
        builder.Property(t => t.ProductId)
            .IsRequired()
            .HasColumnName("ProductID")
            .HasColumnType("int");

        builder.Property(t => t.StartDate)
            .IsRequired()
            .HasColumnName("StartDate")
            .HasColumnType("datetime");

        builder.Property(t => t.EndDate)
            .HasColumnName("EndDate")
            .HasColumnType("datetime");

        builder.Property(t => t.ListPrice)
            .IsRequired()
            .HasColumnName("ListPrice")
            .HasColumnType("money");

        builder.Property(t => t.ModifiedDate)
            .IsRequired()
            .HasColumnName("ModifiedDate")
            .HasColumnType("datetime")
            .HasDefaultValueSql("(getdate())");

        // relationships
        builder.HasOne(t => t.Product)
            .WithMany(t => t.ProductListPriceHistories)
            .HasForeignKey(d => d.ProductId)
            .HasConstraintName("FK_ProductListPriceHistory_Product_ProductID");

        #endregion
    }

    #region Generated Constants
    internal readonly struct Table
    {
        /// <summary>Table Schema name constant for entity <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductListPriceHistory" /></summary>
        public const string Schema = "Production";
        /// <summary>Table Name constant for entity <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductListPriceHistory" /></summary>
        public const string Name = "ProductListPriceHistory";
    }

    internal readonly struct Columns
    {
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductListPriceHistory.ProductId" /></summary>
        public const string ProductId = "ProductID";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductListPriceHistory.StartDate" /></summary>
        public const string StartDate = "StartDate";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductListPriceHistory.EndDate" /></summary>
        public const string EndDate = "EndDate";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductListPriceHistory.ListPrice" /></summary>
        public const string ListPrice = "ListPrice";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductListPriceHistory.ModifiedDate" /></summary>
        public const string ModifiedDate = "ModifiedDate";
    }
    #endregion
}
