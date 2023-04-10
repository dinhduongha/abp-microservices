using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class FollowupLine
{
    public Guid Id { get; set; }

    public Guid? FollowupId { get; set; }

    public long? Delay { get; set; }

    public Guid? ManualActionResponsibleId { get; set; }

    public Guid? EmailTemplateId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public string? ManualActionNote { get; set; }

    public bool? SendEmail { get; set; }

    public bool? SendLetter { get; set; }

    public bool? ManualAction { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    //public virtual ICollection<AccountMoveLine> AccountMoveLines { get; } = new List<AccountMoveLine>();

    public virtual ResUser? CreateU { get; set; }

    public virtual MailTemplate? EmailTemplate { get; set; }

    public virtual FollowupFollowup? Followup { get; set; }

    public virtual ResUser? ManualActionResponsible { get; set; }

    //public virtual ICollection<ResPartner> ResPartners { get; } = new List<ResPartner>();

    public virtual ResUser? WriteU { get; set; }
}
