using Platy.AdventureWorks.Repository.Data.Entities;

namespace Platy.AdventureWorks.Repository.Data.EntityConfiguration;

/// <summary>
///   Allows configuration for an entity type <see cref="Platy.AdventureWorks.Repository.Data.Entities.ShoppingCartItem" />
/// </summary>
internal class ShoppingCartItemConfiguration
  : IEntityTypeConfiguration<ShoppingCartItem>
{
  /// <summary>
  ///   Configures the entity of type <see cref="Platy.AdventureWorks.Repository.Data.Entities.ShoppingCartItem" />
  /// </summary>
  /// <param name="builder">The builder to be used to configure the entity type.</param>
  public void Configure(EntityTypeBuilder<ShoppingCartItem> builder)
  {
    #region Generated Configure

    // table
    builder.ToTable("ShoppingCartItem", "Sales");

    // key
    builder.HasKey(t => t.Id);

    // properties
    builder.Property(t => t.Id)
      .IsRequired()
      .HasColumnName("ShoppingCartItemID")
      .HasColumnType("int")
      .ValueGeneratedOnAdd();

    builder.Property(t => t.ShoppingCartId)
      .IsRequired()
      .HasColumnName("ShoppingCartID")
      .HasColumnType("nvarchar(50)")
      .HasMaxLength(50);

    builder.Property(t => t.Quantity)
      .IsRequired()
      .HasColumnName("Quantity")
      .HasColumnType("int")
      .HasDefaultValue(1);

    builder.Property(t => t.ProductId)
      .IsRequired()
      .HasColumnName("ProductID")
      .HasColumnType("int");

    builder.Property(t => t.DateCreated)
      .IsRequired()
      .HasColumnName("DateCreated")
      .HasColumnType("datetime")
      .HasDefaultValueSql("(getdate())");

    builder.Property(t => t.ModifiedDate)
      .IsRequired()
      .HasColumnName("ModifiedDate")
      .HasColumnType("datetime")
      .HasDefaultValueSql("(getdate())");

    // relationships
    builder.HasOne(t => t.Product)
      .WithMany(t => t.ShoppingCartItems)
      .HasForeignKey(d => d.ProductId)
      .HasConstraintName("FK_ShoppingCartItem_Product_ProductID");

    #endregion
  }

  #region Generated Constants

  internal readonly struct Table
  {
    /// <summary>
    ///   Table Schema name constant for entity
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.ShoppingCartItem" />
    /// </summary>
    public const string Schema = "Sales";

    /// <summary>
    ///   Table Name constant for entity <see cref="Platy.AdventureWorks.Repository.Data.Entities.ShoppingCartItem" />
    /// </summary>
    public const string Name = "ShoppingCartItem";
  }

  internal readonly struct Columns
  {
    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.ShoppingCartItem.Id" />
    /// </summary>
    public const string Id = "ShoppingCartItemID";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.ShoppingCartItem.ShoppingCartId" />
    /// </summary>
    public const string ShoppingCartId = "ShoppingCartID";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.ShoppingCartItem.Quantity" />
    /// </summary>
    public const string Quantity = "Quantity";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.ShoppingCartItem.ProductId" />
    /// </summary>
    public const string ProductId = "ProductID";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.ShoppingCartItem.DateCreated" />
    /// </summary>
    public const string DateCreated = "DateCreated";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.ShoppingCartItem.ModifiedDate" />
    /// </summary>
    public const string ModifiedDate = "ModifiedDate";
  }

  #endregion
}
