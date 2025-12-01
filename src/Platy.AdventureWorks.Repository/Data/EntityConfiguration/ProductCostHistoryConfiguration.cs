using System;
using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;

namespace Platy.AdventureWorks.Repository.Data.EntityConfiguration;

/// <summary>
/// Allows configuration for an entity type <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductCostHistory" />
/// </summary>
internal partial class ProductCostHistoryConfiguration
    : IEntityTypeConfiguration<Platy.AdventureWorks.Repository.Data.Entities.ProductCostHistory>
{
    /// <summary>
    /// Configures the entity of type <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductCostHistory" />
    /// </summary>
    /// <param name="builder">The builder to be used to configure the entity type.</param>
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Platy.AdventureWorks.Repository.Data.Entities.ProductCostHistory> builder)
    {
        #region Generated Configure
        // table
        builder.ToTable("ProductCostHistory", "Production");

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

        builder.Property(t => t.StandardCost)
            .IsRequired()
            .HasColumnName("StandardCost")
            .HasColumnType("money");

        builder.Property(t => t.ModifiedDate)
            .IsRequired()
            .HasColumnName("ModifiedDate")
            .HasColumnType("datetime")
            .HasDefaultValueSql("(getdate())");

        // relationships
        builder.HasOne(t => t.Product)
            .WithMany(t => t.ProductCostHistories)
            .HasForeignKey(d => d.ProductId)
            .HasConstraintName("FK_ProductCostHistory_Product_ProductID");

        #endregion
    }

    #region Generated Constants
    internal readonly struct Table
    {
        /// <summary>Table Schema name constant for entity <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductCostHistory" /></summary>
        public const string Schema = "Production";
        /// <summary>Table Name constant for entity <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductCostHistory" /></summary>
        public const string Name = "ProductCostHistory";
    }

    internal readonly struct Columns
    {
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductCostHistory.ProductId" /></summary>
        public const string ProductId = "ProductID";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductCostHistory.StartDate" /></summary>
        public const string StartDate = "StartDate";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductCostHistory.EndDate" /></summary>
        public const string EndDate = "EndDate";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductCostHistory.StandardCost" /></summary>
        public const string StandardCost = "StandardCost";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductCostHistory.ModifiedDate" /></summary>
        public const string ModifiedDate = "ModifiedDate";
    }
    #endregion
}
