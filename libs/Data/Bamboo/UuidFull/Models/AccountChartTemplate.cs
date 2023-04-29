using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class AccountChartTemplate
{
    public Guid Id { get; set; }

    public Guid? ParentId { get; set; }

    public long? CodeDigits { get; set; }

    public long? CurrencyId { get; set; }

    public Guid? IncomeCurrencyExchangeAccountId { get; set; }

    public Guid? ExpenseCurrencyExchangeAccountId { get; set; }

    public long? CountryId { get; set; }

    public Guid? AccountJournalSuspenseAccountId { get; set; }

    public Guid? AccountJournalPaymentDebitAccountId { get; set; }

    public Guid? AccountJournalPaymentCreditAccountId { get; set; }

    public Guid? DefaultCashDifferenceIncomeAccountId { get; set; }

    public Guid? DefaultCashDifferenceExpenseAccountId { get; set; }

    public Guid? DefaultPosReceivableAccountId { get; set; }

    public Guid? AccountJournalEarlyPayDiscountLossAccountId { get; set; }

    public Guid? AccountJournalEarlyPayDiscountGainAccountId { get; set; }

    public Guid? PropertyAccountReceivableId { get; set; }

    public Guid? PropertyAccountPayableId { get; set; }

    public Guid? PropertyAccountExpenseCategId { get; set; }

    public Guid? PropertyAccountIncomeCategId { get; set; }

    public Guid? PropertyAccountExpenseId { get; set; }

    public Guid? PropertyAccountIncomeId { get; set; }

    public Guid? PropertyStockAccountInputCategId { get; set; }

    public Guid? PropertyStockAccountOutputCategId { get; set; }

    public Guid? PropertyStockValuationAccountId { get; set; }

    public Guid? PropertyTaxPayableAccountId { get; set; }

    public Guid? PropertyTaxReceivableAccountId { get; set; }

    public Guid? PropertyAdvanceTaxPaymentAccountId { get; set; }

    public Guid? PropertyCashBasisBaseAccountId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? Name { get; set; }

    public string? BankAccountCodePrefix { get; set; }

    public string? CashAccountCodePrefix { get; set; }

    public string? TransferAccountCodePrefix { get; set; }

    public bool? Visible { get; set; }

    public bool? UseAngloSaxon { get; set; }

    public bool? UseStornoAccounting { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public string? SpokenLanguages { get; set; }

    public virtual ICollection<AccountAccountTemplate> AccountAccountTemplates { get; } = new List<AccountAccountTemplate>();

    public virtual ICollection<AccountFiscalPositionTemplate> AccountFiscalPositionTemplates { get; } = new List<AccountFiscalPositionTemplate>();

    public virtual ICollection<AccountGroupTemplate> AccountGroupTemplates { get; } = new List<AccountGroupTemplate>();

    public virtual AccountAccountTemplate? AccountJournalEarlyPayDiscountGainAccount { get; set; }

    public virtual AccountAccountTemplate? AccountJournalEarlyPayDiscountLossAccount { get; set; }

    public virtual AccountAccountTemplate? AccountJournalPaymentCreditAccount { get; set; }

    public virtual AccountAccountTemplate? AccountJournalPaymentDebitAccount { get; set; }

    public virtual AccountAccountTemplate? AccountJournalSuspenseAccount { get; set; }

    public virtual ICollection<AccountReconcileModelTemplate> AccountReconcileModelTemplates { get; } = new List<AccountReconcileModelTemplate>();

    public virtual ICollection<AccountReport> AccountReports { get; } = new List<AccountReport>();

    public virtual ICollection<AccountTaxTemplate> AccountTaxTemplates { get; } = new List<AccountTaxTemplate>();

    public virtual ResUser? CreateU { get; set; }

    public virtual AccountAccountTemplate? DefaultCashDifferenceExpenseAccount { get; set; }

    public virtual AccountAccountTemplate? DefaultCashDifferenceIncomeAccount { get; set; }

    public virtual AccountAccountTemplate? DefaultPosReceivableAccount { get; set; }

    public virtual AccountAccountTemplate? ExpenseCurrencyExchangeAccount { get; set; }

    public virtual AccountAccountTemplate? IncomeCurrencyExchangeAccount { get; set; }

    public virtual ICollection<AccountChartTemplate> InverseParent { get; } = new List<AccountChartTemplate>();

    public virtual AccountChartTemplate? Parent { get; set; }

    public virtual AccountAccountTemplate? PropertyAccountExpense { get; set; }

    public virtual AccountAccountTemplate? PropertyAccountExpenseCateg { get; set; }

    public virtual AccountAccountTemplate? PropertyAccountIncome { get; set; }

    public virtual AccountAccountTemplate? PropertyAccountIncomeCateg { get; set; }

    public virtual AccountAccountTemplate? PropertyAccountPayable { get; set; }

    public virtual AccountAccountTemplate? PropertyAccountReceivable { get; set; }

    public virtual AccountAccountTemplate? PropertyAdvanceTaxPaymentAccount { get; set; }

    public virtual AccountAccountTemplate? PropertyCashBasisBaseAccount { get; set; }

    public virtual AccountAccountTemplate? PropertyStockAccountInputCateg { get; set; }

    public virtual AccountAccountTemplate? PropertyStockAccountOutputCateg { get; set; }

    public virtual AccountAccountTemplate? PropertyStockValuationAccount { get; set; }

    public virtual AccountAccountTemplate? PropertyTaxPayableAccount { get; set; }

    public virtual AccountAccountTemplate? PropertyTaxReceivableAccount { get; set; }

    public virtual ICollection<ResCompany> ResCompanies { get; } = new List<ResCompany>();

    public virtual ICollection<ResConfigSetting> ResConfigSettings { get; } = new List<ResConfigSetting>();

    public virtual ResUser? WriteU { get; set; }
}
