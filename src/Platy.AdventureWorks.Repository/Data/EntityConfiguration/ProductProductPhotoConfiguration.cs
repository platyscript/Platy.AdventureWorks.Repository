using System;
using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;

namespace Platy.AdventureWorks.Repository.Data.EntityConfiguration;

/// <summary>
/// Allows configuration for an entity type <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductProductPhoto" />
/// </summary>
internal partial class ProductProductPhotoConfiguration
    : IEntityTypeConfiguration<Platy.AdventureWorks.Repository.Data.Entities.ProductProductPhoto>
{
    /// <summary>
    /// Configures the entity of type <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductProductPhoto" />
    /// </summary>
    /// <param name="builder">The builder to be used to configure the entity type.</param>
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Platy.AdventureWorks.Repository.Data.Entities.ProductProductPhoto> builder)
    {
        #region Generated Configure
        // table
        builder.ToTable("ProductProductPhoto", "Production");

        // key
        builder.HasKey(t => new { t.ProductId, t.ProductPhotoId });

        // properties
        builder.Property(t => t.ProductId)
            .IsRequired()
            .HasColumnName("ProductID")
            .HasColumnType("int");

        builder.Property(t => t.ProductPhotoId)
            .IsRequired()
            .HasColumnName("ProductPhotoID")
            .HasColumnType("int");

        builder.Property(t => t.Primary)
            .IsRequired()
            .HasColumnName("Primary")
            .HasColumnType("bit")
            .HasDefaultValue(false);

        builder.Property(t => t.ModifiedDate)
            .IsRequired()
            .HasColumnName("ModifiedDate")
            .HasColumnType("datetime")
            .HasDefaultValueSql("(getdate())");

        // relationships
        builder.HasOne(t => t.Product)
            .WithMany(t => t.ProductProductPhotos)
            .HasForeignKey(d => d.ProductId)
            .HasConstraintName("FK_ProductProductPhoto_Product_ProductID");

        builder.HasOne(t => t.ProductPhoto)
            .WithMany(t => t.ProductProductPhotos)
            .HasForeignKey(d => d.ProductPhotoId)
            .HasConstraintName("FK_ProductProductPhoto_ProductPhoto_ProductPhotoID");

        #endregion
    }

    #region Generated Constants
    internal readonly struct Table
    {
        /// <summary>Table Schema name constant for entity <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductProductPhoto" /></summary>
        public const string Schema = "Production";
        /// <summary>Table Name constant for entity <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductProductPhoto" /></summary>
        public const string Name = "ProductProductPhoto";
    }

    internal readonly struct Columns
    {
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductProductPhoto.ProductId" /></summary>
        public const string ProductId = "ProductID";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductProductPhoto.ProductPhotoId" /></summary>
        public const string ProductPhotoId = "ProductPhotoID";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductProductPhoto.Primary" /></summary>
        public const string Primary = "Primary";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductProductPhoto.ModifiedDate" /></summary>
        public const string ModifiedDate = "ModifiedDate";
    }
    #endregion
}
