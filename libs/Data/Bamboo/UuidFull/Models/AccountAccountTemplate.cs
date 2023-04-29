using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class AccountAccountTemplate
{
    public Guid Id { get; set; }

    public Guid? MessageMainAttachmentId { get; set; }

    public long? CurrencyId { get; set; }

    public Guid? ChartTemplateId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? Name { get; set; }

    public string? Code { get; set; }

    public string? AccountType { get; set; }

    public string? Note { get; set; }

    public bool? Reconcile { get; set; }

    public bool? Nocreate { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ICollection<AccountAccountTemplateAccountTag> AccountAccountTemplateAccountTags { get; } = new List<AccountAccountTemplateAccountTag>();

    public virtual ICollection<AccountChartTemplate> AccountChartTemplateAccountJournalEarlyPayDiscountGainAccounts { get; } = new List<AccountChartTemplate>();

    public virtual ICollection<AccountChartTemplate> AccountChartTemplateAccountJournalEarlyPayDiscountLossAccounts { get; } = new List<AccountChartTemplate>();

    public virtual ICollection<AccountChartTemplate> AccountChartTemplateAccountJournalPaymentCreditAccounts { get; } = new List<AccountChartTemplate>();

    public virtual ICollection<AccountChartTemplate> AccountChartTemplateAccountJournalPaymentDebitAccounts { get; } = new List<AccountChartTemplate>();

    public virtual ICollection<AccountChartTemplate> AccountChartTemplateAccountJournalSuspenseAccounts { get; } = new List<AccountChartTemplate>();

    public virtual ICollection<AccountChartTemplate> AccountChartTemplateDefaultCashDifferenceExpenseAccounts { get; } = new List<AccountChartTemplate>();

    public virtual ICollection<AccountChartTemplate> AccountChartTemplateDefaultCashDifferenceIncomeAccounts { get; } = new List<AccountChartTemplate>();

    public virtual ICollection<AccountChartTemplate> AccountChartTemplateDefaultPosReceivableAccounts { get; } = new List<AccountChartTemplate>();

    public virtual ICollection<AccountChartTemplate> AccountChartTemplateExpenseCurrencyExchangeAccounts { get; } = new List<AccountChartTemplate>();

    public virtual ICollection<AccountChartTemplate> AccountChartTemplateIncomeCurrencyExchangeAccounts { get; } = new List<AccountChartTemplate>();

    public virtual ICollection<AccountChartTemplate> AccountChartTemplatePropertyAccountExpenseCategs { get; } = new List<AccountChartTemplate>();

    public virtual ICollection<AccountChartTemplate> AccountChartTemplatePropertyAccountExpenses { get; } = new List<AccountChartTemplate>();

    public virtual ICollection<AccountChartTemplate> AccountChartTemplatePropertyAccountIncomeCategs { get; } = new List<AccountChartTemplate>();

    public virtual ICollection<AccountChartTemplate> AccountChartTemplatePropertyAccountIncomes { get; } = new List<AccountChartTemplate>();

    public virtual ICollection<AccountChartTemplate> AccountChartTemplatePropertyAccountPayables { get; } = new List<AccountChartTemplate>();

    public virtual ICollection<AccountChartTemplate> AccountChartTemplatePropertyAccountReceivables { get; } = new List<AccountChartTemplate>();

    public virtual ICollection<AccountChartTemplate> AccountChartTemplatePropertyAdvanceTaxPaymentAccounts { get; } = new List<AccountChartTemplate>();

    public virtual ICollection<AccountChartTemplate> AccountChartTemplatePropertyCashBasisBaseAccounts { get; } = new List<AccountChartTemplate>();

    public virtual ICollection<AccountChartTemplate> AccountChartTemplatePropertyStockAccountInputCategs { get; } = new List<AccountChartTemplate>();

    public virtual ICollection<AccountChartTemplate> AccountChartTemplatePropertyStockAccountOutputCategs { get; } = new List<AccountChartTemplate>();

    public virtual ICollection<AccountChartTemplate> AccountChartTemplatePropertyStockValuationAccounts { get; } = new List<AccountChartTemplate>();

    public virtual ICollection<AccountChartTemplate> AccountChartTemplatePropertyTaxPayableAccounts { get; } = new List<AccountChartTemplate>();

    public virtual ICollection<AccountChartTemplate> AccountChartTemplatePropertyTaxReceivableAccounts { get; } = new List<AccountChartTemplate>();

    public virtual ICollection<AccountFiscalPositionAccountTemplate> AccountFiscalPositionAccountTemplateAccountDests { get; } = new List<AccountFiscalPositionAccountTemplate>();

    public virtual ICollection<AccountFiscalPositionAccountTemplate> AccountFiscalPositionAccountTemplateAccountSrcs { get; } = new List<AccountFiscalPositionAccountTemplate>();

    public virtual ICollection<AccountReconcileModelLineTemplate> AccountReconcileModelLineTemplates { get; } = new List<AccountReconcileModelLineTemplate>();

    public virtual ICollection<AccountTaxRepartitionLineTemplate> AccountTaxRepartitionLineTemplates { get; } = new List<AccountTaxRepartitionLineTemplate>();

    public virtual ICollection<AccountTaxTemplate> AccountTaxTemplates { get; } = new List<AccountTaxTemplate>();

    public virtual AccountChartTemplate? ChartTemplate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual IrAttachment? MessageMainAttachment { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<AccountTaxTemplate> Taxes { get; } = new List<AccountTaxTemplate>();
}
