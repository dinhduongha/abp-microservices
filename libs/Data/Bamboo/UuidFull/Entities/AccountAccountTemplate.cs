using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("account_account_template")]
public partial class AccountAccountTemplate
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("message_main_attachment_id")]
    public Guid? MessageMainAttachmentId { get; set; }

    [Column("currency_id")]
    public long? CurrencyId { get; set; }

    [Column("chart_template_id")]
    public Guid? ChartTemplateId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("name", TypeName = "jsonb")]
    public string? Name { get; set; }

    [Column("code")]
    public string? Code { get; set; }

    [Column("account_type")]
    public string? AccountType { get; set; }

    [Column("note")]
    public string? Note { get; set; }

    [Column("reconcile")]
    public bool? Reconcile { get; set; }

    [Column("nocreate")]
    public bool? Nocreate { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [InverseProperty("AccountAccountTemplate")]
    public virtual ICollection<AccountAccountTemplateAccountTag> AccountAccountTemplateAccountTags { get; } = new List<AccountAccountTemplateAccountTag>();

    [InverseProperty("AccountJournalEarlyPayDiscountGainAccount")]
    public virtual ICollection<AccountChartTemplate> AccountChartTemplateAccountJournalEarlyPayDiscountGainAccounts { get; } = new List<AccountChartTemplate>();

    [InverseProperty("AccountJournalEarlyPayDiscountLossAccount")]
    public virtual ICollection<AccountChartTemplate> AccountChartTemplateAccountJournalEarlyPayDiscountLossAccounts { get; } = new List<AccountChartTemplate>();

    [InverseProperty("AccountJournalPaymentCreditAccount")]
    public virtual ICollection<AccountChartTemplate> AccountChartTemplateAccountJournalPaymentCreditAccounts { get; } = new List<AccountChartTemplate>();

    [InverseProperty("AccountJournalPaymentDebitAccount")]
    public virtual ICollection<AccountChartTemplate> AccountChartTemplateAccountJournalPaymentDebitAccounts { get; } = new List<AccountChartTemplate>();

    [InverseProperty("AccountJournalSuspenseAccount")]
    public virtual ICollection<AccountChartTemplate> AccountChartTemplateAccountJournalSuspenseAccounts { get; } = new List<AccountChartTemplate>();

    [InverseProperty("DefaultCashDifferenceExpenseAccount")]
    public virtual ICollection<AccountChartTemplate> AccountChartTemplateDefaultCashDifferenceExpenseAccounts { get; } = new List<AccountChartTemplate>();

    [InverseProperty("DefaultCashDifferenceIncomeAccount")]
    public virtual ICollection<AccountChartTemplate> AccountChartTemplateDefaultCashDifferenceIncomeAccounts { get; } = new List<AccountChartTemplate>();

    [InverseProperty("DefaultPosReceivableAccount")]
    public virtual ICollection<AccountChartTemplate> AccountChartTemplateDefaultPosReceivableAccounts { get; } = new List<AccountChartTemplate>();

    [InverseProperty("ExpenseCurrencyExchangeAccount")]
    public virtual ICollection<AccountChartTemplate> AccountChartTemplateExpenseCurrencyExchangeAccounts { get; } = new List<AccountChartTemplate>();

    [InverseProperty("IncomeCurrencyExchangeAccount")]
    public virtual ICollection<AccountChartTemplate> AccountChartTemplateIncomeCurrencyExchangeAccounts { get; } = new List<AccountChartTemplate>();

    [InverseProperty("PropertyAccountExpenseCateg")]
    public virtual ICollection<AccountChartTemplate> AccountChartTemplatePropertyAccountExpenseCategs { get; } = new List<AccountChartTemplate>();

    [InverseProperty("PropertyAccountExpense")]
    public virtual ICollection<AccountChartTemplate> AccountChartTemplatePropertyAccountExpenses { get; } = new List<AccountChartTemplate>();

    [InverseProperty("PropertyAccountIncomeCateg")]
    public virtual ICollection<AccountChartTemplate> AccountChartTemplatePropertyAccountIncomeCategs { get; } = new List<AccountChartTemplate>();

    [InverseProperty("PropertyAccountIncome")]
    public virtual ICollection<AccountChartTemplate> AccountChartTemplatePropertyAccountIncomes { get; } = new List<AccountChartTemplate>();

    [InverseProperty("PropertyAccountPayable")]
    public virtual ICollection<AccountChartTemplate> AccountChartTemplatePropertyAccountPayables { get; } = new List<AccountChartTemplate>();

    [InverseProperty("PropertyAccountReceivable")]
    public virtual ICollection<AccountChartTemplate> AccountChartTemplatePropertyAccountReceivables { get; } = new List<AccountChartTemplate>();

    [InverseProperty("PropertyAdvanceTaxPaymentAccount")]
    public virtual ICollection<AccountChartTemplate> AccountChartTemplatePropertyAdvanceTaxPaymentAccounts { get; } = new List<AccountChartTemplate>();

    [InverseProperty("PropertyCashBasisBaseAccount")]
    public virtual ICollection<AccountChartTemplate> AccountChartTemplatePropertyCashBasisBaseAccounts { get; } = new List<AccountChartTemplate>();

    [InverseProperty("PropertyStockAccountInputCateg")]
    public virtual ICollection<AccountChartTemplate> AccountChartTemplatePropertyStockAccountInputCategs { get; } = new List<AccountChartTemplate>();

    [InverseProperty("PropertyStockAccountOutputCateg")]
    public virtual ICollection<AccountChartTemplate> AccountChartTemplatePropertyStockAccountOutputCategs { get; } = new List<AccountChartTemplate>();

    [InverseProperty("PropertyStockValuationAccount")]
    public virtual ICollection<AccountChartTemplate> AccountChartTemplatePropertyStockValuationAccounts { get; } = new List<AccountChartTemplate>();

    [InverseProperty("PropertyTaxPayableAccount")]
    public virtual ICollection<AccountChartTemplate> AccountChartTemplatePropertyTaxPayableAccounts { get; } = new List<AccountChartTemplate>();

    [InverseProperty("PropertyTaxReceivableAccount")]
    public virtual ICollection<AccountChartTemplate> AccountChartTemplatePropertyTaxReceivableAccounts { get; } = new List<AccountChartTemplate>();

    [InverseProperty("AccountDest")]
    public virtual ICollection<AccountFiscalPositionAccountTemplate> AccountFiscalPositionAccountTemplateAccountDests { get; } = new List<AccountFiscalPositionAccountTemplate>();

    [InverseProperty("AccountSrc")]
    public virtual ICollection<AccountFiscalPositionAccountTemplate> AccountFiscalPositionAccountTemplateAccountSrcs { get; } = new List<AccountFiscalPositionAccountTemplate>();

    [InverseProperty("Account")]
    public virtual ICollection<AccountReconcileModelLineTemplate> AccountReconcileModelLineTemplates { get; } = new List<AccountReconcileModelLineTemplate>();

    [InverseProperty("Account")]
    public virtual ICollection<AccountTaxRepartitionLineTemplate> AccountTaxRepartitionLineTemplates { get; } = new List<AccountTaxRepartitionLineTemplate>();

    [InverseProperty("CashBasisTransitionAccount")]
    public virtual ICollection<AccountTaxTemplate> AccountTaxTemplates { get; } = new List<AccountTaxTemplate>();

    [ForeignKey("ChartTemplateId")]
    [InverseProperty("AccountAccountTemplates")]
    public virtual AccountChartTemplate? ChartTemplate { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("AccountAccountTemplateCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("MessageMainAttachmentId")]
    [InverseProperty("AccountAccountTemplates")]
    public virtual IrAttachment? MessageMainAttachment { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("AccountAccountTemplateWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("AccountId")]
    [InverseProperty("Accounts")]
    public virtual ICollection<AccountTaxTemplate> Taxes { get; } = new List<AccountTaxTemplate>();
}
