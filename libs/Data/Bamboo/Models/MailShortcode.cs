﻿using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class MailShortcode
{
    public Guid Id { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Source { get; set; }

    public string? Description { get; set; }

    public string? Substitution { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }
}