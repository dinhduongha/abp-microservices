using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class AccountTaxTemplate
{
    public Guid Id { get; set; }

    public Guid? ChartTemplateId { get; set; }

    public long Sequence { get; set; }

    public Guid? TaxGroupId { get; set; }

    public Guid? CashBasisTransitionAccountId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? Name { get; set; }

    public string? TypeTaxUse { get; set; }

    public string? TaxScope { get; set; }

    public string? AmountType { get; set; }

    public string? Description { get; set; }

    public string? TaxExigibility { get; set; }

    public decimal? Amount { get; set; }

    public bool? Active { get; set; }

    public bool? PriceInclude { get; set; }

    public bool? IncludeBaseAmount { get; set; }

    public bool? IsBaseAffected { get; set; }

    public bool? Analytic { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ICollection<AccountFiscalPositionTaxTemplate> AccountFiscalPositionTaxTemplateTaxDests { get; } = new List<AccountFiscalPositionTaxTemplate>();

    public virtual ICollection<AccountFiscalPositionTaxTemplate> AccountFiscalPositionTaxTemplateTaxSrcs { get; } = new List<AccountFiscalPositionTaxTemplate>();

    public virtual ICollection<AccountTaxRepartitionLineTemplate> AccountTaxRepartitionLineTemplateInvoiceTaxes { get; } = new List<AccountTaxRepartitionLineTemplate>();

    public virtual ICollection<AccountTaxRepartitionLineTemplate> AccountTaxRepartitionLineTemplateRefundTaxes { get; } = new List<AccountTaxRepartitionLineTemplate>();

    public virtual AccountAccountTemplate? CashBasisTransitionAccount { get; set; }

    public virtual AccountChartTemplate? ChartTemplate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual AccountTaxGroup? TaxGroup { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<AccountReconcileModelLineTemplate> AccountReconcileModelLineTemplates { get; } = new List<AccountReconcileModelLineTemplate>();

    public virtual ICollection<AccountAccountTemplate> Accounts { get; } = new List<AccountAccountTemplate>();

    public virtual ICollection<AccountTaxTemplate> ChildTaxes { get; } = new List<AccountTaxTemplate>();

    public virtual ICollection<AccountTaxTemplate> ParentTaxes { get; } = new List<AccountTaxTemplate>();
}
