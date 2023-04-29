using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class MailMessageSubtype
{
    public Guid Id { get; set; }

    public long? ParentId { get; set; }

    public long Sequence { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? RelationField { get; set; }

    public string? ResModel { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public bool? Internal { get; set; }

    public bool? Default { get; set; }

    public bool? Hidden { get; set; }

    public bool? TrackRecipients { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
