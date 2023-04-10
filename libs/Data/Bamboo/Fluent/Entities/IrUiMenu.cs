using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class IrUiMenu
{
    public Guid Id { get; set; }

    public long Sequence { get; set; }

    public Guid? ParentId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? ParentPath { get; set; }

    public string? WebIcon { get; set; }

    public string? Action { get; set; }

    public string? Name { get; set; }

    public bool? Active { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResUser? CreateU { get; set; }

    //public virtual ICollection<IrUiMenu> InverseParent { get; } = new List<IrUiMenu>();

    public virtual IrUiMenu? Parent { get; set; }

    //public virtual ICollection<WizardIrModelMenuCreate> WizardIrModelMenuCreates { get; } = new List<WizardIrModelMenuCreate>();

    public virtual ResUser? WriteU { get; set; }

    //public virtual ICollection<ResGroup> Gids { get; } = new List<ResGroup>();
}
