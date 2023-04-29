using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class BaseLanguageExport
{
    public Guid Id { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? Name { get; set; }

    public string? Lang { get; set; }

    public string? Format { get; set; }

    public string? State { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public byte[]? Data { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<IrModuleModule> Modules { get; } = new List<IrModuleModule>();
}
