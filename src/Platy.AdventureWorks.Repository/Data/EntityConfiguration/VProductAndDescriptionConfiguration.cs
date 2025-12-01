using System;
using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;

namespace Platy.AdventureWorks.Repository.Data.EntityConfiguration;

/// <summary>
/// Allows configuration for an entity type <see cref="Platy.AdventureWorks.Repository.Data.Entities.VProductAndDescription" />
/// </summary>
internal partial class VProductAndDescriptionConfiguration
    : IEntityTypeConfiguration<Platy.AdventureWorks.Repository.Data.Entities.VProductAndDescription>
{
    /// <summary>
    /// Configures the entity of type <see cref="Platy.AdventureWorks.Repository.Data.Entities.VProductAndDescription" />
    /// </summary>
    /// <param name="builder">The builder to be used to configure the entity type.</param>
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Platy.AdventureWorks.Repository.Data.Entities.VProductAndDescription> builder)
    {
        #region Generated Configure
        // table
        builder.ToView("vProductAndDescription", "Production");

        // key
        builder.HasNoKey();

        // properties
        builder.Property(t => t.ProductId)
            .IsRequired()
            .HasColumnName("ProductID")
            .HasColumnType("int");

        builder.Property(t => t.Name)
            .IsRequired()
            .HasColumnName("Name")
            .HasColumnType("nvarchar(50)")
            .HasMaxLength(50);

        builder.Property(t => t.ProductModel)
            .IsRequired()
            .HasColumnName("ProductModel")
            .HasColumnType("nvarchar(50)")
            .HasMaxLength(50);

        builder.Property(t => t.CultureId)
            .IsRequired()
            .HasColumnName("CultureID")
            .HasColumnType("nchar(6)")
            .HasMaxLength(6);

        builder.Property(t => t.Description)
            .IsRequired()
            .HasColumnName("Description")
            .HasColumnType("nvarchar(400)")
            .HasMaxLength(400);

        // relationships
        #endregion
    }

    #region Generated Constants
    internal readonly struct Table
    {
        /// <summary>Table Schema name constant for entity <see cref="Platy.AdventureWorks.Repository.Data.Entities.VProductAndDescription" /></summary>
        public const string Schema = "Production";
        /// <summary>Table Name constant for entity <see cref="Platy.AdventureWorks.Repository.Data.Entities.VProductAndDescription" /></summary>
        public const string Name = "vProductAndDescription";
    }

    internal readonly struct Columns
    {
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VProductAndDescription.ProductId" /></summary>
        public const string ProductId = "ProductID";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VProductAndDescription.Name" /></summary>
        public const string Name = "Name";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VProductAndDescription.ProductModel" /></summary>
        public const string ProductModel = "ProductModel";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VProductAndDescription.CultureId" /></summary>
        public const string CultureId = "CultureID";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VProductAndDescription.Description" /></summary>
        public const string Description = "Description";
    }
    #endregion
}
