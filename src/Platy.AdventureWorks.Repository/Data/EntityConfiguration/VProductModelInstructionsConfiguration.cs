using System;
using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;

namespace Platy.AdventureWorks.Repository.Data.EntityConfiguration;

/// <summary>
/// Allows configuration for an entity type <see cref="Platy.AdventureWorks.Repository.Data.Entities.VProductModelInstructions" />
/// </summary>
internal partial class VProductModelInstructionsConfiguration
    : IEntityTypeConfiguration<Platy.AdventureWorks.Repository.Data.Entities.VProductModelInstructions>
{
    /// <summary>
    /// Configures the entity of type <see cref="Platy.AdventureWorks.Repository.Data.Entities.VProductModelInstructions" />
    /// </summary>
    /// <param name="builder">The builder to be used to configure the entity type.</param>
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Platy.AdventureWorks.Repository.Data.Entities.VProductModelInstructions> builder)
    {
        #region Generated Configure
        // table
        builder.ToView("vProductModelInstructions", "Production");

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

        builder.Property(t => t.Instructions)
            .HasColumnName("Instructions")
            .HasColumnType("nvarchar(max)");

        builder.Property(t => t.LocationId)
            .HasColumnName("LocationID")
            .HasColumnType("int");

        builder.Property(t => t.SetupHours)
            .HasColumnName("SetupHours")
            .HasColumnType("decimal(9,4)");

        builder.Property(t => t.MachineHours)
            .HasColumnName("MachineHours")
            .HasColumnType("decimal(9,4)");

        builder.Property(t => t.LaborHours)
            .HasColumnName("LaborHours")
            .HasColumnType("decimal(9,4)");

        builder.Property(t => t.LotSize)
            .HasColumnName("LotSize")
            .HasColumnType("int");

        builder.Property(t => t.Step)
            .HasColumnName("Step")
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
        /// <summary>Table Schema name constant for entity <see cref="Platy.AdventureWorks.Repository.Data.Entities.VProductModelInstructions" /></summary>
        public const string Schema = "Production";
        /// <summary>Table Name constant for entity <see cref="Platy.AdventureWorks.Repository.Data.Entities.VProductModelInstructions" /></summary>
        public const string Name = "vProductModelInstructions";
    }

    internal readonly struct Columns
    {
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VProductModelInstructions.Id" /></summary>
        public const string Id = "ProductModelID";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VProductModelInstructions.Name" /></summary>
        public const string Name = "Name";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VProductModelInstructions.Instructions" /></summary>
        public const string Instructions = "Instructions";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VProductModelInstructions.LocationId" /></summary>
        public const string LocationId = "LocationID";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VProductModelInstructions.SetupHours" /></summary>
        public const string SetupHours = "SetupHours";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VProductModelInstructions.MachineHours" /></summary>
        public const string MachineHours = "MachineHours";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VProductModelInstructions.LaborHours" /></summary>
        public const string LaborHours = "LaborHours";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VProductModelInstructions.LotSize" /></summary>
        public const string LotSize = "LotSize";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VProductModelInstructions.Step" /></summary>
        public const string Step = "Step";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VProductModelInstructions.Rowguid" /></summary>
        public const string Rowguid = "rowguid";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VProductModelInstructions.ModifiedDate" /></summary>
        public const string ModifiedDate = "ModifiedDate";
    }
    #endregion
}
