using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class BaseLanguageExport
{
    public Guid Id { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Name { get; set; }

    public string? Lang { get; set; }

    public string? Format { get; set; }

    public string? State { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public byte[]? Data { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }

    //public virtual ICollection<IrModuleModule> Modules { get; } = new List<IrModuleModule>();
}
