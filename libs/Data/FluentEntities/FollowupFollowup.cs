using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class FollowupFollowup
{
    public Guid Id { get; set; }

    public Guid? TenantId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    //public virtual ICollection<FollowupLine> FollowupLines { get; } = new List<FollowupLine>();

    //public virtual ICollection<FollowupPrint> FollowupPrints { get; } = new List<FollowupPrint>();

    public virtual ResUser? WriteU { get; set; }
}
