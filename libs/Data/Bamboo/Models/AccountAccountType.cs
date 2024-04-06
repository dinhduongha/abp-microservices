﻿using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class AccountAccountType
{
    public long Id { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Type { get; set; }

    public string? Name { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }

    //public virtual ICollection<AccountFinancialReport> Reports { get; } = new List<AccountFinancialReport>();
}