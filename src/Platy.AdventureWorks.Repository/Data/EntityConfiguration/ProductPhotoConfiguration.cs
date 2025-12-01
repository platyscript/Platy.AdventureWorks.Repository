using System;
using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;

namespace Platy.AdventureWorks.Repository.Data.EntityConfiguration;

/// <summary>
/// Allows configuration for an entity type <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductPhoto" />
/// </summary>
internal partial class ProductPhotoConfiguration
    : IEntityTypeConfiguration<Platy.AdventureWorks.Repository.Data.Entities.ProductPhoto>
{
    /// <summary>
    /// Configures the entity of type <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductPhoto" />
    /// </summary>
    /// <param name="builder">The builder to be used to configure the entity type.</param>
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Platy.AdventureWorks.Repository.Data.Entities.ProductPhoto> builder)
    {
        #region Generated Configure
        // table
        builder.ToTable("ProductPhoto", "Production");

        // key
        builder.HasKey(t => t.Id);

        // properties
        builder.Property(t => t.Id)
            .IsRequired()
            .HasColumnName("ProductPhotoID")
            .HasColumnType("int")
            .ValueGeneratedOnAdd();

        builder.Property(t => t.ThumbNailPhoto)
            .HasColumnName("ThumbNailPhoto")
            .HasColumnType("varbinary(max)");

        builder.Property(t => t.ThumbnailPhotoFileName)
            .HasColumnName("ThumbnailPhotoFileName")
            .HasColumnType("nvarchar(50)")
            .HasMaxLength(50);

        builder.Property(t => t.LargePhoto)
            .HasColumnName("LargePhoto")
            .HasColumnType("varbinary(max)");

        builder.Property(t => t.LargePhotoFileName)
            .HasColumnName("LargePhotoFileName")
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
        /// <summary>Table Schema name constant for entity <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductPhoto" /></summary>
        public const string Schema = "Production";
        /// <summary>Table Name constant for entity <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductPhoto" /></summary>
        public const string Name = "ProductPhoto";
    }

    internal readonly struct Columns
    {
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductPhoto.Id" /></summary>
        public const string Id = "ProductPhotoID";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductPhoto.ThumbNailPhoto" /></summary>
        public const string ThumbNailPhoto = "ThumbNailPhoto";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductPhoto.ThumbnailPhotoFileName" /></summary>
        public const string ThumbnailPhotoFileName = "ThumbnailPhotoFileName";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductPhoto.LargePhoto" /></summary>
        public const string LargePhoto = "LargePhoto";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductPhoto.LargePhotoFileName" /></summary>
        public const string LargePhotoFileName = "LargePhotoFileName";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductPhoto.ModifiedDate" /></summary>
        public const string ModifiedDate = "ModifiedDate";
    }
    #endregion
}
