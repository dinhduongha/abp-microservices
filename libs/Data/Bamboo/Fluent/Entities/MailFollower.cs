using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class MailFollower
{
    public Guid Id { get; set; }

    public Guid? ResId { get; set; }

    public Guid? PartnerId { get; set; }

    public string? ResModel { get; set; }

    public virtual ResPartner? Partner { get; set; }

    //public virtual ICollection<MailMessageSubtype> MailMessageSubtypes { get; } = new List<MailMessageSubtype>();
}
