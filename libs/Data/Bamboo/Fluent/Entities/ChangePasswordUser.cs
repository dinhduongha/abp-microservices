using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class ChangePasswordUser
{
    public Guid Id { get; set; }

    public Guid? WizardId { get; set; }

    public Guid? UserId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? UserLogin { get; set; }

    public string? NewPasswd { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? User { get; set; }

    public virtual ChangePasswordWizard? Wizard { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
