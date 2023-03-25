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

[Table("account_chart_template")]
public partial class AccountChartTemplate
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("parent_id")]
    public Guid? ParentId { get; set; }

    [Column("code_digits")]
    public long? CodeDigits { get; set; }

    [Column("currency_id")]
    public long? CurrencyId { get; set; }

    [Column("income_currency_exchange_account_id")]
    public Guid? IncomeCurrencyExchangeAccountId { get; set; }

    [Column("expense_currency_exchange_account_id")]
    public Guid? ExpenseCurrencyExchangeAccountId { get; set; }

    [Column("country_id")]
    public long? CountryId { get; set; }

    [Column("account_journal_suspense_account_id")]
    public Guid? AccountJournalSuspenseAccountId { get; set; }

    [Column("account_journal_payment_debit_account_id")]
    public Guid? AccountJournalPaymentDebitAccountId { get; set; }

    [Column("account_journal_payment_credit_account_id")]
    public Guid? AccountJournalPaymentCreditAccountId { get; set; }

    [Column("default_cash_difference_income_account_id")]
    public Guid? DefaultCashDifferenceIncomeAccountId { get; set; }

    [Column("default_cash_difference_expense_account_id")]
    public Guid? DefaultCashDifferenceExpenseAccountId { get; set; }

    [Column("default_pos_receivable_account_id")]
    public Guid? DefaultPosReceivableAccountId { get; set; }

    [Column("account_journal_early_pay_discount_loss_account_id")]
    public Guid? AccountJournalEarlyPayDiscountLossAccountId { get; set; }

    [Column("account_journal_early_pay_discount_gain_account_id")]
    public Guid? AccountJournalEarlyPayDiscountGainAccountId { get; set; }

    [Column("property_account_receivable_id")]
    public Guid? PropertyAccountReceivableId { get; set; }

    [Column("property_account_payable_id")]
    public Guid? PropertyAccountPayableId { get; set; }

    [Column("property_account_expense_categ_id")]
    public Guid? PropertyAccountExpenseCategId { get; set; }

    [Column("property_account_income_categ_id")]
    public Guid? PropertyAccountIncomeCategId { get; set; }

    [Column("property_account_expense_id")]
    public Guid? PropertyAccountExpenseId { get; set; }

    [Column("property_account_income_id")]
    public Guid? PropertyAccountIncomeId { get; set; }

    [Column("property_stock_account_input_categ_id")]
    public Guid? PropertyStockAccountInputCategId { get; set; }

    [Column("property_stock_account_output_categ_id")]
    public Guid? PropertyStockAccountOutputCategId { get; set; }

    [Column("property_stock_valuation_account_id")]
    public Guid? PropertyStockValuationAccountId { get; set; }

    [Column("property_tax_payable_account_id")]
    public Guid? PropertyTaxPayableAccountId { get; set; }

    [Column("property_tax_receivable_account_id")]
    public Guid? PropertyTaxReceivableAccountId { get; set; }

    [Column("property_advance_tax_payment_account_id")]
    public Guid? PropertyAdvanceTaxPaymentAccountId { get; set; }

    [Column("property_cash_basis_base_account_id")]
    public Guid? PropertyCashBasisBaseAccountId { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("name", TypeName = "jsonb")]
    public string? Name { get; set; }

    [Column("bank_account_code_prefix")]
    public string? BankAccountCodePrefix { get; set; }

    [Column("cash_account_code_prefix")]
    public string? CashAccountCodePrefix { get; set; }

    [Column("transfer_account_code_prefix")]
    public string? TransferAccountCodePrefix { get; set; }

    [Column("visible")]
    public bool? Visible { get; set; }

    [Column("use_anglo_saxon")]
    public bool? UseAngloSaxon { get; set; }

    [Column("use_storno_accounting")]
    public bool? UseStornoAccounting { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [Column("spoken_languages")]
    public string? SpokenLanguages { get; set; }

    [ForeignKey("AccountJournalEarlyPayDiscountGainAccountId")]
    [InverseProperty("AccountChartTemplateAccountJournalEarlyPayDiscountGainAccounts")]
    public virtual AccountAccountTemplate? AccountJournalEarlyPayDiscountGainAccount { get; set; }

    [ForeignKey("AccountJournalEarlyPayDiscountLossAccountId")]
    [InverseProperty("AccountChartTemplateAccountJournalEarlyPayDiscountLossAccounts")]
    public virtual AccountAccountTemplate? AccountJournalEarlyPayDiscountLossAccount { get; set; }

    [ForeignKey("AccountJournalPaymentCreditAccountId")]
    [InverseProperty("AccountChartTemplateAccountJournalPaymentCreditAccounts")]
    public virtual AccountAccountTemplate? AccountJournalPaymentCreditAccount { get; set; }

    [ForeignKey("AccountJournalPaymentDebitAccountId")]
    [InverseProperty("AccountChartTemplateAccountJournalPaymentDebitAccounts")]
    public virtual AccountAccountTemplate? AccountJournalPaymentDebitAccount { get; set; }

    [ForeignKey("AccountJournalSuspenseAccountId")]
    [InverseProperty("AccountChartTemplateAccountJournalSuspenseAccounts")]
    public virtual AccountAccountTemplate? AccountJournalSuspenseAccount { get; set; }

    [ForeignKey("CountryId")]
    [InverseProperty("AccountChartTemplates")]
    public virtual ResCountry? Country { get; set; }

    [ForeignKey("CreatorId")]
    [InverseProperty("AccountChartTemplateCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("CurrencyId")]
    [InverseProperty("AccountChartTemplates")]
    public virtual ResCurrency? Currency { get; set; }

    [ForeignKey("DefaultCashDifferenceExpenseAccountId")]
    [InverseProperty("AccountChartTemplateDefaultCashDifferenceExpenseAccounts")]
    public virtual AccountAccountTemplate? DefaultCashDifferenceExpenseAccount { get; set; }

    [ForeignKey("DefaultCashDifferenceIncomeAccountId")]
    [InverseProperty("AccountChartTemplateDefaultCashDifferenceIncomeAccounts")]
    public virtual AccountAccountTemplate? DefaultCashDifferenceIncomeAccount { get; set; }

    [ForeignKey("DefaultPosReceivableAccountId")]
    [InverseProperty("AccountChartTemplateDefaultPosReceivableAccounts")]
    public virtual AccountAccountTemplate? DefaultPosReceivableAccount { get; set; }

    [ForeignKey("ExpenseCurrencyExchangeAccountId")]
    [InverseProperty("AccountChartTemplateExpenseCurrencyExchangeAccounts")]
    public virtual AccountAccountTemplate? ExpenseCurrencyExchangeAccount { get; set; }

    [ForeignKey("IncomeCurrencyExchangeAccountId")]
    [InverseProperty("AccountChartTemplateIncomeCurrencyExchangeAccounts")]
    public virtual AccountAccountTemplate? IncomeCurrencyExchangeAccount { get; set; }

    [ForeignKey("ParentId")]
    [InverseProperty("InverseParent")]
    public virtual AccountChartTemplate? Parent { get; set; }

    [ForeignKey("PropertyAccountExpenseId")]
    [InverseProperty("AccountChartTemplatePropertyAccountExpenses")]
    public virtual AccountAccountTemplate? PropertyAccountExpense { get; set; }

    [ForeignKey("PropertyAccountExpenseCategId")]
    [InverseProperty("AccountChartTemplatePropertyAccountExpenseCategs")]
    public virtual AccountAccountTemplate? PropertyAccountExpenseCateg { get; set; }

    [ForeignKey("PropertyAccountIncomeId")]
    [InverseProperty("AccountChartTemplatePropertyAccountIncomes")]
    public virtual AccountAccountTemplate? PropertyAccountIncome { get; set; }

    [ForeignKey("PropertyAccountIncomeCategId")]
    [InverseProperty("AccountChartTemplatePropertyAccountIncomeCategs")]
    public virtual AccountAccountTemplate? PropertyAccountIncomeCateg { get; set; }

    [ForeignKey("PropertyAccountPayableId")]
    [InverseProperty("AccountChartTemplatePropertyAccountPayables")]
    public virtual AccountAccountTemplate? PropertyAccountPayable { get; set; }

    [ForeignKey("PropertyAccountReceivableId")]
    [InverseProperty("AccountChartTemplatePropertyAccountReceivables")]
    public virtual AccountAccountTemplate? PropertyAccountReceivable { get; set; }

    [ForeignKey("PropertyAdvanceTaxPaymentAccountId")]
    [InverseProperty("AccountChartTemplatePropertyAdvanceTaxPaymentAccounts")]
    public virtual AccountAccountTemplate? PropertyAdvanceTaxPaymentAccount { get; set; }

    [ForeignKey("PropertyCashBasisBaseAccountId")]
    [InverseProperty("AccountChartTemplatePropertyCashBasisBaseAccounts")]
    public virtual AccountAccountTemplate? PropertyCashBasisBaseAccount { get; set; }

    [ForeignKey("PropertyStockAccountInputCategId")]
    [InverseProperty("AccountChartTemplatePropertyStockAccountInputCategs")]
    public virtual AccountAccountTemplate? PropertyStockAccountInputCateg { get; set; }

    [ForeignKey("PropertyStockAccountOutputCategId")]
    [InverseProperty("AccountChartTemplatePropertyStockAccountOutputCategs")]
    public virtual AccountAccountTemplate? PropertyStockAccountOutputCateg { get; set; }

    [ForeignKey("PropertyStockValuationAccountId")]
    [InverseProperty("AccountChartTemplatePropertyStockValuationAccounts")]
    public virtual AccountAccountTemplate? PropertyStockValuationAccount { get; set; }

    [ForeignKey("PropertyTaxPayableAccountId")]
    [InverseProperty("AccountChartTemplatePropertyTaxPayableAccounts")]
    public virtual AccountAccountTemplate? PropertyTaxPayableAccount { get; set; }

    [ForeignKey("PropertyTaxReceivableAccountId")]
    [InverseProperty("AccountChartTemplatePropertyTaxReceivableAccounts")]
    public virtual AccountAccountTemplate? PropertyTaxReceivableAccount { get; set; }

    [ForeignKey("LastModifierId")]
    [InverseProperty("AccountChartTemplateWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [InverseProperty("ChartTemplate")]
    public virtual ICollection<AccountAccountTemplate> AccountAccountTemplates { get; } = new List<AccountAccountTemplate>();

    [InverseProperty("ChartTemplate")]
    public virtual ICollection<AccountFiscalPositionTemplate> AccountFiscalPositionTemplates { get; } = new List<AccountFiscalPositionTemplate>();

    [InverseProperty("ChartTemplate")]
    public virtual ICollection<AccountGroupTemplate> AccountGroupTemplates { get; } = new List<AccountGroupTemplate>();

    [InverseProperty("ChartTemplate")]
    public virtual ICollection<AccountReconcileModelTemplate> AccountReconcileModelTemplates { get; } = new List<AccountReconcileModelTemplate>();

    [InverseProperty("ChartTemplate")]
    public virtual ICollection<AccountReport> AccountReports { get; } = new List<AccountReport>();

    [InverseProperty("ChartTemplate")]
    public virtual ICollection<AccountTaxTemplate> AccountTaxTemplates { get; } = new List<AccountTaxTemplate>();

    [InverseProperty("Parent")]
    public virtual ICollection<AccountChartTemplate> InverseParent { get; } = new List<AccountChartTemplate>();

    [InverseProperty("ChartTemplate")]
    public virtual ICollection<ResCompany> ResCompanies { get; } = new List<ResCompany>();

    [InverseProperty("ChartTemplate")]
    public virtual ICollection<ResConfigSetting> ResConfigSettings { get; } = new List<ResConfigSetting>();

}
