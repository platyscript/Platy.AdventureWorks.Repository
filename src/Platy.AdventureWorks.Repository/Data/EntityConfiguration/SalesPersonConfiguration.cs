using System;
using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;

namespace Platy.AdventureWorks.Repository.Data.EntityConfiguration;

/// <summary>
/// Allows configuration for an entity type <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesPerson" />
/// </summary>
internal partial class SalesPersonConfiguration
    : IEntityTypeConfiguration<Platy.AdventureWorks.Repository.Data.Entities.SalesPerson>
{
    /// <summary>
    /// Configures the entity of type <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesPerson" />
    /// </summary>
    /// <param name="builder">The builder to be used to configure the entity type.</param>
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Platy.AdventureWorks.Repository.Data.Entities.SalesPerson> builder)
    {
        #region Generated Configure
        // table
        builder.ToTable("SalesPerson", "Sales");

        // key
        builder.HasKey(t => t.BusinessEntityId);

        // properties
        builder.Property(t => t.BusinessEntityId)
            .IsRequired()
            .HasColumnName("BusinessEntityID")
            .HasColumnType("int");

        builder.Property(t => t.TerritoryId)
            .HasColumnName("TerritoryID")
            .HasColumnType("int");

        builder.Property(t => t.SalesQuota)
            .HasColumnName("SalesQuota")
            .HasColumnType("money");

        builder.Property(t => t.Bonus)
            .IsRequired()
            .HasColumnName("Bonus")
            .HasColumnType("money")
            .HasDefaultValueSql("((0.00))");

        builder.Property(t => t.CommissionPct)
            .IsRequired()
            .HasColumnName("CommissionPct")
            .HasColumnType("smallmoney")
            .HasDefaultValueSql("((0.00))");

        builder.Property(t => t.SalesYTD)
            .IsRequired()
            .HasColumnName("SalesYTD")
            .HasColumnType("money")
            .HasDefaultValueSql("((0.00))");

        builder.Property(t => t.SalesLastYear)
            .IsRequired()
            .HasColumnName("SalesLastYear")
            .HasColumnType("money")
            .HasDefaultValueSql("((0.00))");

        builder.Property(t => t.Rowguid)
            .IsRequired()
            .HasColumnName("rowguid")
            .HasColumnType("uniqueidentifier")
            .HasDefaultValueSql("(newid())");

        builder.Property(t => t.ModifiedDate)
            .IsRequired()
            .HasColumnName("ModifiedDate")
            .HasColumnType("datetime")
            .HasDefaultValueSql("(getdate())");

        // relationships
        builder.HasOne(t => t.Employee)
            .WithOne(t => t.SalesPerson)
            .HasForeignKey<Platy.AdventureWorks.Repository.Data.Entities.SalesPerson>(d => d.BusinessEntityId)
            .HasConstraintName("FK_SalesPerson_Employee_BusinessEntityID");

        builder.HasOne(t => t.SalesTerritory)
            .WithMany(t => t.SalesPeople)
            .HasForeignKey(d => d.TerritoryId)
            .HasConstraintName("FK_SalesPerson_SalesTerritory_TerritoryID");

        #endregion
    }

    #region Generated Constants
    internal readonly struct Table
    {
        /// <summary>Table Schema name constant for entity <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesPerson" /></summary>
        public const string Schema = "Sales";
        /// <summary>Table Name constant for entity <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesPerson" /></summary>
        public const string Name = "SalesPerson";
    }

    internal readonly struct Columns
    {
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesPerson.BusinessEntityId" /></summary>
        public const string BusinessEntityId = "BusinessEntityID";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesPerson.TerritoryId" /></summary>
        public const string TerritoryId = "TerritoryID";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesPerson.SalesQuota" /></summary>
        public const string SalesQuota = "SalesQuota";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesPerson.Bonus" /></summary>
        public const string Bonus = "Bonus";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesPerson.CommissionPct" /></summary>
        public const string CommissionPct = "CommissionPct";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesPerson.SalesYTD" /></summary>
        public const string SalesYTD = "SalesYTD";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesPerson.SalesLastYear" /></summary>
        public const string SalesLastYear = "SalesLastYear";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesPerson.Rowguid" /></summary>
        public const string Rowguid = "rowguid";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesPerson.ModifiedDate" /></summary>
        public const string ModifiedDate = "ModifiedDate";
    }
    #endregion
}
