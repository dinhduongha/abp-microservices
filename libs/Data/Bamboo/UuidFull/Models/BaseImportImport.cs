using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class BaseImportImport
{
    public Guid Id { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? ResModel { get; set; }

    public string? FileName { get; set; }

    public string? FileType { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public byte[]? File { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
