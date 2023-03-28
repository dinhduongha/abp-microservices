using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class AccountReportExpression
{
    public Guid Id { get; set; }

    public Guid? ReportLineId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Label { get; set; }

    public string? Engine { get; set; }

    public string? Formula { get; set; }

    public string? Subformula { get; set; }

    public string? DateScope { get; set; }

    public string? FigureType { get; set; }

    public string? CarryoverTarget { get; set; }

    public bool? GreenOnPositive { get; set; }

    public bool? BlankIfZero { get; set; }

    public bool? Auditable { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    //public virtual ICollection<AccountReportExternalValue> AccountReportExternalValues { get; } = new List<AccountReportExternalValue>();

    public virtual ResUser? CreateU { get; set; }

    public virtual AccountReportLine? ReportLine { get; set; }

    public virtual ResUser? WriteU { get; set; }

    //public virtual ICollection<AccountTaxRepartitionLineTemplate> AccountTaxRepartitionLineTemplates { get; } = new List<AccountTaxRepartitionLineTemplate>();

    //public virtual ICollection<AccountTaxRepartitionLineTemplate> AccountTaxRepartitionLineTemplatesNavigation { get; } = new List<AccountTaxRepartitionLineTemplate>();
}
