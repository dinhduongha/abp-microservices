using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class AccountAccount
{
    public Guid Id { get; set; }

    public Guid? MessageMainAttachmentId { get; set; }

    public long? CurrencyId { get; set; }

    public Guid? CompanyId { get; set; }

    public Guid? GroupId { get; set; }

    public Guid? RootId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? Name { get; set; }

    public string? Code { get; set; }

    public string? AccountType { get; set; }

    public string? InternalGroup { get; set; }

    public string? Note { get; set; }

    public bool? Deprecated { get; set; }

    public bool? IncludeInitialBalance { get; set; }

    public bool? Reconcile { get; set; }

    public bool? IsOffBalance { get; set; }

    public bool? NonTrade { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ICollection<AccountAccountAccountTag> AccountAccountAccountTags { get; } = new List<AccountAccountAccountTag>();

    public virtual ICollection<AccountAccruedOrdersWizard> AccountAccruedOrdersWizards { get; } = new List<AccountAccruedOrdersWizard>();

    public virtual ICollection<AccountAnalyticLine> AccountAnalyticLines { get; } = new List<AccountAnalyticLine>();

    public virtual ICollection<AccountAssetCategory> AccountAssetCategoryAccountAssets { get; } = new List<AccountAssetCategory>();

    public virtual ICollection<AccountAssetCategory> AccountAssetCategoryAccountDepreciationExpenses { get; } = new List<AccountAssetCategory>();

    public virtual ICollection<AccountAssetCategory> AccountAssetCategoryAccountDepreciations { get; } = new List<AccountAssetCategory>();

    public virtual ICollection<AccountAutomaticEntryWizard> AccountAutomaticEntryWizards { get; } = new List<AccountAutomaticEntryWizard>();

    public virtual ICollection<AccountFiscalPositionAccount> AccountFiscalPositionAccountAccountDests { get; } = new List<AccountFiscalPositionAccount>();

    public virtual ICollection<AccountFiscalPositionAccount> AccountFiscalPositionAccountAccountSrcs { get; } = new List<AccountFiscalPositionAccount>();

    public virtual ICollection<AccountJournal> AccountJournalDefaultAccounts { get; } = new List<AccountJournal>();

    public virtual ICollection<AccountJournal> AccountJournalLossAccounts { get; } = new List<AccountJournal>();

    public virtual ICollection<AccountJournal> AccountJournalProfitAccounts { get; } = new List<AccountJournal>();

    public virtual ICollection<AccountJournal> AccountJournalSuspenseAccounts { get; } = new List<AccountJournal>();

    public virtual ICollection<AccountMoveLine> AccountMoveLines { get; } = new List<AccountMoveLine>();

    public virtual ICollection<AccountPayment> AccountPaymentDestinationAccounts { get; } = new List<AccountPayment>();

    public virtual ICollection<AccountPayment> AccountPaymentForceOutstandingAccounts { get; } = new List<AccountPayment>();

    public virtual ICollection<AccountPaymentMethodLine> AccountPaymentMethodLines { get; } = new List<AccountPaymentMethodLine>();

    public virtual ICollection<AccountPayment> AccountPaymentOutstandingAccounts { get; } = new List<AccountPayment>();

    public virtual ICollection<AccountPaymentRegister> AccountPaymentRegisters { get; } = new List<AccountPaymentRegister>();

    public virtual ICollection<AccountReconcileModelLine> AccountReconcileModelLines { get; } = new List<AccountReconcileModelLine>();

    public virtual ICollection<AccountTaxRepartitionLine> AccountTaxRepartitionLines { get; } = new List<AccountTaxRepartitionLine>();

    public virtual ICollection<AccountTax> AccountTaxes { get; } = new List<AccountTax>();

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual AccountGroup? Group { get; set; }

    public virtual ICollection<HrExpense> HrExpenses { get; } = new List<HrExpense>();

    public virtual IrAttachment? MessageMainAttachment { get; set; }

    public virtual ICollection<PosCloseSessionWizard> PosCloseSessionWizards { get; } = new List<PosCloseSessionWizard>();

    public virtual ICollection<PosPaymentMethod> PosPaymentMethodOutstandingAccounts { get; } = new List<PosPaymentMethod>();

    public virtual ICollection<PosPaymentMethod> PosPaymentMethodReceivableAccounts { get; } = new List<PosPaymentMethod>();

    public virtual ICollection<ResCompany> ResCompanyAccountCashBasisBaseAccounts { get; } = new List<ResCompany>();

    public virtual ICollection<ResCompany> ResCompanyAccountDefaultPosReceivableAccounts { get; } = new List<ResCompany>();

    public virtual ICollection<ResCompany> ResCompanyAccountJournalEarlyPayDiscountGainAccounts { get; } = new List<ResCompany>();

    public virtual ICollection<ResCompany> ResCompanyAccountJournalEarlyPayDiscountLossAccounts { get; } = new List<ResCompany>();

    public virtual ICollection<ResCompany> ResCompanyAccountJournalPaymentCreditAccounts { get; } = new List<ResCompany>();

    public virtual ICollection<ResCompany> ResCompanyAccountJournalPaymentDebitAccounts { get; } = new List<ResCompany>();

    public virtual ICollection<ResCompany> ResCompanyAccountJournalSuspenseAccounts { get; } = new List<ResCompany>();

    public virtual ICollection<ResCompany> ResCompanyDefaultCashDifferenceExpenseAccounts { get; } = new List<ResCompany>();

    public virtual ICollection<ResCompany> ResCompanyDefaultCashDifferenceIncomeAccounts { get; } = new List<ResCompany>();

    public virtual ICollection<ResCompany> ResCompanyExpenseAccrualAccounts { get; } = new List<ResCompany>();

    public virtual ICollection<ResCompany> ResCompanyExpenseCurrencyExchangeAccounts { get; } = new List<ResCompany>();

    public virtual ICollection<ResCompany> ResCompanyIncomeCurrencyExchangeAccounts { get; } = new List<ResCompany>();

    public virtual ICollection<ResCompany> ResCompanyPropertyStockAccountInputCategs { get; } = new List<ResCompany>();

    public virtual ICollection<ResCompany> ResCompanyPropertyStockAccountOutputCategs { get; } = new List<ResCompany>();

    public virtual ICollection<ResCompany> ResCompanyPropertyStockValuationAccounts { get; } = new List<ResCompany>();

    public virtual ICollection<ResCompany> ResCompanyRevenueAccrualAccounts { get; } = new List<ResCompany>();

    public virtual ICollection<ResCompany> ResCompanyTransferAccounts { get; } = new List<ResCompany>();

    public virtual ICollection<SaleAdvancePaymentInv> SaleAdvancePaymentInvs { get; } = new List<SaleAdvancePaymentInv>();

    public virtual ICollection<StockLocation> StockLocationValuationInAccounts { get; } = new List<StockLocation>();

    public virtual ICollection<StockLocation> StockLocationValuationOutAccounts { get; } = new List<StockLocation>();

    public virtual ICollection<StockValuationLayerRevaluation> StockValuationLayerRevaluations { get; } = new List<StockValuationLayerRevaluation>();

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<AccountBalanceReport> AccountBalanceReports { get; } = new List<AccountBalanceReport>();

    public virtual ICollection<AccountCommonAccountReport> AccountCommonAccountReports { get; } = new List<AccountCommonAccountReport>();

    public virtual ICollection<AccountJournal> AccountJournals { get; } = new List<AccountJournal>();

    public virtual ICollection<AccountReportGeneralLedger> AccountReportGeneralLedgers { get; } = new List<AccountReportGeneralLedger>();

    public virtual ICollection<AccountBudgetPost> Budgets { get; } = new List<AccountBudgetPost>();

    public virtual ICollection<AccountJournal> Journals { get; } = new List<AccountJournal>();

    public virtual ICollection<AccountBankbookReport> ReportLines { get; } = new List<AccountBankbookReport>();

    public virtual ICollection<AccountDaybookReport> ReportLines1 { get; } = new List<AccountDaybookReport>();

    public virtual ICollection<AccountFinancialReport> ReportLines2 { get; } = new List<AccountFinancialReport>();

    public virtual ICollection<AccountCashbookReport> ReportLinesNavigation { get; } = new List<AccountCashbookReport>();

    public virtual ICollection<AccountTax> Taxes { get; } = new List<AccountTax>();
}
