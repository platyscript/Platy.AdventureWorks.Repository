using System;
using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;

namespace Platy.AdventureWorks.Repository.Data.EntityConfiguration;

/// <summary>
/// Allows configuration for an entity type <see cref="Platy.AdventureWorks.Repository.Data.Entities.PurchaseOrderHeader" />
/// </summary>
internal partial class PurchaseOrderHeaderConfiguration
    : IEntityTypeConfiguration<Platy.AdventureWorks.Repository.Data.Entities.PurchaseOrderHeader>
{
    /// <summary>
    /// Configures the entity of type <see cref="Platy.AdventureWorks.Repository.Data.Entities.PurchaseOrderHeader" />
    /// </summary>
    /// <param name="builder">The builder to be used to configure the entity type.</param>
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Platy.AdventureWorks.Repository.Data.Entities.PurchaseOrderHeader> builder)
    {
        #region Generated Configure
        // table
        builder.ToTable("PurchaseOrderHeader", "Purchasing");

        // key
        builder.HasKey(t => t.Id);

        // properties
        builder.Property(t => t.Id)
            .IsRequired()
            .HasColumnName("PurchaseOrderID")
            .HasColumnType("int")
            .ValueGeneratedOnAdd();

        builder.Property(t => t.RevisionNumber)
            .IsRequired()
            .HasColumnName("RevisionNumber")
            .HasColumnType("tinyint")
            .HasDefaultValue(0);

        builder.Property(t => t.Status)
            .IsRequired()
            .HasColumnName("Status")
            .HasColumnType("tinyint")
            .HasDefaultValue(1);

        builder.Property(t => t.EmployeeId)
            .IsRequired()
            .HasColumnName("EmployeeID")
            .HasColumnType("int");

        builder.Property(t => t.VendorId)
            .IsRequired()
            .HasColumnName("VendorID")
            .HasColumnType("int");

        builder.Property(t => t.ShipMethodId)
            .IsRequired()
            .HasColumnName("ShipMethodID")
            .HasColumnType("int");

        builder.Property(t => t.OrderDate)
            .IsRequired()
            .HasColumnName("OrderDate")
            .HasColumnType("datetime")
            .HasDefaultValueSql("(getdate())");

        builder.Property(t => t.ShipDate)
            .HasColumnName("ShipDate")
            .HasColumnType("datetime");

        builder.Property(t => t.SubTotal)
            .IsRequired()
            .HasColumnName("SubTotal")
            .HasColumnType("money")
            .HasDefaultValueSql("((0.00))");

        builder.Property(t => t.TaxAmt)
            .IsRequired()
            .HasColumnName("TaxAmt")
            .HasColumnType("money")
            .HasDefaultValueSql("((0.00))");

        builder.Property(t => t.Freight)
            .IsRequired()
            .HasColumnName("Freight")
            .HasColumnType("money")
            .HasDefaultValueSql("((0.00))");

        builder.Property(t => t.TotalDue)
            .IsRequired()
            .HasColumnName("TotalDue")
            .HasColumnType("money")
            .ValueGeneratedOnAddOrUpdate();

        builder.Property(t => t.ModifiedDate)
            .IsRequired()
            .HasColumnName("ModifiedDate")
            .HasColumnType("datetime")
            .HasDefaultValueSql("(getdate())");

        // relationships
        builder.HasOne(t => t.Employee)
            .WithMany(t => t.PurchaseOrderHeaders)
            .HasForeignKey(d => d.EmployeeId)
            .HasConstraintName("FK_PurchaseOrderHeader_Employee_EmployeeID");

        builder.HasOne(t => t.ShipMethod)
            .WithMany(t => t.PurchaseOrderHeaders)
            .HasForeignKey(d => d.ShipMethodId)
            .HasConstraintName("FK_PurchaseOrderHeader_ShipMethod_ShipMethodID");

        builder.HasOne(t => t.Vendor)
            .WithMany(t => t.PurchaseOrderHeaders)
            .HasForeignKey(d => d.VendorId)
            .HasConstraintName("FK_PurchaseOrderHeader_Vendor_VendorID");

        #endregion
    }

    #region Generated Constants
    internal readonly struct Table
    {
        /// <summary>Table Schema name constant for entity <see cref="Platy.AdventureWorks.Repository.Data.Entities.PurchaseOrderHeader" /></summary>
        public const string Schema = "Purchasing";
        /// <summary>Table Name constant for entity <see cref="Platy.AdventureWorks.Repository.Data.Entities.PurchaseOrderHeader" /></summary>
        public const string Name = "PurchaseOrderHeader";
    }

    internal readonly struct Columns
    {
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.PurchaseOrderHeader.Id" /></summary>
        public const string Id = "PurchaseOrderID";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.PurchaseOrderHeader.RevisionNumber" /></summary>
        public const string RevisionNumber = "RevisionNumber";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.PurchaseOrderHeader.Status" /></summary>
        public const string Status = "Status";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.PurchaseOrderHeader.EmployeeId" /></summary>
        public const string EmployeeId = "EmployeeID";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.PurchaseOrderHeader.VendorId" /></summary>
        public const string VendorId = "VendorID";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.PurchaseOrderHeader.ShipMethodId" /></summary>
        public const string ShipMethodId = "ShipMethodID";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.PurchaseOrderHeader.OrderDate" /></summary>
        public const string OrderDate = "OrderDate";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.PurchaseOrderHeader.ShipDate" /></summary>
        public const string ShipDate = "ShipDate";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.PurchaseOrderHeader.SubTotal" /></summary>
        public const string SubTotal = "SubTotal";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.PurchaseOrderHeader.TaxAmt" /></summary>
        public const string TaxAmt = "TaxAmt";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.PurchaseOrderHeader.Freight" /></summary>
        public const string Freight = "Freight";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.PurchaseOrderHeader.TotalDue" /></summary>
        public const string TotalDue = "TotalDue";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.PurchaseOrderHeader.ModifiedDate" /></summary>
        public const string ModifiedDate = "ModifiedDate";
    }
    #endregion
}
