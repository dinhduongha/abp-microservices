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

[Table("base_document_layout")]
public partial class BaseDocumentLayout: IMultiTenant, IMayHaveCreator, IModificationAuditedObject
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("company_id")]
    public Guid? TenantId { get; set; }

    [Column("report_layout_id")]
    public long? ReportLayoutId { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [ForeignKey("TenantId")]
    //[InverseProperty("BaseDocumentLayouts")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreatorId")]
    //[InverseProperty("BaseDocumentLayoutCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("ReportLayoutId")]
    //[InverseProperty("BaseDocumentLayouts")]
    public virtual ReportLayout? ReportLayout { get; set; }

    [ForeignKey("LastModifierId")]
    //[InverseProperty("BaseDocumentLayoutWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
