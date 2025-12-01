using System;
using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;

namespace Platy.AdventureWorks.Repository.Data.EntityConfiguration;

/// <summary>
/// Allows configuration for an entity type <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductReview" />
/// </summary>
internal partial class ProductReviewConfiguration
    : IEntityTypeConfiguration<Platy.AdventureWorks.Repository.Data.Entities.ProductReview>
{
    /// <summary>
    /// Configures the entity of type <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductReview" />
    /// </summary>
    /// <param name="builder">The builder to be used to configure the entity type.</param>
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Platy.AdventureWorks.Repository.Data.Entities.ProductReview> builder)
    {
        #region Generated Configure
        // table
        builder.ToTable("ProductReview", "Production");

        // key
        builder.HasKey(t => t.Id);

        // properties
        builder.Property(t => t.Id)
            .IsRequired()
            .HasColumnName("ProductReviewID")
            .HasColumnType("int")
            .ValueGeneratedOnAdd();

        builder.Property(t => t.ProductId)
            .IsRequired()
            .HasColumnName("ProductID")
            .HasColumnType("int");

        builder.Property(t => t.ReviewerName)
            .IsRequired()
            .HasColumnName("ReviewerName")
            .HasColumnType("nvarchar(50)")
            .HasMaxLength(50);

        builder.Property(t => t.ReviewDate)
            .IsRequired()
            .HasColumnName("ReviewDate")
            .HasColumnType("datetime")
            .HasDefaultValueSql("(getdate())");

        builder.Property(t => t.EmailAddress)
            .IsRequired()
            .HasColumnName("EmailAddress")
            .HasColumnType("nvarchar(50)")
            .HasMaxLength(50);

        builder.Property(t => t.Rating)
            .IsRequired()
            .HasColumnName("Rating")
            .HasColumnType("int");

        builder.Property(t => t.Comments)
            .HasColumnName("Comments")
            .HasColumnType("nvarchar(3850)")
            .HasMaxLength(3850);

        builder.Property(t => t.ModifiedDate)
            .IsRequired()
            .HasColumnName("ModifiedDate")
            .HasColumnType("datetime")
            .HasDefaultValueSql("(getdate())");

        // relationships
        builder.HasOne(t => t.Product)
            .WithMany(t => t.ProductReviews)
            .HasForeignKey(d => d.ProductId)
            .HasConstraintName("FK_ProductReview_Product_ProductID");

        #endregion
    }

    #region Generated Constants
    internal readonly struct Table
    {
        /// <summary>Table Schema name constant for entity <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductReview" /></summary>
        public const string Schema = "Production";
        /// <summary>Table Name constant for entity <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductReview" /></summary>
        public const string Name = "ProductReview";
    }

    internal readonly struct Columns
    {
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductReview.Id" /></summary>
        public const string Id = "ProductReviewID";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductReview.ProductId" /></summary>
        public const string ProductId = "ProductID";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductReview.ReviewerName" /></summary>
        public const string ReviewerName = "ReviewerName";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductReview.ReviewDate" /></summary>
        public const string ReviewDate = "ReviewDate";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductReview.EmailAddress" /></summary>
        public const string EmailAddress = "EmailAddress";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductReview.Rating" /></summary>
        public const string Rating = "Rating";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductReview.Comments" /></summary>
        public const string Comments = "Comments";
        /// <summary>Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductReview.ModifiedDate" /></summary>
        public const string ModifiedDate = "ModifiedDate";
    }
    #endregion
}
