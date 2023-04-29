using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("ir_exports_line")]
[Index("ExportId", Name = "ir_exports_line_export_id_index")]
public partial class IrExportsLine
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("export_id")]
    public Guid? ExportId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("IrExportsLineCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("ExportId")]
    [InverseProperty("IrExportsLines")]
    public virtual IrExport? Export { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("IrExportsLineWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
