using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class HrResumeLine
{
    public Guid Id { get; set; }

    public Guid? EmployeeId { get; set; }

    public long? LineTypeId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? Name { get; set; }

    public string? DisplayType { get; set; }

    public DateOnly? DateStart { get; set; }

    public DateOnly? DateEnd { get; set; }

    public string? Description { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual HrEmployee? Employee { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
