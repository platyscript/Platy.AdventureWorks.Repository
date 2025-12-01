using System;
using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;

namespace Platy.AdventureWorks.Repository.Data.EntityConfiguration;

/// <summary>
/// Allows configuration for an entity type <see cref="Platy.AdventureWorks.Repository.Data.Entities.VJobCandidateEmployment" />
/// </summary>
internal partial class VJobCandidateEmploymentConfiguration
    : IEntityTypeConfiguration<Platy.AdventureWorks.Repository.Data.Entities.VJobCandidateEmployment>
{
    /// <summary>
    /// Configures the entity of type <see cref="Platy.AdventureWorks.Repository.Data.Entities.VJobCandidateEmployment" />
    /// </summary>
    /// <param name="builder">The builder to be used to configure the entity type.</param>
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Platy.AdventureWorks.Repository.Data.Entities.VJobCandidateEmployment> builder)
    {
        #region Generated Configure
        // table
        builder.ToView("vJobCandidateEmployment", "HumanResources");

        // key
        builder.HasNoKey();

        // properties
        builder.Property(t => t.Id)
            .IsRequired()
            .HasColumnName("JobCandidateID")
            .HasColumnType("int")
            .ValueGeneratedOnAdd();

        builder.Property(t => t.EmpStartDate)
            .HasColumnName("Emp.StartDate")
            .HasColumnType("datetime");

        builder.Property(t => t.EmpEndDate)
            .HasColumnName("Emp.EndDate")
            .HasColumnType("datetime");

        builder.Property(t => t.EmpOrgName)
            .HasColumnName("Emp.OrgName")
            .HasColumnType("nvarchar(100)")
            .HasMaxLength(100);

        builder.Property(t => t.EmpJobTitle)
            .HasColumnName("Emp.JobTitle")
            .HasColumnType("nvarchar(100)")
            .HasMaxLength(100);

        builder.Property(t => t.EmpResponsibility)
            .HasColumnName("Emp.Responsibility")
            .HasColumnType("nvarchar(max)");

        builder.Property(t => t.EmpFunctionCategory)
            .HasColumnName("Emp.FunctionCategory")
            .HasColumnType("nvarchar(max)");

        builder.Property(t => t.EmpIndustryCategory)
            .HasColumnName("Emp.IndustryCategory")
            .HasColumnType("nvarchar(max)");

        builder.Property(t => t.EmpLocCountryRegion)
            .HasColumnName("Emp.Loc.CountryRegion")
            .HasColumnType("nvarchar(max)");

        builder.Property(t => t.EmpLocState)
            .HasColumnName("Emp.Loc.State")
            .HasColumnType("nvarchar(max)");

        builder.Property(t => t.EmpLocCity)
            .HasColumnName("Emp.Loc.City")
            .HasColumnType("nvarchar(max)");

        // relationships
        #endregion
    }

    #region Generated Constants
    internal readonly struct Table
    {
        /// <summary>Table Schema name constant for entity <see cref="Platy.AdventureWorks.Repository.Data.Entities.VJobCandidateEmployment" /></summary>
        public const string Schema = "HumanResources";
        /// <summary>Table Name constant for entity <see cref="Platy.AdventureWorks.Repository.Data.Entities.VJobCandidateEmployment" /></summary>
        public const string Name = "vJobCandidateEmployment";
    }

    internal readonly struct Columns
    {
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VJobCandidateEmployment.Id" /></summary>
        public const string Id = "JobCandidateID";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VJobCandidateEmployment.EmpStartDate" /></summary>
        public const string EmpStartDate = "Emp.StartDate";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VJobCandidateEmployment.EmpEndDate" /></summary>
        public const string EmpEndDate = "Emp.EndDate";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VJobCandidateEmployment.EmpOrgName" /></summary>
        public const string EmpOrgName = "Emp.OrgName";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VJobCandidateEmployment.EmpJobTitle" /></summary>
        public const string EmpJobTitle = "Emp.JobTitle";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VJobCandidateEmployment.EmpResponsibility" /></summary>
        public const string EmpResponsibility = "Emp.Responsibility";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VJobCandidateEmployment.EmpFunctionCategory" /></summary>
        public const string EmpFunctionCategory = "Emp.FunctionCategory";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VJobCandidateEmployment.EmpIndustryCategory" /></summary>
        public const string EmpIndustryCategory = "Emp.IndustryCategory";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VJobCandidateEmployment.EmpLocCountryRegion" /></summary>
        public const string EmpLocCountryRegion = "Emp.Loc.CountryRegion";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VJobCandidateEmployment.EmpLocState" /></summary>
        public const string EmpLocState = "Emp.Loc.State";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.VJobCandidateEmployment.EmpLocCity" /></summary>
        public const string EmpLocCity = "Emp.Loc.City";
    }
    #endregion
}
