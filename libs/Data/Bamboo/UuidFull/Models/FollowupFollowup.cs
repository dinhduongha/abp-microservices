using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class FollowupFollowup
{
    public Guid Id { get; set; }

    public Guid? CompanyId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<FollowupLine> FollowupLines { get; } = new List<FollowupLine>();

    public virtual ICollection<FollowupPrint> FollowupPrints { get; } = new List<FollowupPrint>();

    public virtual ResUser? WriteU { get; set; }
}
