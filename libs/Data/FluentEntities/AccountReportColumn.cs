using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class AccountReportColumn
{
    public Guid Id { get; set; }

    public long? Sequence { get; set; }

    public Guid? ReportId { get; set; }

    public Guid? CustomAuditActionId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? ExpressionLabel { get; set; }

    public string? FigureType { get; set; }

    public string? Name { get; set; }

    public bool? Sortable { get; set; }

    public bool? BlankIfZero { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual IrActWindow? CustomAuditAction { get; set; }

    public virtual AccountReport? Report { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
