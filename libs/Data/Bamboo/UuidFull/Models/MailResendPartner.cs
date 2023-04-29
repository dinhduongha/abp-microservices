using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class MailResendPartner
{
    public Guid Id { get; set; }

    public Guid? PartnerId { get; set; }

    public Guid? ResendWizardId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? Message { get; set; }

    public bool? Resend { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResPartner? Partner { get; set; }

    public virtual MailResendMessage? ResendWizard { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
