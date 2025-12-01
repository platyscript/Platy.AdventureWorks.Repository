using System;
using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;

namespace Platy.AdventureWorks.Repository.Data.EntityConfiguration;

/// <summary>
/// Allows configuration for an entity type <see cref="Platy.AdventureWorks.Repository.Data.Entities.Address" />
/// </summary>
internal partial class AddressConfiguration
    : IEntityTypeConfiguration<Platy.AdventureWorks.Repository.Data.Entities.Address>
{
    /// <summary>
    /// Configures the entity of type <see cref="Platy.AdventureWorks.Repository.Data.Entities.Address" />
    /// </summary>
    /// <param name="builder">The builder to be used to configure the entity type.</param>
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Platy.AdventureWorks.Repository.Data.Entities.Address> builder)
    {
        #region Generated Configure
        // table
        builder.ToTable("Address", "Person");

        // key
        builder.HasKey(t => t.Id);

        // properties
        builder.Property(t => t.Id)
            .IsRequired()
            .HasColumnName("AddressID")
            .HasColumnType("int")
            .ValueGeneratedOnAdd();

        builder.Property(t => t.AddressLine1)
            .IsRequired()
            .HasColumnName("AddressLine1")
            .HasColumnType("nvarchar(60)")
            .HasMaxLength(60);

        builder.Property(t => t.AddressLine2)
            .HasColumnName("AddressLine2")
            .HasColumnType("nvarchar(60)")
            .HasMaxLength(60);

        builder.Property(t => t.City)
            .IsRequired()
            .HasColumnName("City")
            .HasColumnType("nvarchar(30)")
            .HasMaxLength(30);

        builder.Property(t => t.StateProvinceId)
            .IsRequired()
            .HasColumnName("StateProvinceID")
            .HasColumnType("int");

        builder.Property(t => t.PostalCode)
            .IsRequired()
            .HasColumnName("PostalCode")
            .HasColumnType("nvarchar(15)")
            .HasMaxLength(15);

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
        builder.HasOne(t => t.StateProvince)
            .WithMany(t => t.Addresses)
            .HasForeignKey(d => d.StateProvinceId)
            .HasConstraintName("FK_Address_StateProvince_StateProvinceID");

        #endregion
    }

    #region Generated Constants
    internal readonly struct Table
    {
        /// <summary>Table Schema name constant for entity <see cref="Platy.AdventureWorks.Repository.Data.Entities.Address" /></summary>
        public const string Schema = "Person";
        /// <summary>Table Name constant for entity <see cref="Platy.AdventureWorks.Repository.Data.Entities.Address" /></summary>
        public const string Name = "Address";
    }

    internal readonly struct Columns
    {
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.Address.Id" /></summary>
        public const string Id = "AddressID";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.Address.AddressLine1" /></summary>
        public const string AddressLine1 = "AddressLine1";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.Address.AddressLine2" /></summary>
        public const string AddressLine2 = "AddressLine2";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.Address.City" /></summary>
        public const string City = "City";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.Address.StateProvinceId" /></summary>
        public const string StateProvinceId = "StateProvinceID";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.Address.PostalCode" /></summary>
        public const string PostalCode = "PostalCode";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.Address.Rowguid" /></summary>
        public const string Rowguid = "rowguid";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.Address.ModifiedDate" /></summary>
        public const string ModifiedDate = "ModifiedDate";
    }
    #endregion
}
