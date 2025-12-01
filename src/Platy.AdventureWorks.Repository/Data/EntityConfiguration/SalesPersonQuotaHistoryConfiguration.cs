using System;
using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;

namespace Platy.AdventureWorks.Repository.Data.EntityConfiguration;

/// <summary>
/// Allows configuration for an entity type <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesPersonQuotaHistory" />
/// </summary>
internal partial class SalesPersonQuotaHistoryConfiguration
    : IEntityTypeConfiguration<Platy.AdventureWorks.Repository.Data.Entities.SalesPersonQuotaHistory>
{
    /// <summary>
    /// Configures the entity of type <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesPersonQuotaHistory" />
    /// </summary>
    /// <param name="builder">The builder to be used to configure the entity type.</param>
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Platy.AdventureWorks.Repository.Data.Entities.SalesPersonQuotaHistory> builder)
    {
        #region Generated Configure
        // table
        builder.ToTable("SalesPersonQuotaHistory", "Sales");

        // key
        builder.HasKey(t => new { t.BusinessEntityId, t.QuotaDate });

        // properties
        builder.Property(t => t.BusinessEntityId)
            .IsRequired()
            .HasColumnName("BusinessEntityID")
            .HasColumnType("int");

        builder.Property(t => t.QuotaDate)
            .IsRequired()
            .HasColumnName("QuotaDate")
            .HasColumnType("datetime");

        builder.Property(t => t.SalesQuota)
            .IsRequired()
            .HasColumnName("SalesQuota")
            .HasColumnType("money");

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
        builder.HasOne(t => t.SalesPerson)
            .WithMany(t => t.SalesPersonQuotaHistories)
            .HasForeignKey(d => d.BusinessEntityId)
            .HasConstraintName("FK_SalesPersonQuotaHistory_SalesPerson_BusinessEntityID");

        #endregion
    }

    #region Generated Constants
    internal readonly struct Table
    {
        /// <summary>Table Schema name constant for entity <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesPersonQuotaHistory" /></summary>
        public const string Schema = "Sales";
        /// <summary>Table Name constant for entity <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesPersonQuotaHistory" /></summary>
        public const string Name = "SalesPersonQuotaHistory";
    }

    internal readonly struct Columns
    {
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesPersonQuotaHistory.BusinessEntityId" /></summary>
        public const string BusinessEntityId = "BusinessEntityID";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesPersonQuotaHistory.QuotaDate" /></summary>
        public const string QuotaDate = "QuotaDate";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesPersonQuotaHistory.SalesQuota" /></summary>
        public const string SalesQuota = "SalesQuota";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesPersonQuotaHistory.Rowguid" /></summary>
        public const string Rowguid = "rowguid";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesPersonQuotaHistory.ModifiedDate" /></summary>
        public const string ModifiedDate = "ModifiedDate";
    }
    #endregion
}
