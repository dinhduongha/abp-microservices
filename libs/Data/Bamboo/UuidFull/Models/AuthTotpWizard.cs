using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class AuthTotpWizard
{
    public Guid Id { get; set; }

    public Guid? UserId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? Secret { get; set; }

    public string? Url { get; set; }

    public string? Code { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public byte[]? Qrcode { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? User { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
