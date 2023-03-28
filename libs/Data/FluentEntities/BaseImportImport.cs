using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class BaseImportImport
{
    public Guid Id { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? ResModel { get; set; }

    public string? FileName { get; set; }

    public string? FileType { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public byte[]? File { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
