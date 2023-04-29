using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class MailIceServer
{
    public Guid Id { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? ServerType { get; set; }

    public string? Uri { get; set; }

    public string? Username { get; set; }

    public string? Credential { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
