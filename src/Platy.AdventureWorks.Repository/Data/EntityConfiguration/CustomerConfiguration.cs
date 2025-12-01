using System;
using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;

namespace Platy.AdventureWorks.Repository.Data.EntityConfiguration;

/// <summary>
/// Allows configuration for an entity type <see cref="Platy.AdventureWorks.Repository.Data.Entities.Customer" />
/// </summary>
internal partial class CustomerConfiguration
    : IEntityTypeConfiguration<Platy.AdventureWorks.Repository.Data.Entities.Customer>
{
    /// <summary>
    /// Configures the entity of type <see cref="Platy.AdventureWorks.Repository.Data.Entities.Customer" />
    /// </summary>
    /// <param name="builder">The builder to be used to configure the entity type.</param>
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Platy.AdventureWorks.Repository.Data.Entities.Customer> builder)
    {
        #region Generated Configure
        // table
        builder.ToTable("Customer", "Sales");

        // key
        builder.HasKey(t => t.Id);

        // properties
        builder.Property(t => t.Id)
            .IsRequired()
            .HasColumnName("CustomerID")
            .HasColumnType("int")
            .ValueGeneratedOnAdd();

        builder.Property(t => t.PersonId)
            .HasColumnName("PersonID")
            .HasColumnType("int");

        builder.Property(t => t.StoreId)
            .HasColumnName("StoreID")
            .HasColumnType("int");

        builder.Property(t => t.TerritoryId)
            .HasColumnName("TerritoryID")
            .HasColumnType("int");

        builder.Property(t => t.AccountNumber)
            .IsRequired()
            .HasColumnName("AccountNumber")
            .HasColumnType("varchar(10)")
            .HasMaxLength(10)
            .ValueGeneratedOnAddOrUpdate();

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
        builder.HasOne(t => t.Person)
            .WithMany(t => t.Customers)
            .HasForeignKey(d => d.PersonId)
            .HasConstraintName("FK_Customer_Person_PersonID");

        builder.HasOne(t => t.SalesTerritory)
            .WithMany(t => t.Customers)
            .HasForeignKey(d => d.TerritoryId)
            .HasConstraintName("FK_Customer_SalesTerritory_TerritoryID");

        builder.HasOne(t => t.Store)
            .WithMany(t => t.Customers)
            .HasForeignKey(d => d.StoreId)
            .HasConstraintName("FK_Customer_Store_StoreID");

        #endregion
    }

    #region Generated Constants
    internal readonly struct Table
    {
        /// <summary>Table Schema name constant for entity <see cref="Platy.AdventureWorks.Repository.Data.Entities.Customer" /></summary>
        public const string Schema = "Sales";
        /// <summary>Table Name constant for entity <see cref="Platy.AdventureWorks.Repository.Data.Entities.Customer" /></summary>
        public const string Name = "Customer";
    }

    internal readonly struct Columns
    {
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.Customer.Id" /></summary>
        public const string Id = "CustomerID";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.Customer.PersonId" /></summary>
        public const string PersonId = "PersonID";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.Customer.StoreId" /></summary>
        public const string StoreId = "StoreID";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.Customer.TerritoryId" /></summary>
        public const string TerritoryId = "TerritoryID";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.Customer.AccountNumber" /></summary>
        public const string AccountNumber = "AccountNumber";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.Customer.Rowguid" /></summary>
        public const string Rowguid = "rowguid";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.Customer.ModifiedDate" /></summary>
        public const string ModifiedDate = "ModifiedDate";
    }
    #endregion
}
