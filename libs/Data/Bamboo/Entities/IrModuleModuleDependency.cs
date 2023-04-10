﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Auditing;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Bamboo.Core.Entities;

[Table("ir_module_module_dependency")]
[Index("Name", Name = "ir_module_module_dependency_name_index")]
public partial class IrModuleModuleDependency
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("module_id")]
    public Guid? ModuleId { get; set; }

    [Column("auto_install_required")]
    public bool? AutoInstallRequired { get; set; }

    [ForeignKey("ModuleId")]
    [InverseProperty("IrModuleModuleDependencies")]
    public virtual IrModuleModule? Module { get; set; }
}
