using System;
using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;

namespace Platy.AdventureWorks.Repository.Data.EntityConfiguration;

/// <summary>
/// Allows configuration for an entity type <see cref="Platy.AdventureWorks.Repository.Data.Entities.Password" />
/// </summary>
internal partial class PasswordConfiguration
    : IEntityTypeConfiguration<Platy.AdventureWorks.Repository.Data.Entities.Password>
{
    /// <summary>
    /// Configures the entity of type <see cref="Platy.AdventureWorks.Repository.Data.Entities.Password" />
    /// </summary>
    /// <param name="builder">The builder to be used to configure the entity type.</param>
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Platy.AdventureWorks.Repository.Data.Entities.Password> builder)
    {
        #region Generated Configure
        // table
        builder.ToTable("Password", "Person");

        // key
        builder.HasKey(t => t.BusinessEntityId);

        // properties
        builder.Property(t => t.BusinessEntityId)
            .IsRequired()
            .HasColumnName("BusinessEntityID")
            .HasColumnType("int");

        builder.Property(t => t.PasswordHash)
            .IsRequired()
            .HasColumnName("PasswordHash")
            .HasColumnType("varchar(128)")
            .HasMaxLength(128);

        builder.Property(t => t.PasswordSalt)
            .IsRequired()
            .HasColumnName("PasswordSalt")
            .HasColumnType("varchar(10)")
            .HasMaxLength(10);

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
            .WithOne(t => t.Password)
            .HasForeignKey<Platy.AdventureWorks.Repository.Data.Entities.Password>(d => d.BusinessEntityId)
            .HasConstraintName("FK_Password_Person_BusinessEntityID");

        #endregion
    }

    #region Generated Constants
    internal readonly struct Table
    {
        /// <summary>Table Schema name constant for entity <see cref="Platy.AdventureWorks.Repository.Data.Entities.Password" /></summary>
        public const string Schema = "Person";
        /// <summary>Table Name constant for entity <see cref="Platy.AdventureWorks.Repository.Data.Entities.Password" /></summary>
        public const string Name = "Password";
    }

    internal readonly struct Columns
    {
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.Password.BusinessEntityId" /></summary>
        public const string BusinessEntityId = "BusinessEntityID";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.Password.PasswordHash" /></summary>
        public const string PasswordHash = "PasswordHash";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.Password.PasswordSalt" /></summary>
        public const string PasswordSalt = "PasswordSalt";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.Password.Rowguid" /></summary>
        public const string Rowguid = "rowguid";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.Password.ModifiedDate" /></summary>
        public const string ModifiedDate = "ModifiedDate";
    }
    #endregion
}
