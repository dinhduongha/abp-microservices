using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class AuthTotpWizard
{
    public Guid Id { get; set; }

    public Guid? UserId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Secret { get; set; }

    public string? Url { get; set; }

    public string? Code { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public byte[]? Qrcode { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? User { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
