using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class IrDemoFailure
{
    public Guid Id { get; set; }

    public Guid? ModuleId { get; set; }

    public Guid? WizardId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Error { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual IrModuleModule? Module { get; set; }

    public virtual IrDemoFailureWizard? Wizard { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
