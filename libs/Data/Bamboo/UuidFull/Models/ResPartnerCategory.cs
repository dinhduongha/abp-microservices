﻿using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class ResPartnerCategory
{
    public Guid Id { get; set; }

    public long? Color { get; set; }

    public long? ParentId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? ParentPath { get; set; }

    public string? Name { get; set; }

    public bool? Active { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
