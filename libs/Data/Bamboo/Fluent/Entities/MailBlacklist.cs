using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class MailBlacklist
{
    public Guid Id { get; set; }

    public Guid? MessageMainAttachmentId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Email { get; set; }

    public bool? Active { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual IrAttachment? MessageMainAttachment { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
