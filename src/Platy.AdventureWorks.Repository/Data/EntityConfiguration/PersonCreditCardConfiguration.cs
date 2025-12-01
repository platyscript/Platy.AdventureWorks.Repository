using System;
using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;

namespace Platy.AdventureWorks.Repository.Data.EntityConfiguration;

/// <summary>
/// Allows configuration for an entity type <see cref="Platy.AdventureWorks.Repository.Data.Entities.PersonCreditCard" />
/// </summary>
internal partial class PersonCreditCardConfiguration
    : IEntityTypeConfiguration<Platy.AdventureWorks.Repository.Data.Entities.PersonCreditCard>
{
    /// <summary>
    /// Configures the entity of type <see cref="Platy.AdventureWorks.Repository.Data.Entities.PersonCreditCard" />
    /// </summary>
    /// <param name="builder">The builder to be used to configure the entity type.</param>
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Platy.AdventureWorks.Repository.Data.Entities.PersonCreditCard> builder)
    {
        #region Generated Configure
        // table
        builder.ToTable("PersonCreditCard", "Sales");

        // key
        builder.HasKey(t => new { t.BusinessEntityId, t.CreditCardId });

        // properties
        builder.Property(t => t.BusinessEntityId)
            .IsRequired()
            .HasColumnName("BusinessEntityID")
            .HasColumnType("int");

        builder.Property(t => t.CreditCardId)
            .IsRequired()
            .HasColumnName("CreditCardID")
            .HasColumnType("int");

        builder.Property(t => t.ModifiedDate)
            .IsRequired()
            .HasColumnName("ModifiedDate")
            .HasColumnType("datetime")
            .HasDefaultValueSql("(getdate())");

        // relationships
        builder.HasOne(t => t.CreditCard)
            .WithMany(t => t.PersonCreditCards)
            .HasForeignKey(d => d.CreditCardId)
            .HasConstraintName("FK_PersonCreditCard_CreditCard_CreditCardID");

        builder.HasOne(t => t.Person)
            .WithMany(t => t.PersonCreditCards)
            .HasForeignKey(d => d.BusinessEntityId)
            .HasConstraintName("FK_PersonCreditCard_Person_BusinessEntityID");

        #endregion
    }

    #region Generated Constants
    internal readonly struct Table
    {
        /// <summary>Table Schema name constant for entity <see cref="Platy.AdventureWorks.Repository.Data.Entities.PersonCreditCard" /></summary>
        public const string Schema = "Sales";
        /// <summary>Table Name constant for entity <see cref="Platy.AdventureWorks.Repository.Data.Entities.PersonCreditCard" /></summary>
        public const string Name = "PersonCreditCard";
    }

    internal readonly struct Columns
    {
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.PersonCreditCard.BusinessEntityId" /></summary>
        public const string BusinessEntityId = "BusinessEntityID";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.PersonCreditCard.CreditCardId" /></summary>
        public const string CreditCardId = "CreditCardID";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.PersonCreditCard.ModifiedDate" /></summary>
        public const string ModifiedDate = "ModifiedDate";
    }
    #endregion
}
