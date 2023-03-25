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
    [InverseProperty("IrExportsLineCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("ExportId")]
    [InverseProperty("IrExportsLines")]
    public virtual IrExport? Export { get; set; }

    [ForeignKey("LastModifierId")]
    [InverseProperty("IrExportsLineWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
