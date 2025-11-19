using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Data.EntityConfiguration;

namespace Platy.AdventureWorks.Repository.Data;

/// <summary>
///   A <see cref="DbContext" /> instance represents a session with the database and can be used to query and save
///   instances of entities.
/// </summary>
internal class AdventureWorksContext : DbContext
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="AdventureWorksContext" /> class.
  /// </summary>
  /// <param name="GeneratorOptions">The GeneratorOptions to be used by this <see cref="DbContext" />.</param>
  public AdventureWorksContext(DbContextOptions<AdventureWorksContext> options)
    : base(options)
  {
  }

  /// <summary>
  ///   Configure the model that was discovered from the entity types exposed in
  ///   <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> properties on this context.
  /// </summary>
  /// <param name="modelBuilder">The builder being used to construct the model for this context.</param>
  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    #region Generated Configuration

    modelBuilder.ApplyConfiguration(new AddressConfiguration());
    modelBuilder.ApplyConfiguration(new AddressTypeConfiguration());
    modelBuilder.ApplyConfiguration(new BillOfMaterialsConfiguration());
    modelBuilder.ApplyConfiguration(new BusinessEntityAddressConfiguration());
    modelBuilder.ApplyConfiguration(new BusinessEntityConfiguration());
    modelBuilder.ApplyConfiguration(new BusinessEntityContactConfiguration());
    modelBuilder.ApplyConfiguration(new ContactTypeConfiguration());
    modelBuilder.ApplyConfiguration(new CountryRegionConfiguration());
    modelBuilder.ApplyConfiguration(new CountryRegionCurrencyConfiguration());
    modelBuilder.ApplyConfiguration(new CreditCardConfiguration());
    modelBuilder.ApplyConfiguration(new CultureConfiguration());
    modelBuilder.ApplyConfiguration(new CurrencyConfiguration());
    modelBuilder.ApplyConfiguration(new CurrencyRateConfiguration());
    modelBuilder.ApplyConfiguration(new CustomerConfiguration());
    modelBuilder.ApplyConfiguration(new DepartmentConfiguration());
    modelBuilder.ApplyConfiguration(new EmailAddressConfiguration());
    modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
    modelBuilder.ApplyConfiguration(new EmployeeDepartmentHistoryConfiguration());
    modelBuilder.ApplyConfiguration(new EmployeePayHistoryConfiguration());
    modelBuilder.ApplyConfiguration(new IllustrationConfiguration());
    modelBuilder.ApplyConfiguration(new JobCandidateConfiguration());
    modelBuilder.ApplyConfiguration(new LocationConfiguration());
    modelBuilder.ApplyConfiguration(new PasswordConfiguration());
    modelBuilder.ApplyConfiguration(new PersonConfiguration());
    modelBuilder.ApplyConfiguration(new PersonCreditCardConfiguration());
    modelBuilder.ApplyConfiguration(new PersonPhoneConfiguration());
    modelBuilder.ApplyConfiguration(new PhoneNumberTypeConfiguration());
    modelBuilder.ApplyConfiguration(new ProductCategoryConfiguration());
    modelBuilder.ApplyConfiguration(new ProductConfiguration());
    modelBuilder.ApplyConfiguration(new ProductCostHistoryConfiguration());
    modelBuilder.ApplyConfiguration(new ProductDescriptionConfiguration());
    modelBuilder.ApplyConfiguration(new ProductDocumentConfiguration());
    modelBuilder.ApplyConfiguration(new ProductInventoryConfiguration());
    modelBuilder.ApplyConfiguration(new ProductListPriceHistoryConfiguration());
    modelBuilder.ApplyConfiguration(new ProductModelConfiguration());
    modelBuilder.ApplyConfiguration(new ProductModelIllustrationConfiguration());
    modelBuilder.ApplyConfiguration(new ProductModelProductDescriptionCultureConfiguration());
    modelBuilder.ApplyConfiguration(new ProductPhotoConfiguration());
    modelBuilder.ApplyConfiguration(new ProductProductPhotoConfiguration());
    modelBuilder.ApplyConfiguration(new ProductReviewConfiguration());
    modelBuilder.ApplyConfiguration(new ProductSubcategoryConfiguration());
    modelBuilder.ApplyConfiguration(new ProductVendorConfiguration());
    modelBuilder.ApplyConfiguration(new PurchaseOrderDetailConfiguration());
    modelBuilder.ApplyConfiguration(new PurchaseOrderHeaderConfiguration());
    modelBuilder.ApplyConfiguration(new SalesOrderDetailConfiguration());
    modelBuilder.ApplyConfiguration(new SalesOrderHeaderConfiguration());
    modelBuilder.ApplyConfiguration(new SalesOrderHeaderSalesReasonConfiguration());
    modelBuilder.ApplyConfiguration(new SalesPersonConfiguration());
    modelBuilder.ApplyConfiguration(new SalesPersonQuotaHistoryConfiguration());
    modelBuilder.ApplyConfiguration(new SalesReasonConfiguration());
    modelBuilder.ApplyConfiguration(new SalesTaxRateConfiguration());
    modelBuilder.ApplyConfiguration(new SalesTerritoryConfiguration());
    modelBuilder.ApplyConfiguration(new SalesTerritoryHistoryConfiguration());
    modelBuilder.ApplyConfiguration(new ScrapReasonConfiguration());
    modelBuilder.ApplyConfiguration(new ShiftConfiguration());
    modelBuilder.ApplyConfiguration(new ShipMethodConfiguration());
    modelBuilder.ApplyConfiguration(new ShoppingCartItemConfiguration());
    modelBuilder.ApplyConfiguration(new SpecialOfferConfiguration());
    modelBuilder.ApplyConfiguration(new SpecialOfferProductConfiguration());
    modelBuilder.ApplyConfiguration(new StateProvinceConfiguration());
    modelBuilder.ApplyConfiguration(new StoreConfiguration());
    modelBuilder.ApplyConfiguration(new TransactionHistoryArchiveConfiguration());
    modelBuilder.ApplyConfiguration(new TransactionHistoryConfiguration());
    modelBuilder.ApplyConfiguration(new UnitMeasureConfiguration());
    modelBuilder.ApplyConfiguration(new VAdditionalContactInfoConfiguration());
    modelBuilder.ApplyConfiguration(new VEmployeeConfiguration());
    modelBuilder.ApplyConfiguration(new VEmployeeDepartmentConfiguration());
    modelBuilder.ApplyConfiguration(new VEmployeeDepartmentHistoryConfiguration());
    modelBuilder.ApplyConfiguration(new VendorConfiguration());
    modelBuilder.ApplyConfiguration(new VIndividualCustomerConfiguration());
    modelBuilder.ApplyConfiguration(new VJobCandidateConfiguration());
    modelBuilder.ApplyConfiguration(new VJobCandidateEducationConfiguration());
    modelBuilder.ApplyConfiguration(new VJobCandidateEmploymentConfiguration());
    modelBuilder.ApplyConfiguration(new VPersonDemographicsConfiguration());
    modelBuilder.ApplyConfiguration(new VProductAndDescriptionConfiguration());
    modelBuilder.ApplyConfiguration(new VProductModelCatalogDescriptionConfiguration());
    modelBuilder.ApplyConfiguration(new VProductModelInstructionsConfiguration());
    modelBuilder.ApplyConfiguration(new VSalesPersonConfiguration());
    modelBuilder.ApplyConfiguration(new VSalesPersonSalesByFiscalYearsConfiguration());
    modelBuilder.ApplyConfiguration(new VStateProvinceCountryRegionConfiguration());
    modelBuilder.ApplyConfiguration(new VStoreWithAddressesConfiguration());
    modelBuilder.ApplyConfiguration(new VStoreWithContactsConfiguration());
    modelBuilder.ApplyConfiguration(new VStoreWithDemographicsConfiguration());
    modelBuilder.ApplyConfiguration(new VVendorWithAddressesConfiguration());
    modelBuilder.ApplyConfiguration(new VVendorWithContactsConfiguration());
    modelBuilder.ApplyConfiguration(new WorkOrderConfiguration());
    modelBuilder.ApplyConfiguration(new WorkOrderRoutingConfiguration());

    #endregion
  }

  #region Generated Properties

  /// <summary>
  ///   Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances
  ///   of <see cref="Platy.AdventureWorks.Repository.Data.Entities.Address" />.
  /// </summary>
  /// <value>
  ///   The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of
  ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.Address" />.
  /// </value>
  public virtual DbSet<Address> Addresses { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances
  ///   of <see cref="Platy.AdventureWorks.Repository.Data.Entities.AddressType" />.
  /// </summary>
  /// <value>
  ///   The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of
  ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.AddressType" />.
  /// </value>
  public virtual DbSet<AddressType> AddressTypes { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances
  ///   of <see cref="Platy.AdventureWorks.Repository.Data.Entities.BillOfMaterials" />.
  /// </summary>
  /// <value>
  ///   The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of
  ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.BillOfMaterials" />.
  /// </value>
  public virtual DbSet<BillOfMaterials> BillOfMaterials { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances
  ///   of <see cref="Platy.AdventureWorks.Repository.Data.Entities.BusinessEntity" />.
  /// </summary>
  /// <value>
  ///   The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of
  ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.BusinessEntity" />.
  /// </value>
  public virtual DbSet<BusinessEntity> BusinessEntities { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances
  ///   of <see cref="Platy.AdventureWorks.Repository.Data.Entities.BusinessEntityAddress" />.
  /// </summary>
  /// <value>
  ///   The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of
  ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.BusinessEntityAddress" />.
  /// </value>
  public virtual DbSet<BusinessEntityAddress> BusinessEntityAddresses { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances
  ///   of <see cref="Platy.AdventureWorks.Repository.Data.Entities.BusinessEntityContact" />.
  /// </summary>
  /// <value>
  ///   The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of
  ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.BusinessEntityContact" />.
  /// </value>
  public virtual DbSet<BusinessEntityContact> BusinessEntityContacts { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances
  ///   of <see cref="Platy.AdventureWorks.Repository.Data.Entities.ContactType" />.
  /// </summary>
  /// <value>
  ///   The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of
  ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.ContactType" />.
  /// </value>
  public virtual DbSet<ContactType> ContactTypes { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances
  ///   of <see cref="Platy.AdventureWorks.Repository.Data.Entities.CountryRegionCurrency" />.
  /// </summary>
  /// <value>
  ///   The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of
  ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.CountryRegionCurrency" />.
  /// </value>
  public virtual DbSet<CountryRegionCurrency> CountryRegionCurrencies { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances
  ///   of <see cref="Platy.AdventureWorks.Repository.Data.Entities.CountryRegion" />.
  /// </summary>
  /// <value>
  ///   The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of
  ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.CountryRegion" />.
  /// </value>
  public virtual DbSet<CountryRegion> CountryRegions { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances
  ///   of <see cref="Platy.AdventureWorks.Repository.Data.Entities.CreditCard" />.
  /// </summary>
  /// <value>
  ///   The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of
  ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.CreditCard" />.
  /// </value>
  public virtual DbSet<CreditCard> CreditCards { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances
  ///   of <see cref="Platy.AdventureWorks.Repository.Data.Entities.Culture" />.
  /// </summary>
  /// <value>
  ///   The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of
  ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.Culture" />.
  /// </value>
  public virtual DbSet<Culture> Cultures { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances
  ///   of <see cref="Platy.AdventureWorks.Repository.Data.Entities.Currency" />.
  /// </summary>
  /// <value>
  ///   The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of
  ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.Currency" />.
  /// </value>
  public virtual DbSet<Currency> Currencies { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances
  ///   of <see cref="Platy.AdventureWorks.Repository.Data.Entities.CurrencyRate" />.
  /// </summary>
  /// <value>
  ///   The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of
  ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.CurrencyRate" />.
  /// </value>
  public virtual DbSet<CurrencyRate> CurrencyRates { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances
  ///   of <see cref="Platy.AdventureWorks.Repository.Data.Entities.Customer" />.
  /// </summary>
  /// <value>
  ///   The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of
  ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.Customer" />.
  /// </value>
  public virtual DbSet<Customer> Customers { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances
  ///   of <see cref="Platy.AdventureWorks.Repository.Data.Entities.Department" />.
  /// </summary>
  /// <value>
  ///   The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of
  ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.Department" />.
  /// </value>
  public virtual DbSet<Department> Departments { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances
  ///   of <see cref="Platy.AdventureWorks.Repository.Data.Entities.EmailAddress" />.
  /// </summary>
  /// <value>
  ///   The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of
  ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.EmailAddress" />.
  /// </value>
  public virtual DbSet<EmailAddress> EmailAddresses { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances
  ///   of <see cref="Platy.AdventureWorks.Repository.Data.Entities.EmployeeDepartmentHistory" />.
  /// </summary>
  /// <value>
  ///   The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of
  ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.EmployeeDepartmentHistory" />.
  /// </value>
  public virtual DbSet<EmployeeDepartmentHistory> EmployeeDepartmentHistories { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances
  ///   of <see cref="Platy.AdventureWorks.Repository.Data.Entities.EmployeePayHistory" />.
  /// </summary>
  /// <value>
  ///   The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of
  ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.EmployeePayHistory" />.
  /// </value>
  public virtual DbSet<EmployeePayHistory> EmployeePayHistories { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances
  ///   of <see cref="Platy.AdventureWorks.Repository.Data.Entities.Employee" />.
  /// </summary>
  /// <value>
  ///   The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of
  ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.Employee" />.
  /// </value>
  public virtual DbSet<Employee> Employees { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances
  ///   of <see cref="Platy.AdventureWorks.Repository.Data.Entities.Illustration" />.
  /// </summary>
  /// <value>
  ///   The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of
  ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.Illustration" />.
  /// </value>
  public virtual DbSet<Illustration> Illustrations { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances
  ///   of <see cref="Platy.AdventureWorks.Repository.Data.Entities.JobCandidate" />.
  /// </summary>
  /// <value>
  ///   The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of
  ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.JobCandidate" />.
  /// </value>
  public virtual DbSet<JobCandidate> JobCandidates { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances
  ///   of <see cref="Platy.AdventureWorks.Repository.Data.Entities.Location" />.
  /// </summary>
  /// <value>
  ///   The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of
  ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.Location" />.
  /// </value>
  public virtual DbSet<Location> Locations { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances
  ///   of <see cref="Platy.AdventureWorks.Repository.Data.Entities.Password" />.
  /// </summary>
  /// <value>
  ///   The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of
  ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.Password" />.
  /// </value>
  public virtual DbSet<Password> Passwords { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances
  ///   of <see cref="Platy.AdventureWorks.Repository.Data.Entities.Person" />.
  /// </summary>
  /// <value>
  ///   The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of
  ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.Person" />.
  /// </value>
  public virtual DbSet<Person> People { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances
  ///   of <see cref="Platy.AdventureWorks.Repository.Data.Entities.PersonCreditCard" />.
  /// </summary>
  /// <value>
  ///   The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of
  ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.PersonCreditCard" />.
  /// </value>
  public virtual DbSet<PersonCreditCard> PersonCreditCards { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances
  ///   of <see cref="Platy.AdventureWorks.Repository.Data.Entities.PersonPhone" />.
  /// </summary>
  /// <value>
  ///   The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of
  ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.PersonPhone" />.
  /// </value>
  public virtual DbSet<PersonPhone> PersonPhones { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances
  ///   of <see cref="Platy.AdventureWorks.Repository.Data.Entities.PhoneNumberType" />.
  /// </summary>
  /// <value>
  ///   The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of
  ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.PhoneNumberType" />.
  /// </value>
  public virtual DbSet<PhoneNumberType> PhoneNumberTypes { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances
  ///   of <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductCategory" />.
  /// </summary>
  /// <value>
  ///   The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of
  ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductCategory" />.
  /// </value>
  public virtual DbSet<ProductCategory> ProductCategories { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances
  ///   of <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductCostHistory" />.
  /// </summary>
  /// <value>
  ///   The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of
  ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductCostHistory" />.
  /// </value>
  public virtual DbSet<ProductCostHistory> ProductCostHistories { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances
  ///   of <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductDescription" />.
  /// </summary>
  /// <value>
  ///   The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of
  ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductDescription" />.
  /// </value>
  public virtual DbSet<ProductDescription> ProductDescriptions { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances
  ///   of <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductDocument" />.
  /// </summary>
  /// <value>
  ///   The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of
  ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductDocument" />.
  /// </value>
  public virtual DbSet<ProductDocument> ProductDocuments { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances
  ///   of <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductInventory" />.
  /// </summary>
  /// <value>
  ///   The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of
  ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductInventory" />.
  /// </value>
  public virtual DbSet<ProductInventory> ProductInventories { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances
  ///   of <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductListPriceHistory" />.
  /// </summary>
  /// <value>
  ///   The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of
  ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductListPriceHistory" />.
  /// </value>
  public virtual DbSet<ProductListPriceHistory> ProductListPriceHistories { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances
  ///   of <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductModelIllustration" />.
  /// </summary>
  /// <value>
  ///   The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of
  ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductModelIllustration" />.
  /// </value>
  public virtual DbSet<ProductModelIllustration> ProductModelIllustrations { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances
  ///   of <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductModelProductDescriptionCulture" />.
  /// </summary>
  /// <value>
  ///   The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of
  ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductModelProductDescriptionCulture" />.
  /// </value>
  public virtual DbSet<ProductModelProductDescriptionCulture> ProductModelProductDescriptionCultures { get; set; } =
    null!;

  /// <summary>
  ///   Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances
  ///   of <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductModel" />.
  /// </summary>
  /// <value>
  ///   The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of
  ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductModel" />.
  /// </value>
  public virtual DbSet<ProductModel> ProductModels { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances
  ///   of <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductPhoto" />.
  /// </summary>
  /// <value>
  ///   The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of
  ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductPhoto" />.
  /// </value>
  public virtual DbSet<ProductPhoto> ProductPhotos { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances
  ///   of <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductProductPhoto" />.
  /// </summary>
  /// <value>
  ///   The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of
  ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductProductPhoto" />.
  /// </value>
  public virtual DbSet<ProductProductPhoto> ProductProductPhotos { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances
  ///   of <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductReview" />.
  /// </summary>
  /// <value>
  ///   The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of
  ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductReview" />.
  /// </value>
  public virtual DbSet<ProductReview> ProductReviews { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances
  ///   of <see cref="Platy.AdventureWorks.Repository.Data.Entities.Product" />.
  /// </summary>
  /// <value>
  ///   The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of
  ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.Product" />.
  /// </value>
  public virtual DbSet<Product> Products { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances
  ///   of <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductSubcategory" />.
  /// </summary>
  /// <value>
  ///   The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of
  ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductSubcategory" />.
  /// </value>
  public virtual DbSet<ProductSubcategory> ProductSubcategories { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances
  ///   of <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductVendor" />.
  /// </summary>
  /// <value>
  ///   The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of
  ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductVendor" />.
  /// </value>
  public virtual DbSet<ProductVendor> ProductVendors { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances
  ///   of <see cref="Platy.AdventureWorks.Repository.Data.Entities.PurchaseOrderDetail" />.
  /// </summary>
  /// <value>
  ///   The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of
  ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.PurchaseOrderDetail" />.
  /// </value>
  public virtual DbSet<PurchaseOrderDetail> PurchaseOrderDetails { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances
  ///   of <see cref="Platy.AdventureWorks.Repository.Data.Entities.PurchaseOrderHeader" />.
  /// </summary>
  /// <value>
  ///   The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of
  ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.PurchaseOrderHeader" />.
  /// </value>
  public virtual DbSet<PurchaseOrderHeader> PurchaseOrderHeaders { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances
  ///   of <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesOrderDetail" />.
  /// </summary>
  /// <value>
  ///   The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of
  ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesOrderDetail" />.
  /// </value>
  public virtual DbSet<SalesOrderDetail> SalesOrderDetails { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances
  ///   of <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesOrderHeader" />.
  /// </summary>
  /// <value>
  ///   The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of
  ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesOrderHeader" />.
  /// </value>
  public virtual DbSet<SalesOrderHeader> SalesOrderHeaders { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances
  ///   of <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesOrderHeaderSalesReason" />.
  /// </summary>
  /// <value>
  ///   The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of
  ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesOrderHeaderSalesReason" />.
  /// </value>
  public virtual DbSet<SalesOrderHeaderSalesReason> SalesOrderHeaderSalesReasons { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances
  ///   of <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesPerson" />.
  /// </summary>
  /// <value>
  ///   The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of
  ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesPerson" />.
  /// </value>
  public virtual DbSet<SalesPerson> SalesPeople { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances
  ///   of <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesPersonQuotaHistory" />.
  /// </summary>
  /// <value>
  ///   The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of
  ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesPersonQuotaHistory" />.
  /// </value>
  public virtual DbSet<SalesPersonQuotaHistory> SalesPersonQuotaHistories { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances
  ///   of <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesReason" />.
  /// </summary>
  /// <value>
  ///   The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of
  ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesReason" />.
  /// </value>
  public virtual DbSet<SalesReason> SalesReasons { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances
  ///   of <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesTaxRate" />.
  /// </summary>
  /// <value>
  ///   The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of
  ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesTaxRate" />.
  /// </value>
  public virtual DbSet<SalesTaxRate> SalesTaxRates { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances
  ///   of <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesTerritory" />.
  /// </summary>
  /// <value>
  ///   The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of
  ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesTerritory" />.
  /// </value>
  public virtual DbSet<SalesTerritory> SalesTerritories { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances
  ///   of <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesTerritoryHistory" />.
  /// </summary>
  /// <value>
  ///   The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of
  ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesTerritoryHistory" />.
  /// </value>
  public virtual DbSet<SalesTerritoryHistory> SalesTerritoryHistories { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances
  ///   of <see cref="Platy.AdventureWorks.Repository.Data.Entities.ScrapReason" />.
  /// </summary>
  /// <value>
  ///   The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of
  ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.ScrapReason" />.
  /// </value>
  public virtual DbSet<ScrapReason> ScrapReasons { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances
  ///   of <see cref="Platy.AdventureWorks.Repository.Data.Entities.Shift" />.
  /// </summary>
  /// <value>
  ///   The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of
  ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.Shift" />.
  /// </value>
  public virtual DbSet<Shift> Shifts { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances
  ///   of <see cref="Platy.AdventureWorks.Repository.Data.Entities.ShipMethod" />.
  /// </summary>
  /// <value>
  ///   The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of
  ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.ShipMethod" />.
  /// </value>
  public virtual DbSet<ShipMethod> ShipMethods { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances
  ///   of <see cref="Platy.AdventureWorks.Repository.Data.Entities.ShoppingCartItem" />.
  /// </summary>
  /// <value>
  ///   The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of
  ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.ShoppingCartItem" />.
  /// </value>
  public virtual DbSet<ShoppingCartItem> ShoppingCartItems { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances
  ///   of <see cref="Platy.AdventureWorks.Repository.Data.Entities.SpecialOfferProduct" />.
  /// </summary>
  /// <value>
  ///   The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of
  ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.SpecialOfferProduct" />.
  /// </value>
  public virtual DbSet<SpecialOfferProduct> SpecialOfferProducts { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances
  ///   of <see cref="Platy.AdventureWorks.Repository.Data.Entities.SpecialOffer" />.
  /// </summary>
  /// <value>
  ///   The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of
  ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.SpecialOffer" />.
  /// </value>
  public virtual DbSet<SpecialOffer> SpecialOffers { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances
  ///   of <see cref="Platy.AdventureWorks.Repository.Data.Entities.StateProvince" />.
  /// </summary>
  /// <value>
  ///   The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of
  ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.StateProvince" />.
  /// </value>
  public virtual DbSet<StateProvince> StateProvinces { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances
  ///   of <see cref="Platy.AdventureWorks.Repository.Data.Entities.Store" />.
  /// </summary>
  /// <value>
  ///   The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of
  ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.Store" />.
  /// </value>
  public virtual DbSet<Store> Stores { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances
  ///   of <see cref="Platy.AdventureWorks.Repository.Data.Entities.TransactionHistory" />.
  /// </summary>
  /// <value>
  ///   The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of
  ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.TransactionHistory" />.
  /// </value>
  public virtual DbSet<TransactionHistory> TransactionHistories { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances
  ///   of <see cref="Platy.AdventureWorks.Repository.Data.Entities.TransactionHistoryArchive" />.
  /// </summary>
  /// <value>
  ///   The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of
  ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.TransactionHistoryArchive" />.
  /// </value>
  public virtual DbSet<TransactionHistoryArchive> TransactionHistoryArchives { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances
  ///   of <see cref="Platy.AdventureWorks.Repository.Data.Entities.UnitMeasure" />.
  /// </summary>
  /// <value>
  ///   The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of
  ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.UnitMeasure" />.
  /// </value>
  public virtual DbSet<UnitMeasure> UnitMeasures { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances
  ///   of <see cref="Platy.AdventureWorks.Repository.Data.Entities.VAdditionalContactInfo" />.
  /// </summary>
  /// <value>
  ///   The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of
  ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.VAdditionalContactInfo" />.
  /// </value>
  public virtual DbSet<VAdditionalContactInfo> VAdditionalContactInfos { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances
  ///   of <see cref="Platy.AdventureWorks.Repository.Data.Entities.VEmployeeDepartmentHistory" />.
  /// </summary>
  /// <value>
  ///   The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of
  ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.VEmployeeDepartmentHistory" />.
  /// </value>
  public virtual DbSet<VEmployeeDepartmentHistory> VEmployeeDepartmentHistories { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances
  ///   of <see cref="Platy.AdventureWorks.Repository.Data.Entities.VEmployeeDepartment" />.
  /// </summary>
  /// <value>
  ///   The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of
  ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.VEmployeeDepartment" />.
  /// </value>
  public virtual DbSet<VEmployeeDepartment> VEmployeeDepartments { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances
  ///   of <see cref="Platy.AdventureWorks.Repository.Data.Entities.VEmployee" />.
  /// </summary>
  /// <value>
  ///   The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of
  ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.VEmployee" />.
  /// </value>
  public virtual DbSet<VEmployee> VEmployees { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances
  ///   of <see cref="Platy.AdventureWorks.Repository.Data.Entities.Vendor" />.
  /// </summary>
  /// <value>
  ///   The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of
  ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.Vendor" />.
  /// </value>
  public virtual DbSet<Vendor> Vendors { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances
  ///   of <see cref="Platy.AdventureWorks.Repository.Data.Entities.VIndividualCustomer" />.
  /// </summary>
  /// <value>
  ///   The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of
  ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.VIndividualCustomer" />.
  /// </value>
  public virtual DbSet<VIndividualCustomer> VIndividualCustomers { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances
  ///   of <see cref="Platy.AdventureWorks.Repository.Data.Entities.VJobCandidateEducation" />.
  /// </summary>
  /// <value>
  ///   The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of
  ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.VJobCandidateEducation" />.
  /// </value>
  public virtual DbSet<VJobCandidateEducation> VJobCandidateEducations { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances
  ///   of <see cref="Platy.AdventureWorks.Repository.Data.Entities.VJobCandidateEmployment" />.
  /// </summary>
  /// <value>
  ///   The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of
  ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.VJobCandidateEmployment" />.
  /// </value>
  public virtual DbSet<VJobCandidateEmployment> VJobCandidateEmployments { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances
  ///   of <see cref="Platy.AdventureWorks.Repository.Data.Entities.VJobCandidate" />.
  /// </summary>
  /// <value>
  ///   The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of
  ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.VJobCandidate" />.
  /// </value>
  public virtual DbSet<VJobCandidate> VJobCandidates { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances
  ///   of <see cref="Platy.AdventureWorks.Repository.Data.Entities.VPersonDemographics" />.
  /// </summary>
  /// <value>
  ///   The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of
  ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.VPersonDemographics" />.
  /// </value>
  public virtual DbSet<VPersonDemographics> VPersonDemographics { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances
  ///   of <see cref="Platy.AdventureWorks.Repository.Data.Entities.VProductAndDescription" />.
  /// </summary>
  /// <value>
  ///   The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of
  ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.VProductAndDescription" />.
  /// </value>
  public virtual DbSet<VProductAndDescription> VProductAndDescriptions { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances
  ///   of <see cref="Platy.AdventureWorks.Repository.Data.Entities.VProductModelCatalogDescription" />.
  /// </summary>
  /// <value>
  ///   The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of
  ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.VProductModelCatalogDescription" />.
  /// </value>
  public virtual DbSet<VProductModelCatalogDescription> VProductModelCatalogDescriptions { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances
  ///   of <see cref="Platy.AdventureWorks.Repository.Data.Entities.VProductModelInstructions" />.
  /// </summary>
  /// <value>
  ///   The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of
  ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.VProductModelInstructions" />.
  /// </value>
  public virtual DbSet<VProductModelInstructions> VProductModelInstructions { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances
  ///   of <see cref="Platy.AdventureWorks.Repository.Data.Entities.VSalesPerson" />.
  /// </summary>
  /// <value>
  ///   The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of
  ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.VSalesPerson" />.
  /// </value>
  public virtual DbSet<VSalesPerson> VSalesPeople { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances
  ///   of <see cref="Platy.AdventureWorks.Repository.Data.Entities.VSalesPersonSalesByFiscalYears" />.
  /// </summary>
  /// <value>
  ///   The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of
  ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.VSalesPersonSalesByFiscalYears" />.
  /// </value>
  public virtual DbSet<VSalesPersonSalesByFiscalYears> VSalesPersonSalesByFiscalYears { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances
  ///   of <see cref="Platy.AdventureWorks.Repository.Data.Entities.VStateProvinceCountryRegion" />.
  /// </summary>
  /// <value>
  ///   The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of
  ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.VStateProvinceCountryRegion" />.
  /// </value>
  public virtual DbSet<VStateProvinceCountryRegion> VStateProvinceCountryRegions { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances
  ///   of <see cref="Platy.AdventureWorks.Repository.Data.Entities.VStoreWithAddresses" />.
  /// </summary>
  /// <value>
  ///   The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of
  ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.VStoreWithAddresses" />.
  /// </value>
  public virtual DbSet<VStoreWithAddresses> VStoreWithAddresses { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances
  ///   of <see cref="Platy.AdventureWorks.Repository.Data.Entities.VStoreWithContacts" />.
  /// </summary>
  /// <value>
  ///   The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of
  ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.VStoreWithContacts" />.
  /// </value>
  public virtual DbSet<VStoreWithContacts> VStoreWithContacts { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances
  ///   of <see cref="Platy.AdventureWorks.Repository.Data.Entities.VStoreWithDemographics" />.
  /// </summary>
  /// <value>
  ///   The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of
  ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.VStoreWithDemographics" />.
  /// </value>
  public virtual DbSet<VStoreWithDemographics> VStoreWithDemographics { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances
  ///   of <see cref="Platy.AdventureWorks.Repository.Data.Entities.VVendorWithAddresses" />.
  /// </summary>
  /// <value>
  ///   The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of
  ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.VVendorWithAddresses" />.
  /// </value>
  public virtual DbSet<VVendorWithAddresses> VVendorWithAddresses { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances
  ///   of <see cref="Platy.AdventureWorks.Repository.Data.Entities.VVendorWithContacts" />.
  /// </summary>
  /// <value>
  ///   The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of
  ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.VVendorWithContacts" />.
  /// </value>
  public virtual DbSet<VVendorWithContacts> VVendorWithContacts { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances
  ///   of <see cref="Platy.AdventureWorks.Repository.Data.Entities.WorkOrderRouting" />.
  /// </summary>
  /// <value>
  ///   The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of
  ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.WorkOrderRouting" />.
  /// </value>
  public virtual DbSet<WorkOrderRouting> WorkOrderRoutings { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances
  ///   of <see cref="Platy.AdventureWorks.Repository.Data.Entities.WorkOrder" />.
  /// </summary>
  /// <value>
  ///   The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of
  ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.WorkOrder" />.
  /// </value>
  public virtual DbSet<WorkOrder> WorkOrders { get; set; } = null!;

  #endregion
}
