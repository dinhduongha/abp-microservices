using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("ir_module_category")]
[Index("ParentId", Name = "ir_module_category_parent_id_index")]
public partial class IrModuleCategory
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("parent_id")]
    public Guid? ParentId { get; set; }

    [Column("name", TypeName = "jsonb")]
    public string? Name { get; set; }

    [Column("sequence")]
    public long? Sequence { get; set; }

    [Column("description", TypeName = "jsonb")]
    public string? Description { get; set; }

    [Column("visible")]
    public bool? Visible { get; set; }

    [Column("exclusive")]
    public bool? Exclusive { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("IrModuleCategoryCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [InverseProperty("Parent")]
    public virtual ICollection<IrModuleCategory> InverseParent { get; } = new List<IrModuleCategory>();

    [InverseProperty("Category")]
    public virtual ICollection<IrModuleModule> IrModuleModules { get; } = new List<IrModuleModule>();

    [ForeignKey("ParentId")]
    [InverseProperty("InverseParent")]
    public virtual IrModuleCategory? Parent { get; set; }

    [InverseProperty("Category")]
    public virtual ICollection<ResGroup> ResGroups { get; } = new List<ResGroup>();

    [ForeignKey("WriteUid")]
    [InverseProperty("IrModuleCategoryWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
