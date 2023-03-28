using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class IrCronTrigger
{
    public Guid Id { get; set; }

    public Guid? CronId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public DateTime? CallAt { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual IrCron? Cron { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
