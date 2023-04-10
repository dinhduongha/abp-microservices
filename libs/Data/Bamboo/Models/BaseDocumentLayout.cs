﻿using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class BaseDocumentLayout
{
    public Guid Id { get; set; }

    public Guid? TenantId { get; set; }

    public long? ReportLayoutId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ReportLayout? ReportLayout { get; set; }

    public virtual ResUser? WriteU { get; set; }
}