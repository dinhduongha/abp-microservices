using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class BaseImportMapping
{
    public Guid Id { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? ResModel { get; set; }

    public string? ColumnName { get; set; }

    public string? FieldName { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
