using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class CrmTeamMember
{
    public Guid Id { get; set; }

    public Guid? MessageMainAttachmentId { get; set; }

    public Guid? CrmTeamId { get; set; }

    public Guid? UserId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public bool? Active { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public Guid? AssignmentMax { get; set; }

    public string? AssignmentDomain { get; set; }

    public bool? AssignmentOptout { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual CrmTeam? CrmTeam { get; set; }

    public virtual IrAttachment? MessageMainAttachment { get; set; }

    public virtual ResUser? User { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
