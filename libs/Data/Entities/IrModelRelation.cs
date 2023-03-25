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

[Table("ir_model_relation")]
[Index("Model", Name = "ir_model_relation_model_index")]
[Index("Module", Name = "ir_model_relation_module_index")]
[Index("Name", Name = "ir_model_relation_name_index")]
public partial class IrModelRelation
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("model")]
    public Guid? Model { get; set; }

    [Column("module")]
    public Guid? Module { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [ForeignKey("CreatorId")]
    [InverseProperty("IrModelRelationCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("Model")]
    [InverseProperty("IrModelRelations")]
    public virtual IrModel? ModelNavigation { get; set; }

    [ForeignKey("Module")]
    [InverseProperty("IrModelRelations")]
    public virtual IrModuleModule? ModuleNavigation { get; set; }

    [ForeignKey("LastModifierId")]
    [InverseProperty("IrModelRelationWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
