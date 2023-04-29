using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class BaseModuleInstallRequest
{
    public Guid Id { get; set; }

    public Guid? ModuleId { get; set; }

    public Guid? UserId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? BodyHtml { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual IrModuleModule? Module { get; set; }

    public virtual ResUser? User { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
