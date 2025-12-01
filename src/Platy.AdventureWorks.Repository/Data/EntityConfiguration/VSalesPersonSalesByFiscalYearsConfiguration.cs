using System;
using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;

namespace Platy.AdventureWorks.Repository.Data.EntityConfiguration;

/// <summary>
/// Allows configuration for an entity type <see cref="Platy.AdventureWorks.Repository.Data.Entities.VSalesPersonSalesByFiscalYears" />
/// </summary>
internal partial class VSalesPersonSalesByFiscalYearsConfiguration
    : IEntityTypeConfiguration<Platy.AdventureWorks.Repository.Data.Entities.VSalesPersonSalesByFiscalYears>
{
    /// <summary>
    /// Configures the entity of type <see cref="Platy.AdventureWorks.Repository.Data.Entities.VSalesPersonSalesByFiscalYears" />
    /// </summary>
    /// <param name="builder">The builder to be used to configure the entity type.</param>
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Platy.AdventureWorks.Repository.Data.Entities.VSalesPersonSalesByFiscalYears> builder)
    {
        #region Generated Configure
        // table
        builder.ToView("vSalesPersonSalesByFiscalYears", "Sales");

        // key
        builder.HasNoKey();

        // properties
        builder.Property(t => t.SalesPersonId)
            .HasColumnName("SalesPersonID")
            .HasColumnType("int");

        builder.Property(t => t.FullName)
            .HasColumnName("FullName")
            .HasColumnType("nvarchar(152)")
            .HasMaxLength(152);

        builder.Property(t => t.JobTitle)
            .IsRequired()
            .HasColumnName("JobTitle")
            .HasColumnType("nvarchar(50)")
            .HasMaxLength(50);

        builder.Property(t => t.SalesTerritory)
            .IsRequired()
            .HasColumnName("SalesTerritory")
            .HasColumnType("nvarchar(50)")
            .HasMaxLength(50);

        builder.Property(t => t.Number2002)
            .HasColumnName("2002")
            .HasColumnType("money");

        builder.Property(t => t.Number2003)
            .HasColumnName("2003")
            .HasColumnType("money");

        builder.Property(t => t.Number2004)
            .HasColumnName("2004")
            .HasColumnType("money");

        // relationships
        #endregion
    }

    #region Generated Constants
    internal readonly struct Table
    {
        /// <summary>Table Schema name constant for entity <see cref="Platy.AdventureWorks.Repository.Data.Entities.VSalesPersonSalesByFiscalYears" /></summary>
        public const string Schema = "Sales";
        /// <summary>Table Name constant for entity <see cref="Platy.AdventureWorks.Repository.Data.Entities.VSalesPersonSalesByFiscalYears" /></summary>
        public const string Name = "vSalesPersonSalesByFiscalYears";
    }

    internal readonly struct Columns
    {
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VSalesPersonSalesByFiscalYears.SalesPersonId" /></summary>
        public const string SalesPersonId = "SalesPersonID";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VSalesPersonSalesByFiscalYears.FullName" /></summary>
        public const string FullName = "FullName";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VSalesPersonSalesByFiscalYears.JobTitle" /></summary>
        public const string JobTitle = "JobTitle";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VSalesPersonSalesByFiscalYears.SalesTerritory" /></summary>
        public const string SalesTerritory = "SalesTerritory";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VSalesPersonSalesByFiscalYears.Number2002" /></summary>
        public const string Number2002 = "2002";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VSalesPersonSalesByFiscalYears.Number2003" /></summary>
        public const string Number2003 = "2003";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VSalesPersonSalesByFiscalYears.Number2004" /></summary>
        public const string Number2004 = "2004";
    }
    #endregion
}
