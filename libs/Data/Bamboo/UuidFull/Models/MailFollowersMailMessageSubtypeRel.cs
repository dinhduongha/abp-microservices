using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class MailFollowersMailMessageSubtypeRel
{
    public Guid MailFollowersId { get; set; }

    public long MailMessageSubtypeId { get; set; }

    public virtual MailFollower MailFollowers { get; set; } = null!;
}
