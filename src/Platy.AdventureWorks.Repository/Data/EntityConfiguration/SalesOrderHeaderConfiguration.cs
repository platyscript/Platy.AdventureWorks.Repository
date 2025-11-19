using Platy.AdventureWorks.Repository.Data.Entities;

namespace Platy.AdventureWorks.Repository.Data.EntityConfiguration;

/// <summary>
///   Allows configuration for an entity type <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesOrderHeader" />
/// </summary>
internal class SalesOrderHeaderConfiguration
  : IEntityTypeConfiguration<SalesOrderHeader>
{
  /// <summary>
  ///   Configures the entity of type <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesOrderHeader" />
  /// </summary>
  /// <param name="builder">The builder to be used to configure the entity type.</param>
  public void Configure(EntityTypeBuilder<SalesOrderHeader> builder)
  {
    #region Generated Configure

    // table
    builder.ToTable("SalesOrderHeader", "Sales");

    // key
    builder.HasKey(t => t.Id);

    // properties
    builder.Property(t => t.Id)
      .IsRequired()
      .HasColumnName("SalesOrderID")
      .HasColumnType("int")
      .ValueGeneratedOnAdd();

    builder.Property(t => t.RevisionNumber)
      .IsRequired()
      .HasColumnName("RevisionNumber")
      .HasColumnType("tinyint")
      .HasDefaultValue(0);

    builder.Property(t => t.OrderDate)
      .IsRequired()
      .HasColumnName("OrderDate")
      .HasColumnType("datetime")
      .HasDefaultValueSql("(getdate())");

    builder.Property(t => t.DueDate)
      .IsRequired()
      .HasColumnName("DueDate")
      .HasColumnType("datetime");

    builder.Property(t => t.ShipDate)
      .HasColumnName("ShipDate")
      .HasColumnType("datetime");

    builder.Property(t => t.Status)
      .IsRequired()
      .HasColumnName("Status")
      .HasColumnType("tinyint")
      .HasDefaultValue(1);

    builder.Property(t => t.OnlineOrderFlag)
      .IsRequired()
      .HasColumnName("OnlineOrderFlag")
      .HasColumnType("bit")
      .HasDefaultValue(true);

    builder.Property(t => t.SalesOrderNumber)
      .IsRequired()
      .HasColumnName("SalesOrderNumber")
      .HasColumnType("nvarchar(25)")
      .HasMaxLength(25)
      .ValueGeneratedOnAddOrUpdate();

    builder.Property(t => t.PurchaseOrderNumber)
      .HasColumnName("PurchaseOrderNumber")
      .HasColumnType("nvarchar(25)")
      .HasMaxLength(25);

    builder.Property(t => t.AccountNumber)
      .HasColumnName("AccountNumber")
      .HasColumnType("nvarchar(15)")
      .HasMaxLength(15);

    builder.Property(t => t.CustomerId)
      .IsRequired()
      .HasColumnName("CustomerID")
      .HasColumnType("int");

    builder.Property(t => t.SalesPersonId)
      .HasColumnName("SalesPersonID")
      .HasColumnType("int");

    builder.Property(t => t.TerritoryId)
      .HasColumnName("TerritoryID")
      .HasColumnType("int");

    builder.Property(t => t.BillToAddressId)
      .IsRequired()
      .HasColumnName("BillToAddressID")
      .HasColumnType("int");

    builder.Property(t => t.ShipToAddressId)
      .IsRequired()
      .HasColumnName("ShipToAddressID")
      .HasColumnType("int");

    builder.Property(t => t.ShipMethodId)
      .IsRequired()
      .HasColumnName("ShipMethodID")
      .HasColumnType("int");

    builder.Property(t => t.CreditCardId)
      .HasColumnName("CreditCardID")
      .HasColumnType("int");

    builder.Property(t => t.CreditCardApprovalCode)
      .HasColumnName("CreditCardApprovalCode")
      .HasColumnType("varchar(15)")
      .HasMaxLength(15);

    builder.Property(t => t.CurrencyRateId)
      .HasColumnName("CurrencyRateID")
      .HasColumnType("int");

    builder.Property(t => t.SubTotal)
      .IsRequired()
      .HasColumnName("SubTotal")
      .HasColumnType("money")
      .HasDefaultValueSql("((0.00))");

    builder.Property(t => t.TaxAmt)
      .IsRequired()
      .HasColumnName("TaxAmt")
      .HasColumnType("money")
      .HasDefaultValueSql("((0.00))");

    builder.Property(t => t.Freight)
      .IsRequired()
      .HasColumnName("Freight")
      .HasColumnType("money")
      .HasDefaultValueSql("((0.00))");

    builder.Property(t => t.TotalDue)
      .IsRequired()
      .HasColumnName("TotalDue")
      .HasColumnType("money")
      .ValueGeneratedOnAddOrUpdate();

    builder.Property(t => t.Comment)
      .HasColumnName("Comment")
      .HasColumnType("nvarchar(128)")
      .HasMaxLength(128);

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
    builder.HasOne(t => t.BillToAddress)
      .WithMany(t => t.BillToSalesOrderHeaders)
      .HasForeignKey(d => d.BillToAddressId)
      .HasConstraintName("FK_SalesOrderHeader_Address_BillToAddressID");

    builder.HasOne(t => t.ShipToAddress)
      .WithMany(t => t.ShipToSalesOrderHeaders)
      .HasForeignKey(d => d.ShipToAddressId)
      .HasConstraintName("FK_SalesOrderHeader_Address_ShipToAddressID");

    builder.HasOne(t => t.CreditCard)
      .WithMany(t => t.SalesOrderHeaders)
      .HasForeignKey(d => d.CreditCardId)
      .HasConstraintName("FK_SalesOrderHeader_CreditCard_CreditCardID");

    builder.HasOne(t => t.CurrencyRate)
      .WithMany(t => t.SalesOrderHeaders)
      .HasForeignKey(d => d.CurrencyRateId)
      .HasConstraintName("FK_SalesOrderHeader_CurrencyRate_CurrencyRateID");

    builder.HasOne(t => t.Customer)
      .WithMany(t => t.SalesOrderHeaders)
      .HasForeignKey(d => d.CustomerId)
      .HasConstraintName("FK_SalesOrderHeader_Customer_CustomerID");

    builder.HasOne(t => t.SalesPerson)
      .WithMany(t => t.SalesOrderHeaders)
      .HasForeignKey(d => d.SalesPersonId)
      .HasConstraintName("FK_SalesOrderHeader_SalesPerson_SalesPersonID");

    builder.HasOne(t => t.SalesTerritory)
      .WithMany(t => t.SalesOrderHeaders)
      .HasForeignKey(d => d.TerritoryId)
      .HasConstraintName("FK_SalesOrderHeader_SalesTerritory_TerritoryID");

    builder.HasOne(t => t.ShipMethod)
      .WithMany(t => t.SalesOrderHeaders)
      .HasForeignKey(d => d.ShipMethodId)
      .HasConstraintName("FK_SalesOrderHeader_ShipMethod_ShipMethodID");

    #endregion
  }

  #region Generated Constants

  internal readonly struct Table
  {
    /// <summary>
    ///   Table Schema name constant for entity
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesOrderHeader" />
    /// </summary>
    public const string Schema = "Sales";

    /// <summary>
    ///   Table Name constant for entity <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesOrderHeader" />
    /// </summary>
    public const string Name = "SalesOrderHeader";
  }

  internal readonly struct Columns
  {
    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesOrderHeader.Id" />
    /// </summary>
    public const string Id = "SalesOrderID";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesOrderHeader.RevisionNumber" />
    /// </summary>
    public const string RevisionNumber = "RevisionNumber";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesOrderHeader.OrderDate" />
    /// </summary>
    public const string OrderDate = "OrderDate";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesOrderHeader.DueDate" />
    /// </summary>
    public const string DueDate = "DueDate";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesOrderHeader.ShipDate" />
    /// </summary>
    public const string ShipDate = "ShipDate";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesOrderHeader.Status" />
    /// </summary>
    public const string Status = "Status";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesOrderHeader.OnlineOrderFlag" />
    /// </summary>
    public const string OnlineOrderFlag = "OnlineOrderFlag";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesOrderHeader.SalesOrderNumber" />
    /// </summary>
    public const string SalesOrderNumber = "SalesOrderNumber";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesOrderHeader.PurchaseOrderNumber" />
    /// </summary>
    public const string PurchaseOrderNumber = "PurchaseOrderNumber";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesOrderHeader.AccountNumber" />
    /// </summary>
    public const string AccountNumber = "AccountNumber";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesOrderHeader.CustomerId" />
    /// </summary>
    public const string CustomerId = "CustomerID";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesOrderHeader.SalesPersonId" />
    /// </summary>
    public const string SalesPersonId = "SalesPersonID";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesOrderHeader.TerritoryId" />
    /// </summary>
    public const string TerritoryId = "TerritoryID";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesOrderHeader.BillToAddressId" />
    /// </summary>
    public const string BillToAddressId = "BillToAddressID";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesOrderHeader.ShipToAddressId" />
    /// </summary>
    public const string ShipToAddressId = "ShipToAddressID";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesOrderHeader.ShipMethodId" />
    /// </summary>
    public const string ShipMethodId = "ShipMethodID";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesOrderHeader.CreditCardId" />
    /// </summary>
    public const string CreditCardId = "CreditCardID";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesOrderHeader.CreditCardApprovalCode" />
    /// </summary>
    public const string CreditCardApprovalCode = "CreditCardApprovalCode";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesOrderHeader.CurrencyRateId" />
    /// </summary>
    public const string CurrencyRateId = "CurrencyRateID";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesOrderHeader.SubTotal" />
    /// </summary>
    public const string SubTotal = "SubTotal";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesOrderHeader.TaxAmt" />
    /// </summary>
    public const string TaxAmt = "TaxAmt";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesOrderHeader.Freight" />
    /// </summary>
    public const string Freight = "Freight";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesOrderHeader.TotalDue" />
    /// </summary>
    public const string TotalDue = "TotalDue";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesOrderHeader.Comment" />
    /// </summary>
    public const string Comment = "Comment";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesOrderHeader.Rowguid" />
    /// </summary>
    public const string Rowguid = "rowguid";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesOrderHeader.ModifiedDate" />
    /// </summary>
    public const string ModifiedDate = "ModifiedDate";
  }

  #endregion
}
