using System;
using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;

namespace Platy.AdventureWorks.Repository.Data.EntityConfiguration;

/// <summary>
/// Allows configuration for an entity type <see cref="Platy.AdventureWorks.Repository.Data.Entities.BusinessEntityContact" />
/// </summary>
internal partial class BusinessEntityContactConfiguration
    : IEntityTypeConfiguration<Platy.AdventureWorks.Repository.Data.Entities.BusinessEntityContact>
{
    /// <summary>
    /// Configures the entity of type <see cref="Platy.AdventureWorks.Repository.Data.Entities.BusinessEntityContact" />
    /// </summary>
    /// <param name="builder">The builder to be used to configure the entity type.</param>
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Platy.AdventureWorks.Repository.Data.Entities.BusinessEntityContact> builder)
    {
        #region Generated Configure
        // table
        builder.ToTable("BusinessEntityContact", "Person");

        // key
        builder.HasKey(t => new { t.BusinessEntityId, t.PersonId, t.ContactTypeId });

        // properties
        builder.Property(t => t.BusinessEntityId)
            .IsRequired()
            .HasColumnName("BusinessEntityID")
            .HasColumnType("int");

        builder.Property(t => t.PersonId)
            .IsRequired()
            .HasColumnName("PersonID")
            .HasColumnType("int");

        builder.Property(t => t.ContactTypeId)
            .IsRequired()
            .HasColumnName("ContactTypeID")
            .HasColumnType("int");

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
        builder.HasOne(t => t.BusinessEntity)
            .WithMany(t => t.BusinessEntityContacts)
            .HasForeignKey(d => d.BusinessEntityId)
            .HasConstraintName("FK_BusinessEntityContact_BusinessEntity_BusinessEntityID");

        builder.HasOne(t => t.ContactType)
            .WithMany(t => t.BusinessEntityContacts)
            .HasForeignKey(d => d.ContactTypeId)
            .HasConstraintName("FK_BusinessEntityContact_ContactType_ContactTypeID");

        builder.HasOne(t => t.Person)
            .WithMany(t => t.BusinessEntityContacts)
            .HasForeignKey(d => d.PersonId)
            .HasConstraintName("FK_BusinessEntityContact_Person_PersonID");

        #endregion
    }

    #region Generated Constants
    internal readonly struct Table
    {
        /// <summary>Table Schema name constant for entity <see cref="Platy.AdventureWorks.Repository.Data.Entities.BusinessEntityContact" /></summary>
        public const string Schema = "Person";
        /// <summary>Table Name constant for entity <see cref="Platy.AdventureWorks.Repository.Data.Entities.BusinessEntityContact" /></summary>
        public const string Name = "BusinessEntityContact";
    }

    internal readonly struct Columns
    {
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.BusinessEntityContact.BusinessEntityId" /></summary>
        public const string BusinessEntityId = "BusinessEntityID";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.BusinessEntityContact.PersonId" /></summary>
        public const string PersonId = "PersonID";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.BusinessEntityContact.ContactTypeId" /></summary>
        public const string ContactTypeId = "ContactTypeID";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.BusinessEntityContact.Rowguid" /></summary>
        public const string Rowguid = "rowguid";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.BusinessEntityContact.ModifiedDate" /></summary>
        public const string ModifiedDate = "ModifiedDate";
    }
    #endregion
}
