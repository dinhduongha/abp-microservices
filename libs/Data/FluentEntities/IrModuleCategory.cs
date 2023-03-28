using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class IrModuleCategory
{
    public Guid Id { get; set; }

    public Guid? CreatorId { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public Guid? LastModifierId { get; set; }

    public Guid? ParentId { get; set; }

    public string? Name { get; set; }

    public long? Sequence { get; set; }

    public string? Description { get; set; }

    public bool? Visible { get; set; }

    public bool? Exclusive { get; set; }

    public virtual ResUser? CreateU { get; set; }

    //public virtual ICollection<IrModuleCategory> InverseParent { get; } = new List<IrModuleCategory>();

    //public virtual ICollection<IrModuleModule> IrModuleModules { get; } = new List<IrModuleModule>();

    public virtual IrModuleCategory? Parent { get; set; }

    //public virtual ICollection<ResGroup> ResGroups { get; } = new List<ResGroup>();

    public virtual ResUser? WriteU { get; set; }
}
