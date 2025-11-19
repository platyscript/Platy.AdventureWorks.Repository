using Platy.AdventureWorks.Repository.Data.Entities;

namespace Platy.AdventureWorks.Repository.Data.EntityConfiguration;

/// <summary>
///   Allows configuration for an entity type <see cref="Platy.AdventureWorks.Repository.Data.Entities.Product" />
/// </summary>
internal class ProductConfiguration
  : IEntityTypeConfiguration<Product>
{
  /// <summary>
  ///   Configures the entity of type <see cref="Platy.AdventureWorks.Repository.Data.Entities.Product" />
  /// </summary>
  /// <param name="builder">The builder to be used to configure the entity type.</param>
  public void Configure(EntityTypeBuilder<Product> builder)
  {
    #region Generated Configure

    // table
    builder.ToTable("Product", "Production");

    // key
    builder.HasKey(t => t.Id);

    // properties
    builder.Property(t => t.Id)
      .IsRequired()
      .HasColumnName("ProductID")
      .HasColumnType("int")
      .ValueGeneratedOnAdd();

    builder.Property(t => t.Name)
      .IsRequired()
      .HasColumnName("Name")
      .HasColumnType("nvarchar(50)")
      .HasMaxLength(50);

    builder.Property(t => t.ProductNumber)
      .IsRequired()
      .HasColumnName("ProductNumber")
      .HasColumnType("nvarchar(25)")
      .HasMaxLength(25);

    builder.Property(t => t.MakeFlag)
      .IsRequired()
      .HasColumnName("MakeFlag")
      .HasColumnType("bit")
      .HasDefaultValue(true);

    builder.Property(t => t.FinishedGoodsFlag)
      .IsRequired()
      .HasColumnName("FinishedGoodsFlag")
      .HasColumnType("bit")
      .HasDefaultValue(true);

    builder.Property(t => t.Color)
      .HasColumnName("Color")
      .HasColumnType("nvarchar(15)")
      .HasMaxLength(15);

    builder.Property(t => t.SafetyStockLevel)
      .IsRequired()
      .HasColumnName("SafetyStockLevel")
      .HasColumnType("smallint");

    builder.Property(t => t.ReorderPoint)
      .IsRequired()
      .HasColumnName("ReorderPoint")
      .HasColumnType("smallint");

    builder.Property(t => t.StandardCost)
      .IsRequired()
      .HasColumnName("StandardCost")
      .HasColumnType("money");

    builder.Property(t => t.ListPrice)
      .IsRequired()
      .HasColumnName("ListPrice")
      .HasColumnType("money");

    builder.Property(t => t.Size)
      .HasColumnName("Size")
      .HasColumnType("nvarchar(5)")
      .HasMaxLength(5);

    builder.Property(t => t.SizeUnitMeasureCode)
      .HasColumnName("SizeUnitMeasureCode")
      .HasColumnType("nchar(3)")
      .HasMaxLength(3);

    builder.Property(t => t.WeightUnitMeasureCode)
      .HasColumnName("WeightUnitMeasureCode")
      .HasColumnType("nchar(3)")
      .HasMaxLength(3);

    builder.Property(t => t.Weight)
      .HasColumnName("Weight")
      .HasColumnType("decimal(8,2)");

    builder.Property(t => t.DaysToManufacture)
      .IsRequired()
      .HasColumnName("DaysToManufacture")
      .HasColumnType("int");

    builder.Property(t => t.ProductLine)
      .HasColumnName("ProductLine")
      .HasColumnType("nchar(2)")
      .HasMaxLength(2);

    builder.Property(t => t.Class)
      .HasColumnName("Class")
      .HasColumnType("nchar(2)")
      .HasMaxLength(2);

    builder.Property(t => t.Style)
      .HasColumnName("Style")
      .HasColumnType("nchar(2)")
      .HasMaxLength(2);

    builder.Property(t => t.ProductSubcategoryId)
      .HasColumnName("ProductSubcategoryID")
      .HasColumnType("int");

    builder.Property(t => t.ProductModelId)
      .HasColumnName("ProductModelID")
      .HasColumnType("int");

    builder.Property(t => t.SellStartDate)
      .IsRequired()
      .HasColumnName("SellStartDate")
      .HasColumnType("datetime");

    builder.Property(t => t.SellEndDate)
      .HasColumnName("SellEndDate")
      .HasColumnType("datetime");

    builder.Property(t => t.DiscontinuedDate)
      .HasColumnName("DiscontinuedDate")
      .HasColumnType("datetime");

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
    builder.HasOne(t => t.ProductModel)
      .WithMany(t => t.Products)
      .HasForeignKey(d => d.ProductModelId)
      .HasConstraintName("FK_Product_ProductModel_ProductModelID");

    builder.HasOne(t => t.ProductSubcategory)
      .WithMany(t => t.Products)
      .HasForeignKey(d => d.ProductSubcategoryId)
      .HasConstraintName("FK_Product_ProductSubcategory_ProductSubcategoryID");

    builder.HasOne(t => t.SizeUnitMeasure)
      .WithMany(t => t.SizeProducts)
      .HasForeignKey(d => d.SizeUnitMeasureCode)
      .HasConstraintName("FK_Product_UnitMeasure_SizeUnitMeasureCode");

    builder.HasOne(t => t.WeightUnitMeasure)
      .WithMany(t => t.WeightProducts)
      .HasForeignKey(d => d.WeightUnitMeasureCode)
      .HasConstraintName("FK_Product_UnitMeasure_WeightUnitMeasureCode");

    #endregion
  }

  #region Generated Constants

  internal readonly struct Table
  {
    /// <summary>
    ///   Table Schema name constant for entity <see cref="Platy.AdventureWorks.Repository.Data.Entities.Product" />
    /// </summary>
    public const string Schema = "Production";

    /// <summary>Table Name constant for entity <see cref="Platy.AdventureWorks.Repository.Data.Entities.Product" /></summary>
    public const string Name = "Product";
  }

  internal readonly struct Columns
  {
    /// <summary>
    ///   Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.Product.Id" />
    /// </summary>
    public const string Id = "ProductID";

    /// <summary>
    ///   Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.Product.Name" />
    /// </summary>
    public const string Name = "Name";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.Product.ProductNumber" />
    /// </summary>
    public const string ProductNumber = "ProductNumber";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.Product.MakeFlag" />
    /// </summary>
    public const string MakeFlag = "MakeFlag";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.Product.FinishedGoodsFlag" />
    /// </summary>
    public const string FinishedGoodsFlag = "FinishedGoodsFlag";

    /// <summary>
    ///   Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.Product.Color" />
    /// </summary>
    public const string Color = "Color";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.Product.SafetyStockLevel" />
    /// </summary>
    public const string SafetyStockLevel = "SafetyStockLevel";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.Product.ReorderPoint" />
    /// </summary>
    public const string ReorderPoint = "ReorderPoint";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.Product.StandardCost" />
    /// </summary>
    public const string StandardCost = "StandardCost";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.Product.ListPrice" />
    /// </summary>
    public const string ListPrice = "ListPrice";

    /// <summary>
    ///   Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.Product.Size" />
    /// </summary>
    public const string Size = "Size";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.Product.SizeUnitMeasureCode" />
    /// </summary>
    public const string SizeUnitMeasureCode = "SizeUnitMeasureCode";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.Product.WeightUnitMeasureCode" />
    /// </summary>
    public const string WeightUnitMeasureCode = "WeightUnitMeasureCode";

    /// <summary>
    ///   Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.Product.Weight" />
    /// </summary>
    public const string Weight = "Weight";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.Product.DaysToManufacture" />
    /// </summary>
    public const string DaysToManufacture = "DaysToManufacture";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.Product.ProductLine" />
    /// </summary>
    public const string ProductLine = "ProductLine";

    /// <summary>
    ///   Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.Product.Class" />
    /// </summary>
    public const string Class = "Class";

    /// <summary>
    ///   Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.Product.Style" />
    /// </summary>
    public const string Style = "Style";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.Product.ProductSubcategoryId" />
    /// </summary>
    public const string ProductSubcategoryId = "ProductSubcategoryID";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.Product.ProductModelId" />
    /// </summary>
    public const string ProductModelId = "ProductModelID";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.Product.SellStartDate" />
    /// </summary>
    public const string SellStartDate = "SellStartDate";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.Product.SellEndDate" />
    /// </summary>
    public const string SellEndDate = "SellEndDate";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.Product.DiscontinuedDate" />
    /// </summary>
    public const string DiscontinuedDate = "DiscontinuedDate";

    /// <summary>
    ///   Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.Product.Rowguid" />
    /// </summary>
    public const string Rowguid = "rowguid";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.Product.ModifiedDate" />
    /// </summary>
    public const string ModifiedDate = "ModifiedDate";
  }

  #endregion
}
