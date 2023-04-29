using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("ir_exports")]
[Index("Resource", Name = "ir_exports_resource_index")]
public partial class IrExport
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("resource")]
    public string? Resource { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("IrExportCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [InverseProperty("Export")]
    public virtual ICollection<IrExportsLine> IrExportsLines { get; } = new List<IrExportsLine>();

    [ForeignKey("WriteUid")]
    [InverseProperty("IrExportWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
