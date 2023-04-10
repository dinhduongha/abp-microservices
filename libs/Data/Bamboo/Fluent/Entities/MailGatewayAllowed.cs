using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class MailGatewayAllowed
{
    public Guid Id { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Email { get; set; }

    public string? EmailNormalized { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
