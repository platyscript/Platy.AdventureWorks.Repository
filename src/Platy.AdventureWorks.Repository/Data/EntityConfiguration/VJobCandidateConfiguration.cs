using System;
using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;

namespace Platy.AdventureWorks.Repository.Data.EntityConfiguration;

/// <summary>
/// Allows configuration for an entity type <see cref="Platy.AdventureWorks.Repository.Data.Entities.VJobCandidate" />
/// </summary>
internal partial class VJobCandidateConfiguration
    : IEntityTypeConfiguration<Platy.AdventureWorks.Repository.Data.Entities.VJobCandidate>
{
    /// <summary>
    /// Configures the entity of type <see cref="Platy.AdventureWorks.Repository.Data.Entities.VJobCandidate" />
    /// </summary>
    /// <param name="builder">The builder to be used to configure the entity type.</param>
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Platy.AdventureWorks.Repository.Data.Entities.VJobCandidate> builder)
    {
        #region Generated Configure
        // table
        builder.ToView("vJobCandidate", "HumanResources");

        // key
        builder.HasNoKey();

        // properties
        builder.Property(t => t.Id)
            .IsRequired()
            .HasColumnName("JobCandidateID")
            .HasColumnType("int")
            .ValueGeneratedOnAdd();

        builder.Property(t => t.BusinessEntityId)
            .HasColumnName("BusinessEntityID")
            .HasColumnType("int");

        builder.Property(t => t.NamePrefix)
            .HasColumnName("Name.Prefix")
            .HasColumnType("nvarchar(30)")
            .HasMaxLength(30);

        builder.Property(t => t.NameFirst)
            .HasColumnName("Name.First")
            .HasColumnType("nvarchar(30)")
            .HasMaxLength(30);

        builder.Property(t => t.NameMiddle)
            .HasColumnName("Name.Middle")
            .HasColumnType("nvarchar(30)")
            .HasMaxLength(30);

        builder.Property(t => t.NameLast)
            .HasColumnName("Name.Last")
            .HasColumnType("nvarchar(30)")
            .HasMaxLength(30);

        builder.Property(t => t.NameSuffix)
            .HasColumnName("Name.Suffix")
            .HasColumnType("nvarchar(30)")
            .HasMaxLength(30);

        builder.Property(t => t.Skills)
            .HasColumnName("Skills")
            .HasColumnType("nvarchar(max)");

        builder.Property(t => t.AddrType)
            .HasColumnName("Addr.Type")
            .HasColumnType("nvarchar(30)")
            .HasMaxLength(30);

        builder.Property(t => t.AddrLocCountryRegion)
            .HasColumnName("Addr.Loc.CountryRegion")
            .HasColumnType("nvarchar(100)")
            .HasMaxLength(100);

        builder.Property(t => t.AddrLocState)
            .HasColumnName("Addr.Loc.State")
            .HasColumnType("nvarchar(100)")
            .HasMaxLength(100);

        builder.Property(t => t.AddrLocCity)
            .HasColumnName("Addr.Loc.City")
            .HasColumnType("nvarchar(100)")
            .HasMaxLength(100);

        builder.Property(t => t.AddrPostalCode)
            .HasColumnName("Addr.PostalCode")
            .HasColumnType("nvarchar(20)")
            .HasMaxLength(20);

        builder.Property(t => t.EMail)
            .HasColumnName("EMail")
            .HasColumnType("nvarchar(max)");

        builder.Property(t => t.WebSite)
            .HasColumnName("WebSite")
            .HasColumnType("nvarchar(max)");

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
        /// <summary>Table Schema name constant for entity <see cref="Platy.AdventureWorks.Repository.Data.Entities.VJobCandidate" /></summary>
        public const string Schema = "HumanResources";
        /// <summary>Table Name constant for entity <see cref="Platy.AdventureWorks.Repository.Data.Entities.VJobCandidate" /></summary>
        public const string Name = "vJobCandidate";
    }

    internal readonly struct Columns
    {
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VJobCandidate.Id" /></summary>
        public const string Id = "JobCandidateID";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VJobCandidate.BusinessEntityId" /></summary>
        public const string BusinessEntityId = "BusinessEntityID";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VJobCandidate.NamePrefix" /></summary>
        public const string NamePrefix = "Name.Prefix";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VJobCandidate.NameFirst" /></summary>
        public const string NameFirst = "Name.First";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VJobCandidate.NameMiddle" /></summary>
        public const string NameMiddle = "Name.Middle";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VJobCandidate.NameLast" /></summary>
        public const string NameLast = "Name.Last";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VJobCandidate.NameSuffix" /></summary>
        public const string NameSuffix = "Name.Suffix";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VJobCandidate.Skills" /></summary>
        public const string Skills = "Skills";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VJobCandidate.AddrType" /></summary>
        public const string AddrType = "Addr.Type";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VJobCandidate.AddrLocCountryRegion" /></summary>
        public const string AddrLocCountryRegion = "Addr.Loc.CountryRegion";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VJobCandidate.AddrLocState" /></summary>
        public const string AddrLocState = "Addr.Loc.State";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VJobCandidate.AddrLocCity" /></summary>
        public const string AddrLocCity = "Addr.Loc.City";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VJobCandidate.AddrPostalCode" /></summary>
        public const string AddrPostalCode = "Addr.PostalCode";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VJobCandidate.EMail" /></summary>
        public const string EMail = "EMail";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VJobCandidate.WebSite" /></summary>
        public const string WebSite = "WebSite";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VJobCandidate.ModifiedDate" /></summary>
        public const string ModifiedDate = "ModifiedDate";
    }
    #endregion
}
