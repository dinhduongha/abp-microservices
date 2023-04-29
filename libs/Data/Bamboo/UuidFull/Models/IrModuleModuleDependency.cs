using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class IrModuleModuleDependency
{
    public Guid Id { get; set; }

    public string? Name { get; set; }

    public Guid? ModuleId { get; set; }

    public bool? AutoInstallRequired { get; set; }

    public virtual IrModuleModule? Module { get; set; }
}
