using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class AccountReportExpression
{
    public Guid Id { get; set; }

    public Guid? ReportLineId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

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

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ICollection<AccountReportExternalValue> AccountReportExternalValues { get; } = new List<AccountReportExternalValue>();

    public virtual ResUser? CreateU { get; set; }

    public virtual AccountReportLine? ReportLine { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<AccountTaxRepartitionLineTemplate> AccountTaxRepartitionLineTemplates { get; } = new List<AccountTaxRepartitionLineTemplate>();

    public virtual ICollection<AccountTaxRepartitionLineTemplate> AccountTaxRepartitionLineTemplatesNavigation { get; } = new List<AccountTaxRepartitionLineTemplate>();
}
