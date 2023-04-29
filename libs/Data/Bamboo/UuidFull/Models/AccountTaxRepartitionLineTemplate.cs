using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class AccountTaxRepartitionLineTemplate
{
    public Guid Id { get; set; }

    public Guid? AccountId { get; set; }

    public Guid? InvoiceTaxId { get; set; }

    public Guid? RefundTaxId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? RepartitionType { get; set; }

    public bool? UseInTaxClosing { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public double? FactorPercent { get; set; }

    public virtual AccountAccountTemplate? Account { get; set; }

    public virtual ICollection<AccountTaxRepartitionFinancialTag> AccountTaxRepartitionFinancialTags { get; } = new List<AccountTaxRepartitionFinancialTag>();

    public virtual ResUser? CreateU { get; set; }

    public virtual AccountTaxTemplate? InvoiceTax { get; set; }

    public virtual AccountTaxTemplate? RefundTax { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<AccountReportExpression> AccountReportExpressions { get; } = new List<AccountReportExpression>();

    public virtual ICollection<AccountReportExpression> AccountReportExpressionsNavigation { get; } = new List<AccountReportExpression>();
}
