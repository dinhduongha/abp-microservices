using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("report_layout")]
public partial class ReportLayout
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("view_id")]
    public Guid? ViewId { get; set; }

    [Column("sequence")]
    public long Sequence { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("image")]
    public string? Image { get; set; }

    [Column("pdf")]
    public string? Pdf { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("ReportLayoutCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("ViewId")]
    [InverseProperty("ReportLayouts")]
    public virtual IrUiView? View { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("ReportLayoutWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
