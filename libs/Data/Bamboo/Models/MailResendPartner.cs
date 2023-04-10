using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class MailResendPartner
{
    public Guid Id { get; set; }

    public Guid? PartnerId { get; set; }

    public Guid? ResendWizardId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Message { get; set; }

    public bool? Resend { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResPartner? Partner { get; set; }

    public virtual MailResendMessage? ResendWizard { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
