using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class AccountReportExternalValue
{
    public Guid Id { get; set; }

    public Guid? TargetReportExpressionId { get; set; }

    public Guid? CompanyId { get; set; }

    public Guid? ForeignVatFiscalPositionId { get; set; }

    public Guid? CarryoverOriginReportLineId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? Name { get; set; }

    public string? CarryoverOriginExpressionLabel { get; set; }

    public DateOnly? Date { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public double? Value { get; set; }

    public virtual AccountReportLine? CarryoverOriginReportLine { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual AccountFiscalPosition? ForeignVatFiscalPosition { get; set; }

    public virtual AccountReportExpression? TargetReportExpression { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
