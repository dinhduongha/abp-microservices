using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class NoteNote
{
    public Guid Id { get; set; }

    public Guid? MessageMainAttachmentId { get; set; }

    public Guid? TenantId { get; set; }

    public Guid? UserId { get; set; }

    public long Sequence { get; set; }

    public long? Color { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public DateOnly? DateDone { get; set; }

    public string? Name { get; set; }

    public string? Memo { get; set; }

    public bool? Open { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    //public virtual ICollection<MailActivity> MailActivities { get; } = new List<MailActivity>();

    public virtual IrAttachment? MessageMainAttachment { get; set; }

    public virtual ResUser? User { get; set; }

    public virtual ResUser? WriteU { get; set; }

    //public virtual ICollection<NoteStage> Stages { get; } = new List<NoteStage>();

    //public virtual ICollection<NoteTag> Tags { get; } = new List<NoteTag>();
}
