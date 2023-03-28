using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class MrpWorkcenter
{
    public Guid Id { get; set; }

    public Guid? ResourceId { get; set; }

    public Guid? TenantId { get; set; }

    public Guid? ResourceCalendarId { get; set; }

    public long Sequence { get; set; }

    public long? Color { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Name { get; set; }

    public string? Code { get; set; }

    public string? WorkingState { get; set; }

    public string? Note { get; set; }

    public bool? Active { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public double? TimeEfficiency { get; set; }

    public double? DefaultCapacity { get; set; }

    public double? CostsHour { get; set; }

    public double? TimeStart { get; set; }

    public double? TimeStop { get; set; }

    public double? OeeTarget { get; set; }

    public Guid? CostsHourAccountId { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual AccountAnalyticAccount? CostsHourAccount { get; set; }

    public virtual ResUser? CreateU { get; set; }

    //public virtual ICollection<MrpRoutingWorkcenter> MrpRoutingWorkcenters { get; } = new List<MrpRoutingWorkcenter>();

    //public virtual ICollection<MrpWorkcenterCapacity> MrpWorkcenterCapacities { get; } = new List<MrpWorkcenterCapacity>();

    //public virtual ICollection<MrpWorkcenterProductivity> MrpWorkcenterProductivities { get; } = new List<MrpWorkcenterProductivity>();

    //public virtual ICollection<MrpWorkorder> MrpWorkorders { get; } = new List<MrpWorkorder>();

    public virtual ResourceResource? Resource { get; set; }

    public virtual ResourceCalendar? ResourceCalendar { get; set; }

    public virtual ResUser? WriteU { get; set; }

    //public virtual ICollection<MrpWorkcenter> AlternativeWorkcenters { get; } = new List<MrpWorkcenter>();

    //public virtual ICollection<MrpWorkcenterTag> MrpWorkcenterTags { get; } = new List<MrpWorkcenterTag>();

    //public virtual ICollection<MrpWorkcenter> Workcenters { get; } = new List<MrpWorkcenter>();
}
