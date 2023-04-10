using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class FollowupPrint
{
    public Guid Id { get; set; }

    public Guid? FollowupId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? EmailSubject { get; set; }

    public DateOnly? Date { get; set; }

    public string? EmailBody { get; set; }

    public string? Summary { get; set; }

    public bool? EmailConf { get; set; }

    public bool? PartnerLang { get; set; }

    public bool? TestPrint { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual FollowupFollowup? Followup { get; set; }

    //public virtual ICollection<PartnerStatRel> PartnerStatRels { get; } = new List<PartnerStatRel>();

    public virtual ResUser? WriteU { get; set; }
}
