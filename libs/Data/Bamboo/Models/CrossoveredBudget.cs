﻿using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class CrossoveredBudget
{
    public Guid Id { get; set; }

    public Guid? MessageMainAttachmentId { get; set; }

    public Guid? UserId { get; set; }

    public Guid? TenantId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Name { get; set; }

    public string? State { get; set; }

    public DateOnly? DateFrom { get; set; }

    public DateOnly? DateTo { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    //public virtual ICollection<CrossoveredBudgetLine> CrossoveredBudgetLines { get; } = new List<CrossoveredBudgetLine>();

    public virtual IrAttachment? MessageMainAttachment { get; set; }

    public virtual ResUser? User { get; set; }

    public virtual ResUser? WriteU { get; set; }
}