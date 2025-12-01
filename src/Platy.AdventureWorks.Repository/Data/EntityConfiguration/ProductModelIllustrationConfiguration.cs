using System;
using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;

namespace Platy.AdventureWorks.Repository.Data.EntityConfiguration;

/// <summary>
/// Allows configuration for an entity type <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductModelIllustration" />
/// </summary>
internal partial class ProductModelIllustrationConfiguration
    : IEntityTypeConfiguration<Platy.AdventureWorks.Repository.Data.Entities.ProductModelIllustration>
{
    /// <summary>
    /// Configures the entity of type <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductModelIllustration" />
    /// </summary>
    /// <param name="builder">The builder to be used to configure the entity type.</param>
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Platy.AdventureWorks.Repository.Data.Entities.ProductModelIllustration> builder)
    {
        #region Generated Configure
        // table
        builder.ToTable("ProductModelIllustration", "Production");

        // key
        builder.HasKey(t => new { t.ProductModelId, t.IllustrationId });

        // properties
        builder.Property(t => t.ProductModelId)
            .IsRequired()
            .HasColumnName("ProductModelID")
            .HasColumnType("int");

        builder.Property(t => t.IllustrationId)
            .IsRequired()
            .HasColumnName("IllustrationID")
            .HasColumnType("int");

        builder.Property(t => t.ModifiedDate)
            .IsRequired()
            .HasColumnName("ModifiedDate")
            .HasColumnType("datetime")
            .HasDefaultValueSql("(getdate())");

        // relationships
        builder.HasOne(t => t.Illustration)
            .WithMany(t => t.ProductModelIllustrations)
            .HasForeignKey(d => d.IllustrationId)
            .HasConstraintName("FK_ProductModelIllustration_Illustration_IllustrationID");

        builder.HasOne(t => t.ProductModel)
            .WithMany(t => t.ProductModelIllustrations)
            .HasForeignKey(d => d.ProductModelId)
            .HasConstraintName("FK_ProductModelIllustration_ProductModel_ProductModelID");

        #endregion
    }

    #region Generated Constants
    internal readonly struct Table
    {
        /// <summary>Table Schema name constant for entity <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductModelIllustration" /></summary>
        public const string Schema = "Production";
        /// <summary>Table Name constant for entity <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductModelIllustration" /></summary>
        public const string Name = "ProductModelIllustration";
    }

    internal readonly struct Columns
    {
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductModelIllustration.ProductModelId" /></summary>
        public const string ProductModelId = "ProductModelID";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductModelIllustration.IllustrationId" /></summary>
        public const string IllustrationId = "IllustrationID";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductModelIllustration.ModifiedDate" /></summary>
        public const string ModifiedDate = "ModifiedDate";
    }
    #endregion
}
