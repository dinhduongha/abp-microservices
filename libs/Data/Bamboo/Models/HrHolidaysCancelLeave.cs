﻿using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class HrHolidaysCancelLeave
{
    public Guid Id { get; set; }

    public Guid? LeaveId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Reason { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual HrLeave? Leave { get; set; }

    public virtual ResUser? WriteU { get; set; }
}