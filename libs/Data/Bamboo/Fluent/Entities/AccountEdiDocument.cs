using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class AccountEdiDocument
{
    public Guid Id { get; set; }

    public Guid? MoveId { get; set; }

    public long? EdiFormatId { get; set; }

    public Guid? AttachmentId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? State { get; set; }

    public string? BlockingLevel { get; set; }

    public string? Error { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual IrAttachment? Attachment { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual AccountEdiFormat? EdiFormat { get; set; }

    public virtual AccountMove? Move { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
