﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Auditing;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Bamboo.Core.Entities;

[Table("ir_act_report_xml")]
public partial class IrActReportXml
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("binding_model_id")]
    public Guid? BindingModelId { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("type")]
    public string? Type { get; set; }

    [Column("binding_type")]
    public string? BindingType { get; set; }

    [Column("binding_view_types")]
    public string? BindingViewTypes { get; set; }

    [Column("name", TypeName = "jsonb")]
    public string? Name { get; set; }

    [Column("help", TypeName = "jsonb")]
    public string? Help { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [Column("paperformat_id")]
    public long? PaperformatId { get; set; }

    [Column("model")]
    public string? Model { get; set; }

    [Column("report_type")]
    public string? ReportType { get; set; }

    [Column("report_name")]
    public string? ReportName { get; set; }

    [Column("report_file")]
    public string? ReportFile { get; set; }

    [Column("attachment")]
    public string? Attachment { get; set; }

    [Column("print_report_name", TypeName = "jsonb")]
    public string? PrintReportName { get; set; }

    [Column("multi")]
    public bool? Multi { get; set; }

    [Column("attachment_use")]
    public bool? AttachmentUse { get; set; }

    [ForeignKey("BindingModelId")]
    //[InverseProperty("IrActReportXmls")]
    public virtual IrModel? BindingModel { get; set; }

    [ForeignKey("CreatorId")]
    //[InverseProperty("IrActReportXmlCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [InverseProperty("ReportTemplateNavigation")]
    [NotMapped]
    public virtual ICollection<MailTemplate> MailTemplates { get; } = new List<MailTemplate>();

    [ForeignKey("PaperformatId")]
    //[InverseProperty("IrActReportXmls")]
    public virtual ReportPaperformat? Paperformat { get; set; }

    [InverseProperty("ReportTemplateNavigation")]
    [NotMapped]
    public virtual ICollection<SnailmailLetter> SnailmailLetters { get; } = new List<SnailmailLetter>();

    [ForeignKey("LastModifierId")]
    //[InverseProperty("IrActReportXmlWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("Uid")]
    [InverseProperty("Uids")]
    [NotMapped]
    public virtual ICollection<ResGroup> Gids { get; } = new List<ResGroup>();
}