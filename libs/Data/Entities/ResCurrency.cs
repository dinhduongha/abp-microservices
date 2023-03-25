using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Auditing;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Bamboo.Core.Entities;

[Table("res_currency")]
[Index("Name", Name = "res_currency_unique_name", IsUnique = true)]
public partial class ResCurrency
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("symbol")]
    public string? Symbol { get; set; }

    [Column("decimal_places")]
    public long? DecimalPlaces { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("full_name")]
    public string? FullName { get; set; }

    [Column("position")]
    public string? Position { get; set; }

    [Column("currency_unit_label")]
    public string? CurrencyUnitLabel { get; set; }

    [Column("currency_subunit_label")]
    public string? CurrencySubunitLabel { get; set; }

    [Column("rounding")]
    public decimal? Rounding { get; set; }

    [Column("active")]
    public bool? Active { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [InverseProperty("Currency")]
    public virtual ICollection<AccountAccountTemplate> AccountAccountTemplates { get; } = new List<AccountAccountTemplate>();

    [InverseProperty("Currency")]
    public virtual ICollection<AccountAccount> AccountAccounts { get; } = new List<AccountAccount>();

    [InverseProperty("Currency")]
    public virtual ICollection<AccountAccruedOrdersWizard> AccountAccruedOrdersWizards { get; } = new List<AccountAccruedOrdersWizard>();

    [InverseProperty("Currency")]
    public virtual ICollection<AccountAnalyticLine> AccountAnalyticLines { get; } = new List<AccountAnalyticLine>();

    [InverseProperty("Currency")]
    public virtual ICollection<AccountAssetAsset> AccountAssetAssets { get; } = new List<AccountAssetAsset>();

    [InverseProperty("Currency")]
    public virtual ICollection<AccountBankStatementLine> AccountBankStatementLineCurrencies { get; } = new List<AccountBankStatementLine>();

    [InverseProperty("ForeignCurrency")]
    public virtual ICollection<AccountBankStatementLine> AccountBankStatementLineForeignCurrencies { get; } = new List<AccountBankStatementLine>();

    [InverseProperty("Currency")]
    public virtual ICollection<AccountChartTemplate> AccountChartTemplates { get; } = new List<AccountChartTemplate>();

    [InverseProperty("Currency")]
    public virtual ICollection<AccountJournal> AccountJournals { get; } = new List<AccountJournal>();

    [InverseProperty("CompanyCurrency")]
    public virtual ICollection<AccountMoveLine> AccountMoveLineCompanyCurrencies { get; } = new List<AccountMoveLine>();

    [InverseProperty("Currency")]
    public virtual ICollection<AccountMoveLine> AccountMoveLineCurrencies { get; } = new List<AccountMoveLine>();

    [InverseProperty("Currency")]
    public virtual ICollection<AccountMove> AccountMoves { get; } = new List<AccountMove>();

    [InverseProperty("CreditCurrency")]
    public virtual ICollection<AccountPartialReconcile> AccountPartialReconcileCreditCurrencies { get; } = new List<AccountPartialReconcile>();

    [InverseProperty("DebitCurrency")]
    public virtual ICollection<AccountPartialReconcile> AccountPartialReconcileDebitCurrencies { get; } = new List<AccountPartialReconcile>();

    [InverseProperty("Currency")]
    public virtual ICollection<AccountPaymentRegister> AccountPaymentRegisterCurrencies { get; } = new List<AccountPaymentRegister>();

    [InverseProperty("SourceCurrency")]
    public virtual ICollection<AccountPaymentRegister> AccountPaymentRegisterSourceCurrencies { get; } = new List<AccountPaymentRegister>();

    [InverseProperty("Currency")]
    public virtual ICollection<AccountPayment> AccountPayments { get; } = new List<AccountPayment>();

    [InverseProperty("Currency")]
    public virtual ICollection<BaseImportTestsModelsComplex> BaseImportTestsModelsComplexes { get; } = new List<BaseImportTestsModelsComplex>();

    [InverseProperty("Currency")]
    public virtual ICollection<BaseImportTestsModelsFloat> BaseImportTestsModelsFloats { get; } = new List<BaseImportTestsModelsFloat>();

    [ForeignKey("CreatorId")]
    [InverseProperty("ResCurrencyCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [InverseProperty("Currency")]
    public virtual ICollection<HrExpenseSheet> HrExpenseSheets { get; } = new List<HrExpenseSheet>();

    [InverseProperty("Currency")]
    public virtual ICollection<HrExpenseSplit> HrExpenseSplits { get; } = new List<HrExpenseSplit>();

    [InverseProperty("Currency")]
    public virtual ICollection<HrExpense> HrExpenses { get; } = new List<HrExpense>();

    [InverseProperty("Currency")]
    public virtual ICollection<LunchCashmove> LunchCashmoves { get; } = new List<LunchCashmove>();

    [InverseProperty("Currency")]
    public virtual ICollection<LunchOrder> LunchOrders { get; } = new List<LunchOrder>();

    [InverseProperty("Currency")]
    public virtual ICollection<MailTrackingValue> MailTrackingValues { get; } = new List<MailTrackingValue>();

    [InverseProperty("Currency")]
    public virtual ICollection<PaymentLinkWizard> PaymentLinkWizards { get; } = new List<PaymentLinkWizard>();

    [InverseProperty("Currency")]
    public virtual ICollection<PaymentTransaction> PaymentTransactions { get; } = new List<PaymentTransaction>();

    [InverseProperty("Currency")]
    public virtual ICollection<ProductPricelistItem> ProductPricelistItems { get; } = new List<ProductPricelistItem>();

    [InverseProperty("Currency")]
    public virtual ICollection<ProductPricelist> ProductPricelists { get; } = new List<ProductPricelist>();

    [InverseProperty("Currency")]
    public virtual ICollection<ProductSupplierinfo> ProductSupplierinfos { get; } = new List<ProductSupplierinfo>();

    [InverseProperty("Currency")]
    public virtual ICollection<PurchaseOrderLine> PurchaseOrderLines { get; } = new List<PurchaseOrderLine>();

    [InverseProperty("Currency")]
    public virtual ICollection<PurchaseOrder> PurchaseOrders { get; } = new List<PurchaseOrder>();

    [InverseProperty("Currency")]
    public virtual ICollection<ResCompany> ResCompanies { get; } = new List<ResCompany>();

    [InverseProperty("Currency")]
    public virtual ICollection<ResCountry> ResCountries { get; } = new List<ResCountry>();

    [InverseProperty("Currency")]
    public virtual ICollection<ResCurrencyRate> ResCurrencyRates { get; } = new List<ResCurrencyRate>();

    [InverseProperty("Currency")]
    public virtual ICollection<ResPartnerBank> ResPartnerBanks { get; } = new List<ResPartnerBank>();

    [InverseProperty("Currency")]
    public virtual ICollection<SaleAdvancePaymentInv> SaleAdvancePaymentInvs { get; } = new List<SaleAdvancePaymentInv>();

    [InverseProperty("Currency")]
    public virtual ICollection<SaleOrderLine> SaleOrderLines { get; } = new List<SaleOrderLine>();

    [InverseProperty("Currency")]
    public virtual ICollection<SaleOrder> SaleOrders { get; } = new List<SaleOrder>();

    [ForeignKey("LastModifierId")]
    [InverseProperty("ResCurrencyWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
