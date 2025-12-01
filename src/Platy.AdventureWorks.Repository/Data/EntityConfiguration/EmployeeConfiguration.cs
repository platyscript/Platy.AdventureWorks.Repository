using System;
using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;

namespace Platy.AdventureWorks.Repository.Data.EntityConfiguration;

/// <summary>
/// Allows configuration for an entity type <see cref="Platy.AdventureWorks.Repository.Data.Entities.Employee" />
/// </summary>
internal partial class EmployeeConfiguration
    : IEntityTypeConfiguration<Platy.AdventureWorks.Repository.Data.Entities.Employee>
{
    /// <summary>
    /// Configures the entity of type <see cref="Platy.AdventureWorks.Repository.Data.Entities.Employee" />
    /// </summary>
    /// <param name="builder">The builder to be used to configure the entity type.</param>
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Platy.AdventureWorks.Repository.Data.Entities.Employee> builder)
    {
        #region Generated Configure
        // table
        builder.ToTable("Employee", "HumanResources");

        // key
        builder.HasKey(t => t.BusinessEntityId);

        // properties
        builder.Property(t => t.BusinessEntityId)
            .IsRequired()
            .HasColumnName("BusinessEntityID")
            .HasColumnType("int");

        builder.Property(t => t.NationalIdNumber)
            .IsRequired()
            .HasColumnName("NationalIDNumber")
            .HasColumnType("nvarchar(15)")
            .HasMaxLength(15);

        builder.Property(t => t.LoginId)
            .IsRequired()
            .HasColumnName("LoginID")
            .HasColumnType("nvarchar(256)")
            .HasMaxLength(256);

        builder.Property(t => t.OrganizationLevel)
            .HasColumnName("OrganizationLevel")
            .HasColumnType("smallint")
            .ValueGeneratedOnAddOrUpdate();

        builder.Property(t => t.JobTitle)
            .IsRequired()
            .HasColumnName("JobTitle")
            .HasColumnType("nvarchar(50)")
            .HasMaxLength(50);

        builder.Property(t => t.BirthDate)
            .IsRequired()
            .HasColumnName("BirthDate")
            .HasColumnType("date");

        builder.Property(t => t.MaritalStatus)
            .IsRequired()
            .HasColumnName("MaritalStatus")
            .HasColumnType("nchar(1)")
            .HasMaxLength(1);

        builder.Property(t => t.Gender)
            .IsRequired()
            .HasColumnName("Gender")
            .HasColumnType("nchar(1)")
            .HasMaxLength(1);

        builder.Property(t => t.HireDate)
            .IsRequired()
            .HasColumnName("HireDate")
            .HasColumnType("date");

        builder.Property(t => t.SalariedFlag)
            .IsRequired()
            .HasColumnName("SalariedFlag")
            .HasColumnType("bit")
            .HasDefaultValue(true);

        builder.Property(t => t.VacationHours)
            .IsRequired()
            .HasColumnName("VacationHours")
            .HasColumnType("smallint")
            .HasDefaultValue(0);

        builder.Property(t => t.SickLeaveHours)
            .IsRequired()
            .HasColumnName("SickLeaveHours")
            .HasColumnType("smallint")
            .HasDefaultValue(0);

        builder.Property(t => t.CurrentFlag)
            .IsRequired()
            .HasColumnName("CurrentFlag")
            .HasColumnType("bit")
            .HasDefaultValue(true);

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
            .WithOne(t => t.Employee)
            .HasForeignKey<Platy.AdventureWorks.Repository.Data.Entities.Employee>(d => d.BusinessEntityId)
            .HasConstraintName("FK_Employee_Person_BusinessEntityID");

        #endregion
    }

    #region Generated Constants
    internal readonly struct Table
    {
        /// <summary>Table Schema name constant for entity <see cref="Platy.AdventureWorks.Repository.Data.Entities.Employee" /></summary>
        public const string Schema = "HumanResources";
        /// <summary>Table Name constant for entity <see cref="Platy.AdventureWorks.Repository.Data.Entities.Employee" /></summary>
        public const string Name = "Employee";
    }

    internal readonly struct Columns
    {
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.Employee.BusinessEntityId" /></summary>
        public const string BusinessEntityId = "BusinessEntityID";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.Employee.NationalIdNumber" /></summary>
        public const string NationalIdNumber = "NationalIDNumber";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.Employee.LoginId" /></summary>
        public const string LoginId = "LoginID";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.Employee.OrganizationLevel" /></summary>
        public const string OrganizationLevel = "OrganizationLevel";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.Employee.JobTitle" /></summary>
        public const string JobTitle = "JobTitle";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.Employee.BirthDate" /></summary>
        public const string BirthDate = "BirthDate";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.Employee.MaritalStatus" /></summary>
        public const string MaritalStatus = "MaritalStatus";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.Employee.Gender" /></summary>
        public const string Gender = "Gender";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.Employee.HireDate" /></summary>
        public const string HireDate = "HireDate";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.Employee.SalariedFlag" /></summary>
        public const string SalariedFlag = "SalariedFlag";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.Employee.VacationHours" /></summary>
        public const string VacationHours = "VacationHours";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.Employee.SickLeaveHours" /></summary>
        public const string SickLeaveHours = "SickLeaveHours";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.Employee.CurrentFlag" /></summary>
        public const string CurrentFlag = "CurrentFlag";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.Employee.Rowguid" /></summary>
        public const string Rowguid = "rowguid";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.Employee.ModifiedDate" /></summary>
        public const string ModifiedDate = "ModifiedDate";
    }
    #endregion
}
