using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class MailShortcode
{
    public Guid Id { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? Source { get; set; }

    public string? Description { get; set; }

    public string? Substitution { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
