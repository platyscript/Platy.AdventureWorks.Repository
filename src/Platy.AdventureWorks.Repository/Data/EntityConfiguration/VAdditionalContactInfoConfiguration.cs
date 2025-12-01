using System;
using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;

namespace Platy.AdventureWorks.Repository.Data.EntityConfiguration;

/// <summary>
/// Allows configuration for an entity type <see cref="Platy.AdventureWorks.Repository.Data.Entities.VAdditionalContactInfo" />
/// </summary>
internal partial class VAdditionalContactInfoConfiguration
    : IEntityTypeConfiguration<Platy.AdventureWorks.Repository.Data.Entities.VAdditionalContactInfo>
{
    /// <summary>
    /// Configures the entity of type <see cref="Platy.AdventureWorks.Repository.Data.Entities.VAdditionalContactInfo" />
    /// </summary>
    /// <param name="builder">The builder to be used to configure the entity type.</param>
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Platy.AdventureWorks.Repository.Data.Entities.VAdditionalContactInfo> builder)
    {
        #region Generated Configure
        // table
        builder.ToView("vAdditionalContactInfo", "Person");

        // key
        builder.HasNoKey();

        // properties
        builder.Property(t => t.BusinessEntityId)
            .IsRequired()
            .HasColumnName("BusinessEntityID")
            .HasColumnType("int");

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

        builder.Property(t => t.TelephoneNumber)
            .HasColumnName("TelephoneNumber")
            .HasColumnType("nvarchar(50)")
            .HasMaxLength(50);

        builder.Property(t => t.TelephoneSpecialInstructions)
            .HasColumnName("TelephoneSpecialInstructions")
            .HasColumnType("nvarchar(max)");

        builder.Property(t => t.Street)
            .HasColumnName("Street")
            .HasColumnType("nvarchar(50)")
            .HasMaxLength(50);

        builder.Property(t => t.City)
            .HasColumnName("City")
            .HasColumnType("nvarchar(50)")
            .HasMaxLength(50);

        builder.Property(t => t.StateProvince)
            .HasColumnName("StateProvince")
            .HasColumnType("nvarchar(50)")
            .HasMaxLength(50);

        builder.Property(t => t.PostalCode)
            .HasColumnName("PostalCode")
            .HasColumnType("nvarchar(50)")
            .HasMaxLength(50);

        builder.Property(t => t.CountryRegion)
            .HasColumnName("CountryRegion")
            .HasColumnType("nvarchar(50)")
            .HasMaxLength(50);

        builder.Property(t => t.HomeAddressSpecialInstructions)
            .HasColumnName("HomeAddressSpecialInstructions")
            .HasColumnType("nvarchar(max)");

        builder.Property(t => t.EMailAddress)
            .HasColumnName("EMailAddress")
            .HasColumnType("nvarchar(128)")
            .HasMaxLength(128);

        builder.Property(t => t.EMailSpecialInstructions)
            .HasColumnName("EMailSpecialInstructions")
            .HasColumnType("nvarchar(max)");

        builder.Property(t => t.EMailTelephoneNumber)
            .HasColumnName("EMailTelephoneNumber")
            .HasColumnType("nvarchar(50)")
            .HasMaxLength(50);

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
        /// <summary>Table Schema name constant for entity <see cref="Platy.AdventureWorks.Repository.Data.Entities.VAdditionalContactInfo" /></summary>
        public const string Schema = "Person";
        /// <summary>Table Name constant for entity <see cref="Platy.AdventureWorks.Repository.Data.Entities.VAdditionalContactInfo" /></summary>
        public const string Name = "vAdditionalContactInfo";
    }

    internal readonly struct Columns
    {
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VAdditionalContactInfo.BusinessEntityId" /></summary>
        public const string BusinessEntityId = "BusinessEntityID";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VAdditionalContactInfo.FirstName" /></summary>
        public const string FirstName = "FirstName";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VAdditionalContactInfo.MiddleName" /></summary>
        public const string MiddleName = "MiddleName";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VAdditionalContactInfo.LastName" /></summary>
        public const string LastName = "LastName";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VAdditionalContactInfo.TelephoneNumber" /></summary>
        public const string TelephoneNumber = "TelephoneNumber";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VAdditionalContactInfo.TelephoneSpecialInstructions" /></summary>
        public const string TelephoneSpecialInstructions = "TelephoneSpecialInstructions";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VAdditionalContactInfo.Street" /></summary>
        public const string Street = "Street";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VAdditionalContactInfo.City" /></summary>
        public const string City = "City";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VAdditionalContactInfo.StateProvince" /></summary>
        public const string StateProvince = "StateProvince";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VAdditionalContactInfo.PostalCode" /></summary>
        public const string PostalCode = "PostalCode";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VAdditionalContactInfo.CountryRegion" /></summary>
        public const string CountryRegion = "CountryRegion";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VAdditionalContactInfo.HomeAddressSpecialInstructions" /></summary>
        public const string HomeAddressSpecialInstructions = "HomeAddressSpecialInstructions";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VAdditionalContactInfo.EMailAddress" /></summary>
        public const string EMailAddress = "EMailAddress";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VAdditionalContactInfo.EMailSpecialInstructions" /></summary>
        public const string EMailSpecialInstructions = "EMailSpecialInstructions";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VAdditionalContactInfo.EMailTelephoneNumber" /></summary>
        public const string EMailTelephoneNumber = "EMailTelephoneNumber";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VAdditionalContactInfo.Rowguid" /></summary>
        public const string Rowguid = "rowguid";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VAdditionalContactInfo.ModifiedDate" /></summary>
        public const string ModifiedDate = "ModifiedDate";
    }
    #endregion
}
