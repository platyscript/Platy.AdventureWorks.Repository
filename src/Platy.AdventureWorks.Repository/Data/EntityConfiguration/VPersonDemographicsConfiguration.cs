using System;
using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;

namespace Platy.AdventureWorks.Repository.Data.EntityConfiguration;

/// <summary>
/// Allows configuration for an entity type <see cref="Platy.AdventureWorks.Repository.Data.Entities.VPersonDemographics" />
/// </summary>
internal partial class VPersonDemographicsConfiguration
    : IEntityTypeConfiguration<Platy.AdventureWorks.Repository.Data.Entities.VPersonDemographics>
{
    /// <summary>
    /// Configures the entity of type <see cref="Platy.AdventureWorks.Repository.Data.Entities.VPersonDemographics" />
    /// </summary>
    /// <param name="builder">The builder to be used to configure the entity type.</param>
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Platy.AdventureWorks.Repository.Data.Entities.VPersonDemographics> builder)
    {
        #region Generated Configure
        // table
        builder.ToView("vPersonDemographics", "Sales");

        // key
        builder.HasNoKey();

        // properties
        builder.Property(t => t.BusinessEntityId)
            .IsRequired()
            .HasColumnName("BusinessEntityID")
            .HasColumnType("int");

        builder.Property(t => t.TotalPurchaseYTD)
            .HasColumnName("TotalPurchaseYTD")
            .HasColumnType("money");

        builder.Property(t => t.DateFirstPurchase)
            .HasColumnName("DateFirstPurchase")
            .HasColumnType("datetime");

        builder.Property(t => t.BirthDate)
            .HasColumnName("BirthDate")
            .HasColumnType("datetime");

        builder.Property(t => t.MaritalStatus)
            .HasColumnName("MaritalStatus")
            .HasColumnType("nvarchar(1)")
            .HasMaxLength(1);

        builder.Property(t => t.YearlyIncome)
            .HasColumnName("YearlyIncome")
            .HasColumnType("nvarchar(30)")
            .HasMaxLength(30);

        builder.Property(t => t.Gender)
            .HasColumnName("Gender")
            .HasColumnType("nvarchar(1)")
            .HasMaxLength(1);

        builder.Property(t => t.TotalChildren)
            .HasColumnName("TotalChildren")
            .HasColumnType("int");

        builder.Property(t => t.NumberChildrenAtHome)
            .HasColumnName("NumberChildrenAtHome")
            .HasColumnType("int");

        builder.Property(t => t.Education)
            .HasColumnName("Education")
            .HasColumnType("nvarchar(30)")
            .HasMaxLength(30);

        builder.Property(t => t.Occupation)
            .HasColumnName("Occupation")
            .HasColumnType("nvarchar(30)")
            .HasMaxLength(30);

        builder.Property(t => t.HomeOwnerFlag)
            .HasColumnName("HomeOwnerFlag")
            .HasColumnType("bit");

        builder.Property(t => t.NumberCarsOwned)
            .HasColumnName("NumberCarsOwned")
            .HasColumnType("int");

        // relationships
        #endregion
    }

    #region Generated Constants
    internal readonly struct Table
    {
        /// <summary>Table Schema name constant for entity <see cref="Platy.AdventureWorks.Repository.Data.Entities.VPersonDemographics" /></summary>
        public const string Schema = "Sales";
        /// <summary>Table Name constant for entity <see cref="Platy.AdventureWorks.Repository.Data.Entities.VPersonDemographics" /></summary>
        public const string Name = "vPersonDemographics";
    }

    internal readonly struct Columns
    {
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VPersonDemographics.BusinessEntityId" /></summary>
        public const string BusinessEntityId = "BusinessEntityID";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VPersonDemographics.TotalPurchaseYTD" /></summary>
        public const string TotalPurchaseYTD = "TotalPurchaseYTD";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VPersonDemographics.DateFirstPurchase" /></summary>
        public const string DateFirstPurchase = "DateFirstPurchase";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VPersonDemographics.BirthDate" /></summary>
        public const string BirthDate = "BirthDate";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VPersonDemographics.MaritalStatus" /></summary>
        public const string MaritalStatus = "MaritalStatus";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VPersonDemographics.YearlyIncome" /></summary>
        public const string YearlyIncome = "YearlyIncome";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VPersonDemographics.Gender" /></summary>
        public const string Gender = "Gender";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VPersonDemographics.TotalChildren" /></summary>
        public const string TotalChildren = "TotalChildren";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VPersonDemographics.NumberChildrenAtHome" /></summary>
        public const string NumberChildrenAtHome = "NumberChildrenAtHome";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VPersonDemographics.Education" /></summary>
        public const string Education = "Education";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VPersonDemographics.Occupation" /></summary>
        public const string Occupation = "Occupation";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VPersonDemographics.HomeOwnerFlag" /></summary>
        public const string HomeOwnerFlag = "HomeOwnerFlag";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VPersonDemographics.NumberCarsOwned" /></summary>
        public const string NumberCarsOwned = "NumberCarsOwned";
    }
    #endregion
}
