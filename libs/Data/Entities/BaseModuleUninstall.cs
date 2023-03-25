using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Auditing;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Bamboo.Core.Entities;

[Table("base_module_uninstall")]
public partial class BaseModuleUninstall
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("module_id")]
    public Guid? ModuleId { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("show_all")]
    public bool? ShowAll { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [ForeignKey("CreatorId")]
    [InverseProperty("BaseModuleUninstallCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("ModuleId")]
    [InverseProperty("BaseModuleUninstalls")]
    public virtual IrModuleModule? Module { get; set; }

    [ForeignKey("LastModifierId")]
    [InverseProperty("BaseModuleUninstallWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
