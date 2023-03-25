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

[Table("ir_module_module_exclusion")]
[Index("Name", Name = "ir_module_module_exclusion_name_index")]
public partial class IrModuleModuleExclusion
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

    [Column("name")]
    public string? Name { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [ForeignKey("CreatorId")]
    [InverseProperty("IrModuleModuleExclusionCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("ModuleId")]
    [InverseProperty("IrModuleModuleExclusions")]
    public virtual IrModuleModule? Module { get; set; }

    [ForeignKey("LastModifierId")]
    [InverseProperty("IrModuleModuleExclusionWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
