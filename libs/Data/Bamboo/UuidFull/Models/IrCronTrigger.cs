using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class IrCronTrigger
{
    public Guid Id { get; set; }

    public Guid? CronId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public DateTime? CallAt { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual IrCron? Cron { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
