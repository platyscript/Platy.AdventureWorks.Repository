using Platy.AdventureWorks.Repository.Data.Entities;

namespace Platy.AdventureWorks.Repository.Data.EntityConfiguration;

/// <summary>
///   Allows configuration for an entity type
///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.SpecialOfferProduct" />
/// </summary>
internal class SpecialOfferProductConfiguration
  : IEntityTypeConfiguration<SpecialOfferProduct>
{
  /// <summary>
  ///   Configures the entity of type <see cref="Platy.AdventureWorks.Repository.Data.Entities.SpecialOfferProduct" />
  /// </summary>
  /// <param name="builder">The builder to be used to configure the entity type.</param>
  public void Configure(EntityTypeBuilder<SpecialOfferProduct> builder)
  {
    #region Generated Configure

    // table
    builder.ToTable("SpecialOfferProduct", "Sales");

    // key
    builder.HasKey(t => new { t.SpecialOfferId, t.ProductId });

    // properties
    builder.Property(t => t.SpecialOfferId)
      .IsRequired()
      .HasColumnName("SpecialOfferID")
      .HasColumnType("int");

    builder.Property(t => t.ProductId)
      .IsRequired()
      .HasColumnName("ProductID")
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
    builder.HasOne(t => t.Product)
      .WithMany(t => t.SpecialOfferProducts)
      .HasForeignKey(d => d.ProductId)
      .HasConstraintName("FK_SpecialOfferProduct_Product_ProductID");

    builder.HasOne(t => t.SpecialOffer)
      .WithMany(t => t.SpecialOfferProducts)
      .HasForeignKey(d => d.SpecialOfferId)
      .HasConstraintName("FK_SpecialOfferProduct_SpecialOffer_SpecialOfferID");

    #endregion
  }

  #region Generated Constants

  internal readonly struct Table
  {
    /// <summary>
    ///   Table Schema name constant for entity
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.SpecialOfferProduct" />
    /// </summary>
    public const string Schema = "Sales";

    /// <summary>
    ///   Table Name constant for entity
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.SpecialOfferProduct" />
    /// </summary>
    public const string Name = "SpecialOfferProduct";
  }

  internal readonly struct Columns
  {
    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.SpecialOfferProduct.SpecialOfferId" />
    /// </summary>
    public const string SpecialOfferId = "SpecialOfferID";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.SpecialOfferProduct.ProductId" />
    /// </summary>
    public const string ProductId = "ProductID";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.SpecialOfferProduct.Rowguid" />
    /// </summary>
    public const string Rowguid = "rowguid";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.SpecialOfferProduct.ModifiedDate" />
    /// </summary>
    public const string ModifiedDate = "ModifiedDate";
  }

  #endregion
}
