using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("ir_model_access")]
[Index("GroupId", Name = "ir_model_access_group_id_index")]
[Index("ModelId", Name = "ir_model_access_model_id_index")]
[Index("Name", Name = "ir_model_access_name_index")]
public partial class IrModelAccess
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("model_id")]
    public Guid? ModelId { get; set; }

    [Column("group_id")]
    public Guid? GroupId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("active")]
    public bool? Active { get; set; }

    [Column("perm_read")]
    public bool? PermRead { get; set; }

    [Column("perm_write")]
    public bool? PermWrite { get; set; }

    [Column("perm_create")]
    public bool? PermCreate { get; set; }

    [Column("perm_unlink")]
    public bool? PermUnlink { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("IrModelAccessCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("GroupId")]
    [InverseProperty("IrModelAccesses")]
    public virtual ResGroup? Group { get; set; }

    [ForeignKey("ModelId")]
    [InverseProperty("IrModelAccesses")]
    public virtual IrModel? Model { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("IrModelAccessWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
