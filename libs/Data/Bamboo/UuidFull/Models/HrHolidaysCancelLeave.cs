using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class HrHolidaysCancelLeave
{
    public Guid Id { get; set; }

    public Guid? LeaveId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? Reason { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual HrLeave? Leave { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
