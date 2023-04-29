using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class AccountReportColumn
{
    public Guid Id { get; set; }

    public long? Sequence { get; set; }

    public Guid? ReportId { get; set; }

    public Guid? CustomAuditActionId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? ExpressionLabel { get; set; }

    public string? FigureType { get; set; }

    public string? Name { get; set; }

    public bool? Sortable { get; set; }

    public bool? BlankIfZero { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual IrActWindow? CustomAuditAction { get; set; }

    public virtual AccountReport? Report { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
