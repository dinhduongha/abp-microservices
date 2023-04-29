using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class MrpWorkcenterProductivity
{
    public Guid Id { get; set; }

    public Guid? WorkcenterId { get; set; }

    public Guid? CompanyId { get; set; }

    public Guid? WorkorderId { get; set; }

    public Guid? UserId { get; set; }

    public Guid? LossId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? LossType { get; set; }

    public string? Description { get; set; }

    public DateTime? DateStart { get; set; }

    public DateTime? DateEnd { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public double? Duration { get; set; }

    public bool? CostAlreadyRecorded { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual MrpWorkcenterProductivityLoss? Loss { get; set; }

    public virtual ResUser? User { get; set; }

    public virtual MrpWorkcenter? Workcenter { get; set; }

    public virtual MrpWorkorder? Workorder { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
