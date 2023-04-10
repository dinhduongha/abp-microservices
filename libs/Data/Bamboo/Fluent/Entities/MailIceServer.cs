using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class MailIceServer
{
    public Guid Id { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? ServerType { get; set; }

    public string? Uri { get; set; }

    public string? Username { get; set; }

    public string? Credential { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
