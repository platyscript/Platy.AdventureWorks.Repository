using System;
using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;

namespace Platy.AdventureWorks.Repository.Data.EntityConfiguration;

/// <summary>
/// Allows configuration for an entity type <see cref="Platy.AdventureWorks.Repository.Data.Entities.VProductModelCatalogDescription" />
/// </summary>
internal partial class VProductModelCatalogDescriptionConfiguration
    : IEntityTypeConfiguration<Platy.AdventureWorks.Repository.Data.Entities.VProductModelCatalogDescription>
{
    /// <summary>
    /// Configures the entity of type <see cref="Platy.AdventureWorks.Repository.Data.Entities.VProductModelCatalogDescription" />
    /// </summary>
    /// <param name="builder">The builder to be used to configure the entity type.</param>
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Platy.AdventureWorks.Repository.Data.Entities.VProductModelCatalogDescription> builder)
    {
        #region Generated Configure
        // table
        builder.ToView("vProductModelCatalogDescription", "Production");

        // key
        builder.HasNoKey();

        // properties
        builder.Property(t => t.Id)
            .IsRequired()
            .HasColumnName("ProductModelID")
            .HasColumnType("int")
            .ValueGeneratedOnAdd();

        builder.Property(t => t.Name)
            .IsRequired()
            .HasColumnName("Name")
            .HasColumnType("nvarchar(50)")
            .HasMaxLength(50);

        builder.Property(t => t.Summary)
            .HasColumnName("Summary")
            .HasColumnType("nvarchar(max)");

        builder.Property(t => t.Manufacturer)
            .HasColumnName("Manufacturer")
            .HasColumnType("nvarchar(max)");

        builder.Property(t => t.Copyright)
            .HasColumnName("Copyright")
            .HasColumnType("nvarchar(30)")
            .HasMaxLength(30);

        builder.Property(t => t.ProductURL)
            .HasColumnName("ProductURL")
            .HasColumnType("nvarchar(256)")
            .HasMaxLength(256);

        builder.Property(t => t.WarrantyPeriod)
            .HasColumnName("WarrantyPeriod")
            .HasColumnType("nvarchar(256)")
            .HasMaxLength(256);

        builder.Property(t => t.WarrantyDescription)
            .HasColumnName("WarrantyDescription")
            .HasColumnType("nvarchar(256)")
            .HasMaxLength(256);

        builder.Property(t => t.NoOfYears)
            .HasColumnName("NoOfYears")
            .HasColumnType("nvarchar(256)")
            .HasMaxLength(256);

        builder.Property(t => t.MaintenanceDescription)
            .HasColumnName("MaintenanceDescription")
            .HasColumnType("nvarchar(256)")
            .HasMaxLength(256);

        builder.Property(t => t.Wheel)
            .HasColumnName("Wheel")
            .HasColumnType("nvarchar(256)")
            .HasMaxLength(256);

        builder.Property(t => t.Saddle)
            .HasColumnName("Saddle")
            .HasColumnType("nvarchar(256)")
            .HasMaxLength(256);

        builder.Property(t => t.Pedal)
            .HasColumnName("Pedal")
            .HasColumnType("nvarchar(256)")
            .HasMaxLength(256);

        builder.Property(t => t.BikeFrame)
            .HasColumnName("BikeFrame")
            .HasColumnType("nvarchar(max)");

        builder.Property(t => t.Crankset)
            .HasColumnName("Crankset")
            .HasColumnType("nvarchar(256)")
            .HasMaxLength(256);

        builder.Property(t => t.PictureAngle)
            .HasColumnName("PictureAngle")
            .HasColumnType("nvarchar(256)")
            .HasMaxLength(256);

        builder.Property(t => t.PictureSize)
            .HasColumnName("PictureSize")
            .HasColumnType("nvarchar(256)")
            .HasMaxLength(256);

        builder.Property(t => t.ProductPhotoId)
            .HasColumnName("ProductPhotoID")
            .HasColumnType("nvarchar(256)")
            .HasMaxLength(256);

        builder.Property(t => t.Material)
            .HasColumnName("Material")
            .HasColumnType("nvarchar(256)")
            .HasMaxLength(256);

        builder.Property(t => t.Color)
            .HasColumnName("Color")
            .HasColumnType("nvarchar(256)")
            .HasMaxLength(256);

        builder.Property(t => t.ProductLine)
            .HasColumnName("ProductLine")
            .HasColumnType("nvarchar(256)")
            .HasMaxLength(256);

        builder.Property(t => t.Style)
            .HasColumnName("Style")
            .HasColumnType("nvarchar(256)")
            .HasMaxLength(256);

        builder.Property(t => t.RiderExperience)
            .HasColumnName("RiderExperience")
            .HasColumnType("nvarchar(1024)")
            .HasMaxLength(1024);

        builder.Property(t => t.Rowguid)
            .IsRequired()
            .HasColumnName("rowguid")
            .HasColumnType("uniqueidentifier");

        builder.Property(t => t.ModifiedDate)
            .IsRequired()
            .HasColumnName("ModifiedDate")
            .HasColumnType("datetime");

        // relationships
        #endregion
    }

    #region Generated Constants
    internal readonly struct Table
    {
        /// <summary>Table Schema name constant for entity <see cref="Platy.AdventureWorks.Repository.Data.Entities.VProductModelCatalogDescription" /></summary>
        public const string Schema = "Production";
        /// <summary>Table Name constant for entity <see cref="Platy.AdventureWorks.Repository.Data.Entities.VProductModelCatalogDescription" /></summary>
        public const string Name = "vProductModelCatalogDescription";
    }

    internal readonly struct Columns
    {
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VProductModelCatalogDescription.Id" /></summary>
        public const string Id = "ProductModelID";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VProductModelCatalogDescription.Name" /></summary>
        public const string Name = "Name";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VProductModelCatalogDescription.Summary" /></summary>
        public const string Summary = "Summary";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VProductModelCatalogDescription.Manufacturer" /></summary>
        public const string Manufacturer = "Manufacturer";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VProductModelCatalogDescription.Copyright" /></summary>
        public const string Copyright = "Copyright";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VProductModelCatalogDescription.ProductURL" /></summary>
        public const string ProductURL = "ProductURL";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VProductModelCatalogDescription.WarrantyPeriod" /></summary>
        public const string WarrantyPeriod = "WarrantyPeriod";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VProductModelCatalogDescription.WarrantyDescription" /></summary>
        public const string WarrantyDescription = "WarrantyDescription";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VProductModelCatalogDescription.NoOfYears" /></summary>
        public const string NoOfYears = "NoOfYears";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VProductModelCatalogDescription.MaintenanceDescription" /></summary>
        public const string MaintenanceDescription = "MaintenanceDescription";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VProductModelCatalogDescription.Wheel" /></summary>
        public const string Wheel = "Wheel";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VProductModelCatalogDescription.Saddle" /></summary>
        public const string Saddle = "Saddle";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VProductModelCatalogDescription.Pedal" /></summary>
        public const string Pedal = "Pedal";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VProductModelCatalogDescription.BikeFrame" /></summary>
        public const string BikeFrame = "BikeFrame";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VProductModelCatalogDescription.Crankset" /></summary>
        public const string Crankset = "Crankset";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VProductModelCatalogDescription.PictureAngle" /></summary>
        public const string PictureAngle = "PictureAngle";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VProductModelCatalogDescription.PictureSize" /></summary>
        public const string PictureSize = "PictureSize";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VProductModelCatalogDescription.ProductPhotoId" /></summary>
        public const string ProductPhotoId = "ProductPhotoID";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VProductModelCatalogDescription.Material" /></summary>
        public const string Material = "Material";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VProductModelCatalogDescription.Color" /></summary>
        public const string Color = "Color";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VProductModelCatalogDescription.ProductLine" /></summary>
        public const string ProductLine = "ProductLine";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VProductModelCatalogDescription.Style" /></summary>
        public const string Style = "Style";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VProductModelCatalogDescription.RiderExperience" /></summary>
        public const string RiderExperience = "RiderExperience";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VProductModelCatalogDescription.Rowguid" /></summary>
        public const string Rowguid = "rowguid";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VProductModelCatalogDescription.ModifiedDate" /></summary>
        public const string ModifiedDate = "ModifiedDate";
    }
    #endregion
}
