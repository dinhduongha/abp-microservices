using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class AccountEdiDocument
{
    public Guid Id { get; set; }

    public Guid? MoveId { get; set; }

    public long? EdiFormatId { get; set; }

    public Guid? AttachmentId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? State { get; set; }

    public string? BlockingLevel { get; set; }

    public string? Error { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual IrAttachment? Attachment { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual AccountMove? Move { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
