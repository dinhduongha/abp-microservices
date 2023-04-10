using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class IrCron
{
    public Guid Id { get; set; }

    public Guid? IrActionsServerId { get; set; }

    public Guid? UserId { get; set; }

    public long? IntervalNumber { get; set; }

    public long? Numbercall { get; set; }

    public long? Priority { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? IntervalType { get; set; }

    public string? CronName { get; set; }

    public bool? Active { get; set; }

    public bool? Doall { get; set; }

    public DateTime? Nextcall { get; set; }

    public DateTime? Lastcall { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual IrActServer? IrActionsServer { get; set; }

    //public virtual ICollection<IrCronTrigger> IrCronTriggers { get; } = new List<IrCronTrigger>();

    //public virtual ICollection<LunchAlert> LunchAlerts { get; } = new List<LunchAlert>();

    //public virtual ICollection<LunchSupplier> LunchSuppliers { get; } = new List<LunchSupplier>();

    public virtual ResUser? User { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
