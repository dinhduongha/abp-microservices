using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class MailFollower
{
    public Guid Id { get; set; }

    public Guid? ResId { get; set; }

    public Guid? PartnerId { get; set; }

    public string? ResModel { get; set; }

    public virtual ICollection<MailFollowersMailMessageSubtypeRel> MailFollowersMailMessageSubtypeRels { get; } = new List<MailFollowersMailMessageSubtypeRel>();

    public virtual ResPartner? Partner { get; set; }
}
