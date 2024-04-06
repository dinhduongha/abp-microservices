﻿using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class IrProperty
{
    public Guid Id { get; set; }

    public Guid? TenantId { get; set; }

    public Guid? FieldsId { get; set; }

    public long? ValueInteger { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Name { get; set; }

    public string? ResId { get; set; }

    public string? ValueReference { get; set; }

    public string? Type { get; set; }

    public string? ValueText { get; set; }

    public DateTime? ValueDatetime { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public double? ValueFloat { get; set; }

    public byte[]? ValueBinary { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual IrModelField? Fields { get; set; }

    public virtual ResUser? WriteU { get; set; }
}