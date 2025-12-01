using System;
using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;

namespace Platy.AdventureWorks.Repository.Data.EntityConfiguration;

/// <summary>
/// Allows configuration for an entity type <see cref="Platy.AdventureWorks.Repository.Data.Entities.VJobCandidateEducation" />
/// </summary>
internal partial class VJobCandidateEducationConfiguration
    : IEntityTypeConfiguration<Platy.AdventureWorks.Repository.Data.Entities.VJobCandidateEducation>
{
    /// <summary>
    /// Configures the entity of type <see cref="Platy.AdventureWorks.Repository.Data.Entities.VJobCandidateEducation" />
    /// </summary>
    /// <param name="builder">The builder to be used to configure the entity type.</param>
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Platy.AdventureWorks.Repository.Data.Entities.VJobCandidateEducation> builder)
    {
        #region Generated Configure
        // table
        builder.ToView("vJobCandidateEducation", "HumanResources");

        // key
        builder.HasNoKey();

        // properties
        builder.Property(t => t.Id)
            .IsRequired()
            .HasColumnName("JobCandidateID")
            .HasColumnType("int")
            .ValueGeneratedOnAdd();

        builder.Property(t => t.EduLevel)
            .HasColumnName("Edu.Level")
            .HasColumnType("nvarchar(max)");

        builder.Property(t => t.EduStartDate)
            .HasColumnName("Edu.StartDate")
            .HasColumnType("datetime");

        builder.Property(t => t.EduEndDate)
            .HasColumnName("Edu.EndDate")
            .HasColumnType("datetime");

        builder.Property(t => t.EduDegree)
            .HasColumnName("Edu.Degree")
            .HasColumnType("nvarchar(50)")
            .HasMaxLength(50);

        builder.Property(t => t.EduMajor)
            .HasColumnName("Edu.Major")
            .HasColumnType("nvarchar(50)")
            .HasMaxLength(50);

        builder.Property(t => t.EduMinor)
            .HasColumnName("Edu.Minor")
            .HasColumnType("nvarchar(50)")
            .HasMaxLength(50);

        builder.Property(t => t.EduGPA)
            .HasColumnName("Edu.GPA")
            .HasColumnType("nvarchar(5)")
            .HasMaxLength(5);

        builder.Property(t => t.EduGPAScale)
            .HasColumnName("Edu.GPAScale")
            .HasColumnType("nvarchar(5)")
            .HasMaxLength(5);

        builder.Property(t => t.EduSchool)
            .HasColumnName("Edu.School")
            .HasColumnType("nvarchar(100)")
            .HasMaxLength(100);

        builder.Property(t => t.EduLocCountryRegion)
            .HasColumnName("Edu.Loc.CountryRegion")
            .HasColumnType("nvarchar(100)")
            .HasMaxLength(100);

        builder.Property(t => t.EduLocState)
            .HasColumnName("Edu.Loc.State")
            .HasColumnType("nvarchar(100)")
            .HasMaxLength(100);

        builder.Property(t => t.EduLocCity)
            .HasColumnName("Edu.Loc.City")
            .HasColumnType("nvarchar(100)")
            .HasMaxLength(100);

        // relationships
        #endregion
    }

    #region Generated Constants
    internal readonly struct Table
    {
        /// <summary>Table Schema name constant for entity <see cref="Platy.AdventureWorks.Repository.Data.Entities.VJobCandidateEducation" /></summary>
        public const string Schema = "HumanResources";
        /// <summary>Table Name constant for entity <see cref="Platy.AdventureWorks.Repository.Data.Entities.VJobCandidateEducation" /></summary>
        public const string Name = "vJobCandidateEducation";
    }

    internal readonly struct Columns
    {
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VJobCandidateEducation.Id" /></summary>
        public const string Id = "JobCandidateID";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VJobCandidateEducation.EduLevel" /></summary>
        public const string EduLevel = "Edu.Level";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VJobCandidateEducation.EduStartDate" /></summary>
        public const string EduStartDate = "Edu.StartDate";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VJobCandidateEducation.EduEndDate" /></summary>
        public const string EduEndDate = "Edu.EndDate";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VJobCandidateEducation.EduDegree" /></summary>
        public const string EduDegree = "Edu.Degree";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VJobCandidateEducation.EduMajor" /></summary>
        public const string EduMajor = "Edu.Major";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VJobCandidateEducation.EduMinor" /></summary>
        public const string EduMinor = "Edu.Minor";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VJobCandidateEducation.EduGPA" /></summary>
        public const string EduGPA = "Edu.GPA";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VJobCandidateEducation.EduGPAScale" /></summary>
        public const string EduGPAScale = "Edu.GPAScale";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VJobCandidateEducation.EduSchool" /></summary>
        public const string EduSchool = "Edu.School";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VJobCandidateEducation.EduLocCountryRegion" /></summary>
        public const string EduLocCountryRegion = "Edu.Loc.CountryRegion";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VJobCandidateEducation.EduLocState" /></summary>
        public const string EduLocState = "Edu.Loc.State";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VJobCandidateEducation.EduLocCity" /></summary>
        public const string EduLocCity = "Edu.Loc.City";
    }
    #endregion
}
