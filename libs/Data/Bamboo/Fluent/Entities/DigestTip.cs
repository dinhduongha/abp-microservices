﻿using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class DigestTip
{
    public Guid Id { get; set; }

    public long Sequence { get; set; }

    public Guid? GroupId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Name { get; set; }

    public string? TipDescription { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResGroup? Group { get; set; }

    public virtual ResUser? WriteU { get; set; }

    //public virtual ICollection<ResUser> ResUsers { get; } = new List<ResUser>();
}