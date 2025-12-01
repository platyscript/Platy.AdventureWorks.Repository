using System;
using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;

namespace Platy.AdventureWorks.Repository.Data.EntityConfiguration;

/// <summary>
/// Allows configuration for an entity type <see cref="Platy.AdventureWorks.Repository.Data.Entities.VIndividualCustomer" />
/// </summary>
internal partial class VIndividualCustomerConfiguration
    : IEntityTypeConfiguration<Platy.AdventureWorks.Repository.Data.Entities.VIndividualCustomer>
{
    /// <summary>
    /// Configures the entity of type <see cref="Platy.AdventureWorks.Repository.Data.Entities.VIndividualCustomer" />
    /// </summary>
    /// <param name="builder">The builder to be used to configure the entity type.</param>
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Platy.AdventureWorks.Repository.Data.Entities.VIndividualCustomer> builder)
    {
        #region Generated Configure
        // table
        builder.ToView("vIndividualCustomer", "Sales");

        // key
        builder.HasNoKey();

        // properties
        builder.Property(t => t.BusinessEntityId)
            .IsRequired()
            .HasColumnName("BusinessEntityID")
            .HasColumnType("int");

        builder.Property(t => t.Title)
            .HasColumnName("Title")
            .HasColumnType("nvarchar(8)")
            .HasMaxLength(8);

        builder.Property(t => t.FirstName)
            .IsRequired()
            .HasColumnName("FirstName")
            .HasColumnType("nvarchar(50)")
            .HasMaxLength(50);

        builder.Property(t => t.MiddleName)
            .HasColumnName("MiddleName")
            .HasColumnType("nvarchar(50)")
            .HasMaxLength(50);

        builder.Property(t => t.LastName)
            .IsRequired()
            .HasColumnName("LastName")
            .HasColumnType("nvarchar(50)")
            .HasMaxLength(50);

        builder.Property(t => t.Suffix)
            .HasColumnName("Suffix")
            .HasColumnType("nvarchar(10)")
            .HasMaxLength(10);

        builder.Property(t => t.PhoneNumber)
            .HasColumnName("PhoneNumber")
            .HasColumnType("nvarchar(25)")
            .HasMaxLength(25);

        builder.Property(t => t.PhoneNumberType)
            .HasColumnName("PhoneNumberType")
            .HasColumnType("nvarchar(50)")
            .HasMaxLength(50);

        builder.Property(t => t.EmailAddress)
            .HasColumnName("EmailAddress")
            .HasColumnType("nvarchar(50)")
            .HasMaxLength(50);

        builder.Property(t => t.EmailPromotion)
            .IsRequired()
            .HasColumnName("EmailPromotion")
            .HasColumnType("int");

        builder.Property(t => t.AddressType)
            .IsRequired()
            .HasColumnName("AddressType")
            .HasColumnType("nvarchar(50)")
            .HasMaxLength(50);

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

        builder.Property(t => t.StateProvinceName)
            .IsRequired()
            .HasColumnName("StateProvinceName")
            .HasColumnType("nvarchar(50)")
            .HasMaxLength(50);

        builder.Property(t => t.PostalCode)
            .IsRequired()
            .HasColumnName("PostalCode")
            .HasColumnType("nvarchar(15)")
            .HasMaxLength(15);

        builder.Property(t => t.CountryRegionName)
            .IsRequired()
            .HasColumnName("CountryRegionName")
            .HasColumnType("nvarchar(50)")
            .HasMaxLength(50);

        builder.Property(t => t.Demographics)
            .HasColumnName("Demographics")
            .HasColumnType("xml");

        // relationships
        #endregion
    }

    #region Generated Constants
    internal readonly struct Table
    {
        /// <summary>Table Schema name constant for entity <see cref="Platy.AdventureWorks.Repository.Data.Entities.VIndividualCustomer" /></summary>
        public const string Schema = "Sales";
        /// <summary>Table Name constant for entity <see cref="Platy.AdventureWorks.Repository.Data.Entities.VIndividualCustomer" /></summary>
        public const string Name = "vIndividualCustomer";
    }

    internal readonly struct Columns
    {
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VIndividualCustomer.BusinessEntityId" /></summary>
        public const string BusinessEntityId = "BusinessEntityID";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VIndividualCustomer.Title" /></summary>
        public const string Title = "Title";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VIndividualCustomer.FirstName" /></summary>
        public const string FirstName = "FirstName";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VIndividualCustomer.MiddleName" /></summary>
        public const string MiddleName = "MiddleName";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VIndividualCustomer.LastName" /></summary>
        public const string LastName = "LastName";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VIndividualCustomer.Suffix" /></summary>
        public const string Suffix = "Suffix";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VIndividualCustomer.PhoneNumber" /></summary>
        public const string PhoneNumber = "PhoneNumber";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VIndividualCustomer.PhoneNumberType" /></summary>
        public const string PhoneNumberType = "PhoneNumberType";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VIndividualCustomer.EmailAddress" /></summary>
        public const string EmailAddress = "EmailAddress";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VIndividualCustomer.EmailPromotion" /></summary>
        public const string EmailPromotion = "EmailPromotion";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VIndividualCustomer.AddressType" /></summary>
        public const string AddressType = "AddressType";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VIndividualCustomer.AddressLine1" /></summary>
        public const string AddressLine1 = "AddressLine1";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VIndividualCustomer.AddressLine2" /></summary>
        public const string AddressLine2 = "AddressLine2";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VIndividualCustomer.City" /></summary>
        public const string City = "City";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VIndividualCustomer.StateProvinceName" /></summary>
        public const string StateProvinceName = "StateProvinceName";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VIndividualCustomer.PostalCode" /></summary>
        public const string PostalCode = "PostalCode";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VIndividualCustomer.CountryRegionName" /></summary>
        public const string CountryRegionName = "CountryRegionName";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VIndividualCustomer.Demographics" /></summary>
        public const string Demographics = "Demographics";
    }
    #endregion
}
