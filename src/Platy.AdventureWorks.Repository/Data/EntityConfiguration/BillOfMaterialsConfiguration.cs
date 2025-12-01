using System;
using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;

namespace Platy.AdventureWorks.Repository.Data.EntityConfiguration;

/// <summary>
/// Allows configuration for an entity type <see cref="Platy.AdventureWorks.Repository.Data.Entities.BillOfMaterials" />
/// </summary>
internal partial class BillOfMaterialsConfiguration
    : IEntityTypeConfiguration<Platy.AdventureWorks.Repository.Data.Entities.BillOfMaterials>
{
    /// <summary>
    /// Configures the entity of type <see cref="Platy.AdventureWorks.Repository.Data.Entities.BillOfMaterials" />
    /// </summary>
    /// <param name="builder">The builder to be used to configure the entity type.</param>
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Platy.AdventureWorks.Repository.Data.Entities.BillOfMaterials> builder)
    {
        #region Generated Configure
        // table
        builder.ToTable("BillOfMaterials", "Production");

        // key
        builder.HasKey(t => t.Id);

        // properties
        builder.Property(t => t.Id)
            .IsRequired()
            .HasColumnName("BillOfMaterialsID")
            .HasColumnType("int")
            .ValueGeneratedOnAdd();

        builder.Property(t => t.ProductAssemblyId)
            .HasColumnName("ProductAssemblyID")
            .HasColumnType("int");

        builder.Property(t => t.ComponentId)
            .IsRequired()
            .HasColumnName("ComponentID")
            .HasColumnType("int");

        builder.Property(t => t.StartDate)
            .IsRequired()
            .HasColumnName("StartDate")
            .HasColumnType("datetime")
            .HasDefaultValueSql("(getdate())");

        builder.Property(t => t.EndDate)
            .HasColumnName("EndDate")
            .HasColumnType("datetime");

        builder.Property(t => t.UnitMeasureCode)
            .IsRequired()
            .HasColumnName("UnitMeasureCode")
            .HasColumnType("nchar(3)")
            .HasMaxLength(3);

        builder.Property(t => t.BOMLevel)
            .IsRequired()
            .HasColumnName("BOMLevel")
            .HasColumnType("smallint");

        builder.Property(t => t.PerAssemblyQty)
            .IsRequired()
            .HasColumnName("PerAssemblyQty")
            .HasColumnType("decimal(8,2)")
            .HasDefaultValueSql("((1.00))");

        builder.Property(t => t.ModifiedDate)
            .IsRequired()
            .HasColumnName("ModifiedDate")
            .HasColumnType("datetime")
            .HasDefaultValueSql("(getdate())");

        // relationships
        builder.HasOne(t => t.ComponentProduct)
            .WithMany(t => t.ComponentBillOfMaterials)
            .HasForeignKey(d => d.ComponentId)
            .HasConstraintName("FK_BillOfMaterials_Product_ComponentID");

        builder.HasOne(t => t.AssemblyProduct)
            .WithMany(t => t.AssemblyBillOfMaterials)
            .HasForeignKey(d => d.ProductAssemblyId)
            .HasConstraintName("FK_BillOfMaterials_Product_ProductAssemblyID");

        builder.HasOne(t => t.UnitMeasure)
            .WithMany(t => t.BillOfMaterials)
            .HasForeignKey(d => d.UnitMeasureCode)
            .HasConstraintName("FK_BillOfMaterials_UnitMeasure_UnitMeasureCode");

        #endregion
    }

    #region Generated Constants
    internal readonly struct Table
    {
        /// <summary>Table Schema name constant for entity <see cref="Platy.AdventureWorks.Repository.Data.Entities.BillOfMaterials" /></summary>
        public const string Schema = "Production";
        /// <summary>Table Name constant for entity <see cref="Platy.AdventureWorks.Repository.Data.Entities.BillOfMaterials" /></summary>
        public const string Name = "BillOfMaterials";
    }

    internal readonly struct Columns
    {
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.BillOfMaterials.Id" /></summary>
        public const string Id = "BillOfMaterialsID";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.BillOfMaterials.ProductAssemblyId" /></summary>
        public const string ProductAssemblyId = "ProductAssemblyID";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.BillOfMaterials.ComponentId" /></summary>
        public const string ComponentId = "ComponentID";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.BillOfMaterials.StartDate" /></summary>
        public const string StartDate = "StartDate";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.BillOfMaterials.EndDate" /></summary>
        public const string EndDate = "EndDate";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.BillOfMaterials.UnitMeasureCode" /></summary>
        public const string UnitMeasureCode = "UnitMeasureCode";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.BillOfMaterials.BOMLevel" /></summary>
        public const string BOMLevel = "BOMLevel";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.BillOfMaterials.PerAssemblyQty" /></summary>
        public const string PerAssemblyQty = "PerAssemblyQty";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.BillOfMaterials.ModifiedDate" /></summary>
        public const string ModifiedDate = "ModifiedDate";
    }
    #endregion
}
