using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class BaseLanguageImport
{
    public Guid Id { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? Name { get; set; }

    public string? Code { get; set; }

    public string? Filename { get; set; }

    public bool? Overwrite { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public byte[]? Data { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
