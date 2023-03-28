using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class AccountTaxRepartitionLineTemplate
{
    public Guid Id { get; set; }

    public Guid? AccountId { get; set; }

    public Guid? InvoiceTaxId { get; set; }

    public Guid? RefundTaxId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? RepartitionType { get; set; }

    public bool? UseInTaxClosing { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public double? FactorPercent { get; set; }

    public virtual AccountAccountTemplate? Account { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual AccountTaxTemplate? InvoiceTax { get; set; }

    public virtual AccountTaxTemplate? RefundTax { get; set; }

    public virtual ResUser? WriteU { get; set; }

    //public virtual ICollection<AccountAccountTag> AccountAccountTags { get; } = new List<AccountAccountTag>();

    //public virtual ICollection<AccountReportExpression> AccountReportExpressions { get; } = new List<AccountReportExpression>();

    //public virtual ICollection<AccountReportExpression> AccountReportExpressionsNavigation { get; } = new List<AccountReportExpression>();
}
