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

[Table("report_layout")]
public partial class ReportLayout
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("view_id")]
    public Guid? ViewId { get; set; }

    [Column("sequence", TypeName = "bigserial")]
    public long Sequence { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("image")]
    public string? Image { get; set; }

    [Column("pdf")]
    public string? Pdf { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [InverseProperty("ReportLayout")]
    public virtual ICollection<BaseDocumentLayout> BaseDocumentLayouts { get; } = new List<BaseDocumentLayout>();

    [ForeignKey("CreatorId")]
    [InverseProperty("ReportLayoutCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("ViewId")]
    [InverseProperty("ReportLayouts")]
    public virtual IrUiView? View { get; set; }

    [ForeignKey("LastModifierId")]
    [InverseProperty("ReportLayoutWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
