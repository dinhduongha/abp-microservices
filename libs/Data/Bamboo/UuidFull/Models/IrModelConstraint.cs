using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class IrModelConstraint
{
    public Guid Id { get; set; }

    public Guid? Model { get; set; }

    public Guid? Module { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? Name { get; set; }

    public string? Definition { get; set; }

    public string? Type { get; set; }

    public string? Message { get; set; }

    public DateTime? WriteDate { get; set; }

    public DateTime? CreateDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual IrModel? ModelNavigation { get; set; }

    public virtual IrModuleModule? ModuleNavigation { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
