using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("ir_server_object_lines")]
public partial class IrServerObjectLine
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("server_id")]
    public Guid? ServerId { get; set; }

    [Column("col1")]
    public Guid? Col1 { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("evaluation_type")]
    public string? EvaluationType { get; set; }

    [Column("value")]
    public string? Value { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("Col1")]
    [InverseProperty("IrServerObjectLines")]
    public virtual IrModelField? Col1Navigation { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("IrServerObjectLineCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("ServerId")]
    [InverseProperty("IrServerObjectLines")]
    public virtual IrActServer? Server { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("IrServerObjectLineWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
