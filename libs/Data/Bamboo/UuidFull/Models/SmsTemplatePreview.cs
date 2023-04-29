using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class SmsTemplatePreview
{
    public Guid Id { get; set; }

    public Guid? SmsTemplateId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? Lang { get; set; }

    public string? ResourceRef { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual SmsTemplate? SmsTemplate { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
