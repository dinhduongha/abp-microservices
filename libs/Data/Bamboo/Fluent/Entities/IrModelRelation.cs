using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class IrModelRelation
{
    public Guid Id { get; set; }

    public Guid? Model { get; set; }

    public Guid? Module { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Name { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public DateTime? CreationTime { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual IrModel? ModelNavigation { get; set; }

    public virtual IrModuleModule? ModuleNavigation { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
