using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class MailActivityTypeMailTemplateRel
{
    public long MailActivityTypeId { get; set; }

    public Guid MailTemplateId { get; set; }

    public virtual MailTemplate MailTemplate { get; set; } = null!;
}
