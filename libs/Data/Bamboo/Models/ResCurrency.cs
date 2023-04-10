using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class ResCurrency
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public string? Symbol { get; set; }

    public long? DecimalPlaces { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? FullName { get; set; }

    public string? Position { get; set; }

    public string? CurrencyUnitLabel { get; set; }

    public string? CurrencySubunitLabel { get; set; }

    public decimal? Rounding { get; set; }

    public bool? Active { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    //public virtual ICollection<AccountAccountTemplate> AccountAccountTemplates { get; } = new List<AccountAccountTemplate>();

    //public virtual ICollection<AccountAccount> AccountAccounts { get; } = new List<AccountAccount>();

    //public virtual ICollection<AccountAccruedOrdersWizard> AccountAccruedOrdersWizards { get; } = new List<AccountAccruedOrdersWizard>();

    //public virtual ICollection<AccountAnalyticLine> AccountAnalyticLines { get; } = new List<AccountAnalyticLine>();

    //public virtual ICollection<AccountAssetAsset> AccountAssetAssets { get; } = new List<AccountAssetAsset>();

    //public virtual ICollection<AccountBankStatementLine> AccountBankStatementLineCurrencies { get; } = new List<AccountBankStatementLine>();

    //public virtual ICollection<AccountBankStatementLine> AccountBankStatementLineForeignCurrencies { get; } = new List<AccountBankStatementLine>();

    //public virtual ICollection<AccountChartTemplate> AccountChartTemplates { get; } = new List<AccountChartTemplate>();

    //public virtual ICollection<AccountJournal> AccountJournals { get; } = new List<AccountJournal>();

    //public virtual ICollection<AccountMoveLine> AccountMoveLineCompanyCurrencies { get; } = new List<AccountMoveLine>();

    //public virtual ICollection<AccountMoveLine> AccountMoveLineCurrencies { get; } = new List<AccountMoveLine>();

    //public virtual ICollection<AccountMove> AccountMoves { get; } = new List<AccountMove>();

    //public virtual ICollection<AccountPartialReconcile> AccountPartialReconcileCreditCurrencies { get; } = new List<AccountPartialReconcile>();

    //public virtual ICollection<AccountPartialReconcile> AccountPartialReconcileDebitCurrencies { get; } = new List<AccountPartialReconcile>();

    //public virtual ICollection<AccountPaymentRegister> AccountPaymentRegisterCurrencies { get; } = new List<AccountPaymentRegister>();

    //public virtual ICollection<AccountPaymentRegister> AccountPaymentRegisterSourceCurrencies { get; } = new List<AccountPaymentRegister>();

    //public virtual ICollection<AccountPayment> AccountPayments { get; } = new List<AccountPayment>();

    //public virtual ICollection<BaseImportTestsModelsComplex> BaseImportTestsModelsComplexes { get; } = new List<BaseImportTestsModelsComplex>();

    //public virtual ICollection<BaseImportTestsModelsFloat> BaseImportTestsModelsFloats { get; } = new List<BaseImportTestsModelsFloat>();

    public virtual ResUser? CreateU { get; set; }

    //public virtual ICollection<HrExpenseSheet> HrExpenseSheets { get; } = new List<HrExpenseSheet>();

    //public virtual ICollection<HrExpenseSplit> HrExpenseSplits { get; } = new List<HrExpenseSplit>();

    //public virtual ICollection<HrExpense> HrExpenses { get; } = new List<HrExpense>();

    //public virtual ICollection<LunchCashmove> LunchCashmoves { get; } = new List<LunchCashmove>();

    //public virtual ICollection<LunchOrder> LunchOrders { get; } = new List<LunchOrder>();

    //public virtual ICollection<MailTrackingValue> MailTrackingValues { get; } = new List<MailTrackingValue>();

    //public virtual ICollection<PaymentLinkWizard> PaymentLinkWizards { get; } = new List<PaymentLinkWizard>();

    //public virtual ICollection<PaymentTransaction> PaymentTransactions { get; } = new List<PaymentTransaction>();

    //public virtual ICollection<ProductPricelistItem> ProductPricelistItems { get; } = new List<ProductPricelistItem>();

    //public virtual ICollection<ProductPricelist> ProductPricelists { get; } = new List<ProductPricelist>();

    //public virtual ICollection<ProductSupplierinfo> ProductSupplierinfos { get; } = new List<ProductSupplierinfo>();

    //public virtual ICollection<PurchaseOrderLine> PurchaseOrderLines { get; } = new List<PurchaseOrderLine>();

    //public virtual ICollection<PurchaseOrder> PurchaseOrders { get; } = new List<PurchaseOrder>();

    //public virtual ICollection<ResCompany> ResCompanies { get; } = new List<ResCompany>();

    //public virtual ICollection<ResCountry> ResCountries { get; } = new List<ResCountry>();

    //public virtual ICollection<ResCurrencyRate> ResCurrencyRates { get; } = new List<ResCurrencyRate>();

    //public virtual ICollection<ResPartnerBank> ResPartnerBanks { get; } = new List<ResPartnerBank>();

    //public virtual ICollection<SaleAdvancePaymentInv> SaleAdvancePaymentInvs { get; } = new List<SaleAdvancePaymentInv>();

    //public virtual ICollection<SaleOrderLine> SaleOrderLines { get; } = new List<SaleOrderLine>();

    //public virtual ICollection<SaleOrder> SaleOrders { get; } = new List<SaleOrder>();

    public virtual ResUser? WriteU { get; set; }
}
