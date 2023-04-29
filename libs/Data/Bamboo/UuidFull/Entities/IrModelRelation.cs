using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

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
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("IrModelRelationCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("Model")]
    [InverseProperty("IrModelRelations")]
    public virtual IrModel? ModelNavigation { get; set; }

    [ForeignKey("Module")]
    [InverseProperty("IrModelRelations")]
    public virtual IrModuleModule? ModuleNavigation { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("IrModelRelationWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
