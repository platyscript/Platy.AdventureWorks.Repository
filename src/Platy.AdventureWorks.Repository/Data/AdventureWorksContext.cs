using System;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Platy.AdventureWorks.Repository.Data;

/// <summary>
/// A <see cref="DbContext" /> instance represents a session with the database and can be used to query and save instances of entities. 
/// </summary>
internal partial class AdventureWorksContext : DbContext
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AdventureWorksContext"/> class.
    /// </summary>
    /// <param name="GeneratorOptions">The GeneratorOptions to be used by this <see cref="DbContext" />.</param>
    public AdventureWorksContext(DbContextOptions<AdventureWorksContext> options)
        : base(options)
    {
    }

    #region Generated Properties
    /// <summary>
    /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.Address"/>.
    /// </summary>
    /// <value>
    /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.Address"/>.
    /// </value>
    public virtual DbSet<Platy.AdventureWorks.Repository.Data.Entities.Address> Addresses { get; set; } = null!;

    /// <summary>
    /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.AddressType"/>.
    /// </summary>
    /// <value>
    /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.AddressType"/>.
    /// </value>
    public virtual DbSet<Platy.AdventureWorks.Repository.Data.Entities.AddressType> AddressTypes { get; set; } = null!;

    /// <summary>
    /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.BillOfMaterials"/>.
    /// </summary>
    /// <value>
    /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.BillOfMaterials"/>.
    /// </value>
    public virtual DbSet<Platy.AdventureWorks.Repository.Data.Entities.BillOfMaterials> BillOfMaterials { get; set; } = null!;

    /// <summary>
    /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.BusinessEntity"/>.
    /// </summary>
    /// <value>
    /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.BusinessEntity"/>.
    /// </value>
    public virtual DbSet<Platy.AdventureWorks.Repository.Data.Entities.BusinessEntity> BusinessEntities { get; set; } = null!;

    /// <summary>
    /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.BusinessEntityAddress"/>.
    /// </summary>
    /// <value>
    /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.BusinessEntityAddress"/>.
    /// </value>
    public virtual DbSet<Platy.AdventureWorks.Repository.Data.Entities.BusinessEntityAddress> BusinessEntityAddresses { get; set; } = null!;

    /// <summary>
    /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.BusinessEntityContact"/>.
    /// </summary>
    /// <value>
    /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.BusinessEntityContact"/>.
    /// </value>
    public virtual DbSet<Platy.AdventureWorks.Repository.Data.Entities.BusinessEntityContact> BusinessEntityContacts { get; set; } = null!;

    /// <summary>
    /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.ContactType"/>.
    /// </summary>
    /// <value>
    /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.ContactType"/>.
    /// </value>
    public virtual DbSet<Platy.AdventureWorks.Repository.Data.Entities.ContactType> ContactTypes { get; set; } = null!;

    /// <summary>
    /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.CountryRegionCurrency"/>.
    /// </summary>
    /// <value>
    /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.CountryRegionCurrency"/>.
    /// </value>
    public virtual DbSet<Platy.AdventureWorks.Repository.Data.Entities.CountryRegionCurrency> CountryRegionCurrencies { get; set; } = null!;

    /// <summary>
    /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.CountryRegion"/>.
    /// </summary>
    /// <value>
    /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.CountryRegion"/>.
    /// </value>
    public virtual DbSet<Platy.AdventureWorks.Repository.Data.Entities.CountryRegion> CountryRegions { get; set; } = null!;

    /// <summary>
    /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.CreditCard"/>.
    /// </summary>
    /// <value>
    /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.CreditCard"/>.
    /// </value>
    public virtual DbSet<Platy.AdventureWorks.Repository.Data.Entities.CreditCard> CreditCards { get; set; } = null!;

    /// <summary>
    /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.Culture"/>.
    /// </summary>
    /// <value>
    /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.Culture"/>.
    /// </value>
    public virtual DbSet<Platy.AdventureWorks.Repository.Data.Entities.Culture> Cultures { get; set; } = null!;

    /// <summary>
    /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.Currency"/>.
    /// </summary>
    /// <value>
    /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.Currency"/>.
    /// </value>
    public virtual DbSet<Platy.AdventureWorks.Repository.Data.Entities.Currency> Currencies { get; set; } = null!;

    /// <summary>
    /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.CurrencyRate"/>.
    /// </summary>
    /// <value>
    /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.CurrencyRate"/>.
    /// </value>
    public virtual DbSet<Platy.AdventureWorks.Repository.Data.Entities.CurrencyRate> CurrencyRates { get; set; } = null!;

    /// <summary>
    /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.Customer"/>.
    /// </summary>
    /// <value>
    /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.Customer"/>.
    /// </value>
    public virtual DbSet<Platy.AdventureWorks.Repository.Data.Entities.Customer> Customers { get; set; } = null!;

    /// <summary>
    /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.Department"/>.
    /// </summary>
    /// <value>
    /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.Department"/>.
    /// </value>
    public virtual DbSet<Platy.AdventureWorks.Repository.Data.Entities.Department> Departments { get; set; } = null!;

    /// <summary>
    /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.EmailAddress"/>.
    /// </summary>
    /// <value>
    /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.EmailAddress"/>.
    /// </value>
    public virtual DbSet<Platy.AdventureWorks.Repository.Data.Entities.EmailAddress> EmailAddresses { get; set; } = null!;

    /// <summary>
    /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.EmployeeDepartmentHistory"/>.
    /// </summary>
    /// <value>
    /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.EmployeeDepartmentHistory"/>.
    /// </value>
    public virtual DbSet<Platy.AdventureWorks.Repository.Data.Entities.EmployeeDepartmentHistory> EmployeeDepartmentHistories { get; set; } = null!;

    /// <summary>
    /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.EmployeePayHistory"/>.
    /// </summary>
    /// <value>
    /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.EmployeePayHistory"/>.
    /// </value>
    public virtual DbSet<Platy.AdventureWorks.Repository.Data.Entities.EmployeePayHistory> EmployeePayHistories { get; set; } = null!;

    /// <summary>
    /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.Employee"/>.
    /// </summary>
    /// <value>
    /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.Employee"/>.
    /// </value>
    public virtual DbSet<Platy.AdventureWorks.Repository.Data.Entities.Employee> Employees { get; set; } = null!;

    /// <summary>
    /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.Illustration"/>.
    /// </summary>
    /// <value>
    /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.Illustration"/>.
    /// </value>
    public virtual DbSet<Platy.AdventureWorks.Repository.Data.Entities.Illustration> Illustrations { get; set; } = null!;

    /// <summary>
    /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.JobCandidate"/>.
    /// </summary>
    /// <value>
    /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.JobCandidate"/>.
    /// </value>
    public virtual DbSet<Platy.AdventureWorks.Repository.Data.Entities.JobCandidate> JobCandidates { get; set; } = null!;

    /// <summary>
    /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.Location"/>.
    /// </summary>
    /// <value>
    /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.Location"/>.
    /// </value>
    public virtual DbSet<Platy.AdventureWorks.Repository.Data.Entities.Location> Locations { get; set; } = null!;

    /// <summary>
    /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.Password"/>.
    /// </summary>
    /// <value>
    /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.Password"/>.
    /// </value>
    public virtual DbSet<Platy.AdventureWorks.Repository.Data.Entities.Password> Passwords { get; set; } = null!;

    /// <summary>
    /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.Person"/>.
    /// </summary>
    /// <value>
    /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.Person"/>.
    /// </value>
    public virtual DbSet<Platy.AdventureWorks.Repository.Data.Entities.Person> People { get; set; } = null!;

    /// <summary>
    /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.PersonCreditCard"/>.
    /// </summary>
    /// <value>
    /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.PersonCreditCard"/>.
    /// </value>
    public virtual DbSet<Platy.AdventureWorks.Repository.Data.Entities.PersonCreditCard> PersonCreditCards { get; set; } = null!;

    /// <summary>
    /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.PersonPhone"/>.
    /// </summary>
    /// <value>
    /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.PersonPhone"/>.
    /// </value>
    public virtual DbSet<Platy.AdventureWorks.Repository.Data.Entities.PersonPhone> PersonPhones { get; set; } = null!;

    /// <summary>
    /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.PhoneNumberType"/>.
    /// </summary>
    /// <value>
    /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.PhoneNumberType"/>.
    /// </value>
    public virtual DbSet<Platy.AdventureWorks.Repository.Data.Entities.PhoneNumberType> PhoneNumberTypes { get; set; } = null!;

    /// <summary>
    /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductCategory"/>.
    /// </summary>
    /// <value>
    /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductCategory"/>.
    /// </value>
    public virtual DbSet<Platy.AdventureWorks.Repository.Data.Entities.ProductCategory> ProductCategories { get; set; } = null!;

    /// <summary>
    /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductCostHistory"/>.
    /// </summary>
    /// <value>
    /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductCostHistory"/>.
    /// </value>
    public virtual DbSet<Platy.AdventureWorks.Repository.Data.Entities.ProductCostHistory> ProductCostHistories { get; set; } = null!;

    /// <summary>
    /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductDescription"/>.
    /// </summary>
    /// <value>
    /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductDescription"/>.
    /// </value>
    public virtual DbSet<Platy.AdventureWorks.Repository.Data.Entities.ProductDescription> ProductDescriptions { get; set; } = null!;

    /// <summary>
    /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductDocument"/>.
    /// </summary>
    /// <value>
    /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductDocument"/>.
    /// </value>
    public virtual DbSet<Platy.AdventureWorks.Repository.Data.Entities.ProductDocument> ProductDocuments { get; set; } = null!;

    /// <summary>
    /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductInventory"/>.
    /// </summary>
    /// <value>
    /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductInventory"/>.
    /// </value>
    public virtual DbSet<Platy.AdventureWorks.Repository.Data.Entities.ProductInventory> ProductInventories { get; set; } = null!;

    /// <summary>
    /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductListPriceHistory"/>.
    /// </summary>
    /// <value>
    /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductListPriceHistory"/>.
    /// </value>
    public virtual DbSet<Platy.AdventureWorks.Repository.Data.Entities.ProductListPriceHistory> ProductListPriceHistories { get; set; } = null!;

    /// <summary>
    /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductModelIllustration"/>.
    /// </summary>
    /// <value>
    /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductModelIllustration"/>.
    /// </value>
    public virtual DbSet<Platy.AdventureWorks.Repository.Data.Entities.ProductModelIllustration> ProductModelIllustrations { get; set; } = null!;

    /// <summary>
    /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductModelProductDescriptionCulture"/>.
    /// </summary>
    /// <value>
    /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductModelProductDescriptionCulture"/>.
    /// </value>
    public virtual DbSet<Platy.AdventureWorks.Repository.Data.Entities.ProductModelProductDescriptionCulture> ProductModelProductDescriptionCultures { get; set; } = null!;

    /// <summary>
    /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductModel"/>.
    /// </summary>
    /// <value>
    /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductModel"/>.
    /// </value>
    public virtual DbSet<Platy.AdventureWorks.Repository.Data.Entities.ProductModel> ProductModels { get; set; } = null!;

    /// <summary>
    /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductPhoto"/>.
    /// </summary>
    /// <value>
    /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductPhoto"/>.
    /// </value>
    public virtual DbSet<Platy.AdventureWorks.Repository.Data.Entities.ProductPhoto> ProductPhotos { get; set; } = null!;

    /// <summary>
    /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductProductPhoto"/>.
    /// </summary>
    /// <value>
    /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductProductPhoto"/>.
    /// </value>
    public virtual DbSet<Platy.AdventureWorks.Repository.Data.Entities.ProductProductPhoto> ProductProductPhotos { get; set; } = null!;

    /// <summary>
    /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductReview"/>.
    /// </summary>
    /// <value>
    /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductReview"/>.
    /// </value>
    public virtual DbSet<Platy.AdventureWorks.Repository.Data.Entities.ProductReview> ProductReviews { get; set; } = null!;

    /// <summary>
    /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.Product"/>.
    /// </summary>
    /// <value>
    /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.Product"/>.
    /// </value>
    public virtual DbSet<Platy.AdventureWorks.Repository.Data.Entities.Product> Products { get; set; } = null!;

    /// <summary>
    /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductSubcategory"/>.
    /// </summary>
    /// <value>
    /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductSubcategory"/>.
    /// </value>
    public virtual DbSet<Platy.AdventureWorks.Repository.Data.Entities.ProductSubcategory> ProductSubcategories { get; set; } = null!;

    /// <summary>
    /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductVendor"/>.
    /// </summary>
    /// <value>
    /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.ProductVendor"/>.
    /// </value>
    public virtual DbSet<Platy.AdventureWorks.Repository.Data.Entities.ProductVendor> ProductVendors { get; set; } = null!;

    /// <summary>
    /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.PurchaseOrderDetail"/>.
    /// </summary>
    /// <value>
    /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.PurchaseOrderDetail"/>.
    /// </value>
    public virtual DbSet<Platy.AdventureWorks.Repository.Data.Entities.PurchaseOrderDetail> PurchaseOrderDetails { get; set; } = null!;

    /// <summary>
    /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.PurchaseOrderHeader"/>.
    /// </summary>
    /// <value>
    /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.PurchaseOrderHeader"/>.
    /// </value>
    public virtual DbSet<Platy.AdventureWorks.Repository.Data.Entities.PurchaseOrderHeader> PurchaseOrderHeaders { get; set; } = null!;

    /// <summary>
    /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesOrderDetail"/>.
    /// </summary>
    /// <value>
    /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesOrderDetail"/>.
    /// </value>
    public virtual DbSet<Platy.AdventureWorks.Repository.Data.Entities.SalesOrderDetail> SalesOrderDetails { get; set; } = null!;

    /// <summary>
    /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesOrderHeader"/>.
    /// </summary>
    /// <value>
    /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesOrderHeader"/>.
    /// </value>
    public virtual DbSet<Platy.AdventureWorks.Repository.Data.Entities.SalesOrderHeader> SalesOrderHeaders { get; set; } = null!;

    /// <summary>
    /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesOrderHeaderSalesReason"/>.
    /// </summary>
    /// <value>
    /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesOrderHeaderSalesReason"/>.
    /// </value>
    public virtual DbSet<Platy.AdventureWorks.Repository.Data.Entities.SalesOrderHeaderSalesReason> SalesOrderHeaderSalesReasons { get; set; } = null!;

    /// <summary>
    /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesPerson"/>.
    /// </summary>
    /// <value>
    /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesPerson"/>.
    /// </value>
    public virtual DbSet<Platy.AdventureWorks.Repository.Data.Entities.SalesPerson> SalesPeople { get; set; } = null!;

    /// <summary>
    /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesPersonQuotaHistory"/>.
    /// </summary>
    /// <value>
    /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesPersonQuotaHistory"/>.
    /// </value>
    public virtual DbSet<Platy.AdventureWorks.Repository.Data.Entities.SalesPersonQuotaHistory> SalesPersonQuotaHistories { get; set; } = null!;

    /// <summary>
    /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesReason"/>.
    /// </summary>
    /// <value>
    /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesReason"/>.
    /// </value>
    public virtual DbSet<Platy.AdventureWorks.Repository.Data.Entities.SalesReason> SalesReasons { get; set; } = null!;

    /// <summary>
    /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesTaxRate"/>.
    /// </summary>
    /// <value>
    /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesTaxRate"/>.
    /// </value>
    public virtual DbSet<Platy.AdventureWorks.Repository.Data.Entities.SalesTaxRate> SalesTaxRates { get; set; } = null!;

    /// <summary>
    /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesTerritory"/>.
    /// </summary>
    /// <value>
    /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesTerritory"/>.
    /// </value>
    public virtual DbSet<Platy.AdventureWorks.Repository.Data.Entities.SalesTerritory> SalesTerritories { get; set; } = null!;

    /// <summary>
    /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesTerritoryHistory"/>.
    /// </summary>
    /// <value>
    /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesTerritoryHistory"/>.
    /// </value>
    public virtual DbSet<Platy.AdventureWorks.Repository.Data.Entities.SalesTerritoryHistory> SalesTerritoryHistories { get; set; } = null!;

    /// <summary>
    /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.ScrapReason"/>.
    /// </summary>
    /// <value>
    /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.ScrapReason"/>.
    /// </value>
    public virtual DbSet<Platy.AdventureWorks.Repository.Data.Entities.ScrapReason> ScrapReasons { get; set; } = null!;

    /// <summary>
    /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.Shift"/>.
    /// </summary>
    /// <value>
    /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.Shift"/>.
    /// </value>
    public virtual DbSet<Platy.AdventureWorks.Repository.Data.Entities.Shift> Shifts { get; set; } = null!;

    /// <summary>
    /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.ShipMethod"/>.
    /// </summary>
    /// <value>
    /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.ShipMethod"/>.
    /// </value>
    public virtual DbSet<Platy.AdventureWorks.Repository.Data.Entities.ShipMethod> ShipMethods { get; set; } = null!;

    /// <summary>
    /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.ShoppingCartItem"/>.
    /// </summary>
    /// <value>
    /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.ShoppingCartItem"/>.
    /// </value>
    public virtual DbSet<Platy.AdventureWorks.Repository.Data.Entities.ShoppingCartItem> ShoppingCartItems { get; set; } = null!;

    /// <summary>
    /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.SpecialOfferProduct"/>.
    /// </summary>
    /// <value>
    /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.SpecialOfferProduct"/>.
    /// </value>
    public virtual DbSet<Platy.AdventureWorks.Repository.Data.Entities.SpecialOfferProduct> SpecialOfferProducts { get; set; } = null!;

    /// <summary>
    /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.SpecialOffer"/>.
    /// </summary>
    /// <value>
    /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.SpecialOffer"/>.
    /// </value>
    public virtual DbSet<Platy.AdventureWorks.Repository.Data.Entities.SpecialOffer> SpecialOffers { get; set; } = null!;

    /// <summary>
    /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.StateProvince"/>.
    /// </summary>
    /// <value>
    /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.StateProvince"/>.
    /// </value>
    public virtual DbSet<Platy.AdventureWorks.Repository.Data.Entities.StateProvince> StateProvinces { get; set; } = null!;

    /// <summary>
    /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.Store"/>.
    /// </summary>
    /// <value>
    /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.Store"/>.
    /// </value>
    public virtual DbSet<Platy.AdventureWorks.Repository.Data.Entities.Store> Stores { get; set; } = null!;

    /// <summary>
    /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.TransactionHistory"/>.
    /// </summary>
    /// <value>
    /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.TransactionHistory"/>.
    /// </value>
    public virtual DbSet<Platy.AdventureWorks.Repository.Data.Entities.TransactionHistory> TransactionHistories { get; set; } = null!;

    /// <summary>
    /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.TransactionHistoryArchive"/>.
    /// </summary>
    /// <value>
    /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.TransactionHistoryArchive"/>.
    /// </value>
    public virtual DbSet<Platy.AdventureWorks.Repository.Data.Entities.TransactionHistoryArchive> TransactionHistoryArchives { get; set; } = null!;

    /// <summary>
    /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.UnitMeasure"/>.
    /// </summary>
    /// <value>
    /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.UnitMeasure"/>.
    /// </value>
    public virtual DbSet<Platy.AdventureWorks.Repository.Data.Entities.UnitMeasure> UnitMeasures { get; set; } = null!;

    /// <summary>
    /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.VAdditionalContactInfo"/>.
    /// </summary>
    /// <value>
    /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.VAdditionalContactInfo"/>.
    /// </value>
    public virtual DbSet<Platy.AdventureWorks.Repository.Data.Entities.VAdditionalContactInfo> VAdditionalContactInfos { get; set; } = null!;

    /// <summary>
    /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.VEmployeeDepartmentHistory"/>.
    /// </summary>
    /// <value>
    /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.VEmployeeDepartmentHistory"/>.
    /// </value>
    public virtual DbSet<Platy.AdventureWorks.Repository.Data.Entities.VEmployeeDepartmentHistory> VEmployeeDepartmentHistories { get; set; } = null!;

    /// <summary>
    /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.VEmployeeDepartment"/>.
    /// </summary>
    /// <value>
    /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.VEmployeeDepartment"/>.
    /// </value>
    public virtual DbSet<Platy.AdventureWorks.Repository.Data.Entities.VEmployeeDepartment> VEmployeeDepartments { get; set; } = null!;

    /// <summary>
    /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.VEmployee"/>.
    /// </summary>
    /// <value>
    /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.VEmployee"/>.
    /// </value>
    public virtual DbSet<Platy.AdventureWorks.Repository.Data.Entities.VEmployee> VEmployees { get; set; } = null!;

    /// <summary>
    /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.Vendor"/>.
    /// </summary>
    /// <value>
    /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.Vendor"/>.
    /// </value>
    public virtual DbSet<Platy.AdventureWorks.Repository.Data.Entities.Vendor> Vendors { get; set; } = null!;

    /// <summary>
    /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.VIndividualCustomer"/>.
    /// </summary>
    /// <value>
    /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.VIndividualCustomer"/>.
    /// </value>
    public virtual DbSet<Platy.AdventureWorks.Repository.Data.Entities.VIndividualCustomer> VIndividualCustomers { get; set; } = null!;

    /// <summary>
    /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.VJobCandidateEducation"/>.
    /// </summary>
    /// <value>
    /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.VJobCandidateEducation"/>.
    /// </value>
    public virtual DbSet<Platy.AdventureWorks.Repository.Data.Entities.VJobCandidateEducation> VJobCandidateEducations { get; set; } = null!;

    /// <summary>
    /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.VJobCandidateEmployment"/>.
    /// </summary>
    /// <value>
    /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.VJobCandidateEmployment"/>.
    /// </value>
    public virtual DbSet<Platy.AdventureWorks.Repository.Data.Entities.VJobCandidateEmployment> VJobCandidateEmployments { get; set; } = null!;

    /// <summary>
    /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.VJobCandidate"/>.
    /// </summary>
    /// <value>
    /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.VJobCandidate"/>.
    /// </value>
    public virtual DbSet<Platy.AdventureWorks.Repository.Data.Entities.VJobCandidate> VJobCandidates { get; set; } = null!;

    /// <summary>
    /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.VPersonDemographics"/>.
    /// </summary>
    /// <value>
    /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.VPersonDemographics"/>.
    /// </value>
    public virtual DbSet<Platy.AdventureWorks.Repository.Data.Entities.VPersonDemographics> VPersonDemographics { get; set; } = null!;

    /// <summary>
    /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.VProductAndDescription"/>.
    /// </summary>
    /// <value>
    /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.VProductAndDescription"/>.
    /// </value>
    public virtual DbSet<Platy.AdventureWorks.Repository.Data.Entities.VProductAndDescription> VProductAndDescriptions { get; set; } = null!;

    /// <summary>
    /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.VProductModelCatalogDescription"/>.
    /// </summary>
    /// <value>
    /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.VProductModelCatalogDescription"/>.
    /// </value>
    public virtual DbSet<Platy.AdventureWorks.Repository.Data.Entities.VProductModelCatalogDescription> VProductModelCatalogDescriptions { get; set; } = null!;

    /// <summary>
    /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.VProductModelInstructions"/>.
    /// </summary>
    /// <value>
    /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.VProductModelInstructions"/>.
    /// </value>
    public virtual DbSet<Platy.AdventureWorks.Repository.Data.Entities.VProductModelInstructions> VProductModelInstructions { get; set; } = null!;

    /// <summary>
    /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.VSalesPerson"/>.
    /// </summary>
    /// <value>
    /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.VSalesPerson"/>.
    /// </value>
    public virtual DbSet<Platy.AdventureWorks.Repository.Data.Entities.VSalesPerson> VSalesPeople { get; set; } = null!;

    /// <summary>
    /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.VSalesPersonSalesByFiscalYears"/>.
    /// </summary>
    /// <value>
    /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.VSalesPersonSalesByFiscalYears"/>.
    /// </value>
    public virtual DbSet<Platy.AdventureWorks.Repository.Data.Entities.VSalesPersonSalesByFiscalYears> VSalesPersonSalesByFiscalYears { get; set; } = null!;

    /// <summary>
    /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.VStateProvinceCountryRegion"/>.
    /// </summary>
    /// <value>
    /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.VStateProvinceCountryRegion"/>.
    /// </value>
    public virtual DbSet<Platy.AdventureWorks.Repository.Data.Entities.VStateProvinceCountryRegion> VStateProvinceCountryRegions { get; set; } = null!;

    /// <summary>
    /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.VStoreWithAddresses"/>.
    /// </summary>
    /// <value>
    /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.VStoreWithAddresses"/>.
    /// </value>
    public virtual DbSet<Platy.AdventureWorks.Repository.Data.Entities.VStoreWithAddresses> VStoreWithAddresses { get; set; } = null!;

    /// <summary>
    /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.VStoreWithContacts"/>.
    /// </summary>
    /// <value>
    /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.VStoreWithContacts"/>.
    /// </value>
    public virtual DbSet<Platy.AdventureWorks.Repository.Data.Entities.VStoreWithContacts> VStoreWithContacts { get; set; } = null!;

    /// <summary>
    /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.VStoreWithDemographics"/>.
    /// </summary>
    /// <value>
    /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.VStoreWithDemographics"/>.
    /// </value>
    public virtual DbSet<Platy.AdventureWorks.Repository.Data.Entities.VStoreWithDemographics> VStoreWithDemographics { get; set; } = null!;

    /// <summary>
    /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.VVendorWithAddresses"/>.
    /// </summary>
    /// <value>
    /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.VVendorWithAddresses"/>.
    /// </value>
    public virtual DbSet<Platy.AdventureWorks.Repository.Data.Entities.VVendorWithAddresses> VVendorWithAddresses { get; set; } = null!;

    /// <summary>
    /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.VVendorWithContacts"/>.
    /// </summary>
    /// <value>
    /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.VVendorWithContacts"/>.
    /// </value>
    public virtual DbSet<Platy.AdventureWorks.Repository.Data.Entities.VVendorWithContacts> VVendorWithContacts { get; set; } = null!;

    /// <summary>
    /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.WorkOrderRouting"/>.
    /// </summary>
    /// <value>
    /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.WorkOrderRouting"/>.
    /// </value>
    public virtual DbSet<Platy.AdventureWorks.Repository.Data.Entities.WorkOrderRouting> WorkOrderRoutings { get; set; } = null!;

    /// <summary>
    /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.WorkOrder"/>.
    /// </summary>
    /// <value>
    /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Platy.AdventureWorks.Repository.Data.Entities.WorkOrder"/>.
    /// </value>
    public virtual DbSet<Platy.AdventureWorks.Repository.Data.Entities.WorkOrder> WorkOrders { get; set; } = null!;

    #endregion

    /// <summary>
    /// Configure the model that was discovered from the entity types exposed in <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> properties on this context.
    /// </summary>
    /// <param name="modelBuilder">The builder being used to construct the model for this context.</param>
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        #region Generated Configuration
        modelBuilder.ApplyConfiguration(new Platy.AdventureWorks.Repository.Data.EntityConfiguration.AddressConfiguration());
        modelBuilder.ApplyConfiguration(new Platy.AdventureWorks.Repository.Data.EntityConfiguration.AddressTypeConfiguration());
        modelBuilder.ApplyConfiguration(new Platy.AdventureWorks.Repository.Data.EntityConfiguration.BillOfMaterialsConfiguration());
        modelBuilder.ApplyConfiguration(new Platy.AdventureWorks.Repository.Data.EntityConfiguration.BusinessEntityAddressConfiguration());
        modelBuilder.ApplyConfiguration(new Platy.AdventureWorks.Repository.Data.EntityConfiguration.BusinessEntityConfiguration());
        modelBuilder.ApplyConfiguration(new Platy.AdventureWorks.Repository.Data.EntityConfiguration.BusinessEntityContactConfiguration());
        modelBuilder.ApplyConfiguration(new Platy.AdventureWorks.Repository.Data.EntityConfiguration.ContactTypeConfiguration());
        modelBuilder.ApplyConfiguration(new Platy.AdventureWorks.Repository.Data.EntityConfiguration.CountryRegionConfiguration());
        modelBuilder.ApplyConfiguration(new Platy.AdventureWorks.Repository.Data.EntityConfiguration.CountryRegionCurrencyConfiguration());
        modelBuilder.ApplyConfiguration(new Platy.AdventureWorks.Repository.Data.EntityConfiguration.CreditCardConfiguration());
        modelBuilder.ApplyConfiguration(new Platy.AdventureWorks.Repository.Data.EntityConfiguration.CultureConfiguration());
        modelBuilder.ApplyConfiguration(new Platy.AdventureWorks.Repository.Data.EntityConfiguration.CurrencyConfiguration());
        modelBuilder.ApplyConfiguration(new Platy.AdventureWorks.Repository.Data.EntityConfiguration.CurrencyRateConfiguration());
        modelBuilder.ApplyConfiguration(new Platy.AdventureWorks.Repository.Data.EntityConfiguration.CustomerConfiguration());
        modelBuilder.ApplyConfiguration(new Platy.AdventureWorks.Repository.Data.EntityConfiguration.DepartmentConfiguration());
        modelBuilder.ApplyConfiguration(new Platy.AdventureWorks.Repository.Data.EntityConfiguration.EmailAddressConfiguration());
        modelBuilder.ApplyConfiguration(new Platy.AdventureWorks.Repository.Data.EntityConfiguration.EmployeeConfiguration());
        modelBuilder.ApplyConfiguration(new Platy.AdventureWorks.Repository.Data.EntityConfiguration.EmployeeDepartmentHistoryConfiguration());
        modelBuilder.ApplyConfiguration(new Platy.AdventureWorks.Repository.Data.EntityConfiguration.EmployeePayHistoryConfiguration());
        modelBuilder.ApplyConfiguration(new Platy.AdventureWorks.Repository.Data.EntityConfiguration.IllustrationConfiguration());
        modelBuilder.ApplyConfiguration(new Platy.AdventureWorks.Repository.Data.EntityConfiguration.JobCandidateConfiguration());
        modelBuilder.ApplyConfiguration(new Platy.AdventureWorks.Repository.Data.EntityConfiguration.LocationConfiguration());
        modelBuilder.ApplyConfiguration(new Platy.AdventureWorks.Repository.Data.EntityConfiguration.PasswordConfiguration());
        modelBuilder.ApplyConfiguration(new Platy.AdventureWorks.Repository.Data.EntityConfiguration.PersonConfiguration());
        modelBuilder.ApplyConfiguration(new Platy.AdventureWorks.Repository.Data.EntityConfiguration.PersonCreditCardConfiguration());
        modelBuilder.ApplyConfiguration(new Platy.AdventureWorks.Repository.Data.EntityConfiguration.PersonPhoneConfiguration());
        modelBuilder.ApplyConfiguration(new Platy.AdventureWorks.Repository.Data.EntityConfiguration.PhoneNumberTypeConfiguration());
        modelBuilder.ApplyConfiguration(new Platy.AdventureWorks.Repository.Data.EntityConfiguration.ProductCategoryConfiguration());
        modelBuilder.ApplyConfiguration(new Platy.AdventureWorks.Repository.Data.EntityConfiguration.ProductConfiguration());
        modelBuilder.ApplyConfiguration(new Platy.AdventureWorks.Repository.Data.EntityConfiguration.ProductCostHistoryConfiguration());
        modelBuilder.ApplyConfiguration(new Platy.AdventureWorks.Repository.Data.EntityConfiguration.ProductDescriptionConfiguration());
        modelBuilder.ApplyConfiguration(new Platy.AdventureWorks.Repository.Data.EntityConfiguration.ProductDocumentConfiguration());
        modelBuilder.ApplyConfiguration(new Platy.AdventureWorks.Repository.Data.EntityConfiguration.ProductInventoryConfiguration());
        modelBuilder.ApplyConfiguration(new Platy.AdventureWorks.Repository.Data.EntityConfiguration.ProductListPriceHistoryConfiguration());
        modelBuilder.ApplyConfiguration(new Platy.AdventureWorks.Repository.Data.EntityConfiguration.ProductModelConfiguration());
        modelBuilder.ApplyConfiguration(new Platy.AdventureWorks.Repository.Data.EntityConfiguration.ProductModelIllustrationConfiguration());
        modelBuilder.ApplyConfiguration(new Platy.AdventureWorks.Repository.Data.EntityConfiguration.ProductModelProductDescriptionCultureConfiguration());
        modelBuilder.ApplyConfiguration(new Platy.AdventureWorks.Repository.Data.EntityConfiguration.ProductPhotoConfiguration());
        modelBuilder.ApplyConfiguration(new Platy.AdventureWorks.Repository.Data.EntityConfiguration.ProductProductPhotoConfiguration());
        modelBuilder.ApplyConfiguration(new Platy.AdventureWorks.Repository.Data.EntityConfiguration.ProductReviewConfiguration());
        modelBuilder.ApplyConfiguration(new Platy.AdventureWorks.Repository.Data.EntityConfiguration.ProductSubcategoryConfiguration());
        modelBuilder.ApplyConfiguration(new Platy.AdventureWorks.Repository.Data.EntityConfiguration.ProductVendorConfiguration());
        modelBuilder.ApplyConfiguration(new Platy.AdventureWorks.Repository.Data.EntityConfiguration.PurchaseOrderDetailConfiguration());
        modelBuilder.ApplyConfiguration(new Platy.AdventureWorks.Repository.Data.EntityConfiguration.PurchaseOrderHeaderConfiguration());
        modelBuilder.ApplyConfiguration(new Platy.AdventureWorks.Repository.Data.EntityConfiguration.SalesOrderDetailConfiguration());
        modelBuilder.ApplyConfiguration(new Platy.AdventureWorks.Repository.Data.EntityConfiguration.SalesOrderHeaderConfiguration());
        modelBuilder.ApplyConfiguration(new Platy.AdventureWorks.Repository.Data.EntityConfiguration.SalesOrderHeaderSalesReasonConfiguration());
        modelBuilder.ApplyConfiguration(new Platy.AdventureWorks.Repository.Data.EntityConfiguration.SalesPersonConfiguration());
        modelBuilder.ApplyConfiguration(new Platy.AdventureWorks.Repository.Data.EntityConfiguration.SalesPersonQuotaHistoryConfiguration());
        modelBuilder.ApplyConfiguration(new Platy.AdventureWorks.Repository.Data.EntityConfiguration.SalesReasonConfiguration());
        modelBuilder.ApplyConfiguration(new Platy.AdventureWorks.Repository.Data.EntityConfiguration.SalesTaxRateConfiguration());
        modelBuilder.ApplyConfiguration(new Platy.AdventureWorks.Repository.Data.EntityConfiguration.SalesTerritoryConfiguration());
        modelBuilder.ApplyConfiguration(new Platy.AdventureWorks.Repository.Data.EntityConfiguration.SalesTerritoryHistoryConfiguration());
        modelBuilder.ApplyConfiguration(new Platy.AdventureWorks.Repository.Data.EntityConfiguration.ScrapReasonConfiguration());
        modelBuilder.ApplyConfiguration(new Platy.AdventureWorks.Repository.Data.EntityConfiguration.ShiftConfiguration());
        modelBuilder.ApplyConfiguration(new Platy.AdventureWorks.Repository.Data.EntityConfiguration.ShipMethodConfiguration());
        modelBuilder.ApplyConfiguration(new Platy.AdventureWorks.Repository.Data.EntityConfiguration.ShoppingCartItemConfiguration());
        modelBuilder.ApplyConfiguration(new Platy.AdventureWorks.Repository.Data.EntityConfiguration.SpecialOfferConfiguration());
        modelBuilder.ApplyConfiguration(new Platy.AdventureWorks.Repository.Data.EntityConfiguration.SpecialOfferProductConfiguration());
        modelBuilder.ApplyConfiguration(new Platy.AdventureWorks.Repository.Data.EntityConfiguration.StateProvinceConfiguration());
        modelBuilder.ApplyConfiguration(new Platy.AdventureWorks.Repository.Data.EntityConfiguration.StoreConfiguration());
        modelBuilder.ApplyConfiguration(new Platy.AdventureWorks.Repository.Data.EntityConfiguration.TransactionHistoryArchiveConfiguration());
        modelBuilder.ApplyConfiguration(new Platy.AdventureWorks.Repository.Data.EntityConfiguration.TransactionHistoryConfiguration());
        modelBuilder.ApplyConfiguration(new Platy.AdventureWorks.Repository.Data.EntityConfiguration.UnitMeasureConfiguration());
        modelBuilder.ApplyConfiguration(new Platy.AdventureWorks.Repository.Data.EntityConfiguration.VAdditionalContactInfoConfiguration());
        modelBuilder.ApplyConfiguration(new Platy.AdventureWorks.Repository.Data.EntityConfiguration.VEmployeeConfiguration());
        modelBuilder.ApplyConfiguration(new Platy.AdventureWorks.Repository.Data.EntityConfiguration.VEmployeeDepartmentConfiguration());
        modelBuilder.ApplyConfiguration(new Platy.AdventureWorks.Repository.Data.EntityConfiguration.VEmployeeDepartmentHistoryConfiguration());
        modelBuilder.ApplyConfiguration(new Platy.AdventureWorks.Repository.Data.EntityConfiguration.VendorConfiguration());
        modelBuilder.ApplyConfiguration(new Platy.AdventureWorks.Repository.Data.EntityConfiguration.VIndividualCustomerConfiguration());
        modelBuilder.ApplyConfiguration(new Platy.AdventureWorks.Repository.Data.EntityConfiguration.VJobCandidateConfiguration());
        modelBuilder.ApplyConfiguration(new Platy.AdventureWorks.Repository.Data.EntityConfiguration.VJobCandidateEducationConfiguration());
        modelBuilder.ApplyConfiguration(new Platy.AdventureWorks.Repository.Data.EntityConfiguration.VJobCandidateEmploymentConfiguration());
        modelBuilder.ApplyConfiguration(new Platy.AdventureWorks.Repository.Data.EntityConfiguration.VPersonDemographicsConfiguration());
        modelBuilder.ApplyConfiguration(new Platy.AdventureWorks.Repository.Data.EntityConfiguration.VProductAndDescriptionConfiguration());
        modelBuilder.ApplyConfiguration(new Platy.AdventureWorks.Repository.Data.EntityConfiguration.VProductModelCatalogDescriptionConfiguration());
        modelBuilder.ApplyConfiguration(new Platy.AdventureWorks.Repository.Data.EntityConfiguration.VProductModelInstructionsConfiguration());
        modelBuilder.ApplyConfiguration(new Platy.AdventureWorks.Repository.Data.EntityConfiguration.VSalesPersonConfiguration());
        modelBuilder.ApplyConfiguration(new Platy.AdventureWorks.Repository.Data.EntityConfiguration.VSalesPersonSalesByFiscalYearsConfiguration());
        modelBuilder.ApplyConfiguration(new Platy.AdventureWorks.Repository.Data.EntityConfiguration.VStateProvinceCountryRegionConfiguration());
        modelBuilder.ApplyConfiguration(new Platy.AdventureWorks.Repository.Data.EntityConfiguration.VStoreWithAddressesConfiguration());
        modelBuilder.ApplyConfiguration(new Platy.AdventureWorks.Repository.Data.EntityConfiguration.VStoreWithContactsConfiguration());
        modelBuilder.ApplyConfiguration(new Platy.AdventureWorks.Repository.Data.EntityConfiguration.VStoreWithDemographicsConfiguration());
        modelBuilder.ApplyConfiguration(new Platy.AdventureWorks.Repository.Data.EntityConfiguration.VVendorWithAddressesConfiguration());
        modelBuilder.ApplyConfiguration(new Platy.AdventureWorks.Repository.Data.EntityConfiguration.VVendorWithContactsConfiguration());
        modelBuilder.ApplyConfiguration(new Platy.AdventureWorks.Repository.Data.EntityConfiguration.WorkOrderConfiguration());
        modelBuilder.ApplyConfiguration(new Platy.AdventureWorks.Repository.Data.EntityConfiguration.WorkOrderRoutingConfiguration());
        #endregion
    }
}
