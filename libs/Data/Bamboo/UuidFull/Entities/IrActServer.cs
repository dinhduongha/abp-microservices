using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("ir_act_server")]
public partial class IrActServer
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("binding_model_id")]
    public Guid? BindingModelId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

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
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [Column("sequence")]
    public long Sequence { get; set; }

    [Column("model_id")]
    public Guid? ModelId { get; set; }

    [Column("crud_model_id")]
    public Guid? CrudModelId { get; set; }

    [Column("link_field_id")]
    public Guid? LinkFieldId { get; set; }

    [Column("usage")]
    public string? Usage { get; set; }

    [Column("state")]
    public string? State { get; set; }

    [Column("model_name")]
    public string? ModelName { get; set; }

    [Column("code")]
    public string? Code { get; set; }

    [Column("template_id")]
    public Guid? TemplateId { get; set; }

    [Column("activity_type_id")]
    public long? ActivityTypeId { get; set; }

    [Column("activity_date_deadline_range")]
    public long? ActivityDateDeadlineRange { get; set; }

    [Column("activity_user_id")]
    public Guid? ActivityUserId { get; set; }

    [Column("mail_post_method")]
    public string? MailPostMethod { get; set; }

    [Column("activity_summary")]
    public string? ActivitySummary { get; set; }

    [Column("activity_date_deadline_range_type")]
    public string? ActivityDateDeadlineRangeType { get; set; }

    [Column("activity_user_type")]
    public string? ActivityUserType { get; set; }

    [Column("activity_user_field_name")]
    public string? ActivityUserFieldName { get; set; }

    [Column("activity_note")]
    public string? ActivityNote { get; set; }

    [Column("mail_post_autofollow")]
    public bool? MailPostAutofollow { get; set; }

    [Column("sms_template_id")]
    public Guid? SmsTemplateId { get; set; }

    [Column("sms_method")]
    public string? SmsMethod { get; set; }

    [Column("website_path")]
    public string? WebsitePath { get; set; }

    [Column("website_published")]
    public bool? WebsitePublished { get; set; }

    [ForeignKey("ActivityUserId")]
    [InverseProperty("IrActServerActivityUsers")]
    public virtual ResUser? ActivityUser { get; set; }

    [ForeignKey("BindingModelId")]
    [InverseProperty("IrActServerBindingModels")]
    public virtual IrModel? BindingModel { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("IrActServerCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("CrudModelId")]
    [InverseProperty("IrActServerCrudModels")]
    public virtual IrModel? CrudModel { get; set; }

    [InverseProperty("IrActionsServer")]
    public virtual ICollection<IrCron> IrCrons { get; } = new List<IrCron>();

    [InverseProperty("Server")]
    public virtual ICollection<IrServerObjectLine> IrServerObjectLines { get; } = new List<IrServerObjectLine>();

    [ForeignKey("LinkFieldId")]
    [InverseProperty("IrActServers")]
    public virtual IrModelField? LinkField { get; set; }

    [ForeignKey("ModelId")]
    [InverseProperty("IrActServerModels")]
    public virtual IrModel? Model { get; set; }

    [ForeignKey("SmsTemplateId")]
    [InverseProperty("IrActServers")]
    public virtual SmsTemplate? SmsTemplate { get; set; }

    [ForeignKey("TemplateId")]
    [InverseProperty("IrActServers")]
    public virtual MailTemplate? Template { get; set; }

    [InverseProperty("ActionServer")]
    public virtual ICollection<WebsiteSnippetFilter> WebsiteSnippetFilters { get; } = new List<WebsiteSnippetFilter>();

    [ForeignKey("WriteUid")]
    [InverseProperty("IrActServerWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("ServerId")]
    [InverseProperty("Servers")]
    public virtual ICollection<IrActServer> Actions { get; } = new List<IrActServer>();

    [ForeignKey("ActId")]
    [InverseProperty("Acts")]
    public virtual ICollection<ResGroup> Gids { get; } = new List<ResGroup>();

    [ForeignKey("IrActServerId")]
    [InverseProperty("IrActServers")]
    public virtual ICollection<ResPartner> ResPartners { get; } = new List<ResPartner>();

    [ForeignKey("ActionId")]
    [InverseProperty("Actions")]
    public virtual ICollection<IrActServer> Servers { get; } = new List<IrActServer>();
}
