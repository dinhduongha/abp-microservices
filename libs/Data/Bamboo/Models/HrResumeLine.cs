using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class HrResumeLine
{
    public Guid Id { get; set; }

    public Guid? EmployeeId { get; set; }

    public long? LineTypeId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Name { get; set; }

    public string? DisplayType { get; set; }

    public DateOnly? DateStart { get; set; }

    public DateOnly? DateEnd { get; set; }

    public string? Description { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual HrEmployee? Employee { get; set; }

    public virtual HrResumeLineType? LineType { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
