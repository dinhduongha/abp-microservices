using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class NoteNote
{
    public Guid Id { get; set; }

    public Guid? MessageMainAttachmentId { get; set; }

    public Guid? CompanyId { get; set; }

    public Guid? UserId { get; set; }

    public long Sequence { get; set; }

    public long? Color { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public DateOnly? DateDone { get; set; }

    public string? Name { get; set; }

    public string? Memo { get; set; }

    public bool? Open { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<MailActivity> MailActivities { get; } = new List<MailActivity>();

    public virtual IrAttachment? MessageMainAttachment { get; set; }

    public virtual ICollection<NoteStageRel> NoteStageRels { get; } = new List<NoteStageRel>();

    public virtual ResUser? User { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<NoteTag> Tags { get; } = new List<NoteTag>();
}
