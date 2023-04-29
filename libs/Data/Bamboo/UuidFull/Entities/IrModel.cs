﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("ir_model")]
[Index("Model", Name = "ir_model_obj_name_uniq", IsUnique = true)]
public partial class IrModel
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("model")]
    public string? Model { get; set; }

    [Column("order")]
    public string? Order { get; set; }

    [Column("state")]
    public string? State { get; set; }

    [Column("name", TypeName = "jsonb")]
    public string? Name { get; set; }

    [Column("info")]
    public string? Info { get; set; }

    [Column("transient")]
    public bool? Transient { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [Column("is_mail_thread")]
    public bool? IsMailThread { get; set; }

    [Column("is_mail_activity")]
    public bool? IsMailActivity { get; set; }

    [Column("is_mail_blacklist")]
    public bool? IsMailBlacklist { get; set; }

    [Column("website_form_default_field_id")]
    public Guid? WebsiteFormDefaultFieldId { get; set; }

    [Column("website_form_label")]
    public string? WebsiteFormLabel { get; set; }

    [Column("website_form_key")]
    public string? WebsiteFormKey { get; set; }

    [Column("website_form_access")]
    public bool? WebsiteFormAccess { get; set; }

    [InverseProperty("ResModelNavigation")]
    public virtual ICollection<CalendarEvent> CalendarEvents { get; } = new List<CalendarEvent>();

    [ForeignKey("CreateUid")]
    [InverseProperty("IrModelCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [InverseProperty("Object")]
    public virtual ICollection<FetchmailServer> FetchmailServers { get; } = new List<FetchmailServer>();

    [InverseProperty("BindingModel")]
    public virtual ICollection<IrActClient> IrActClients { get; } = new List<IrActClient>();

    [InverseProperty("BindingModel")]
    public virtual ICollection<IrActReportXml> IrActReportXmls { get; } = new List<IrActReportXml>();

    [InverseProperty("BindingModel")]
    public virtual ICollection<IrActServer> IrActServerBindingModels { get; } = new List<IrActServer>();

    [InverseProperty("CrudModel")]
    public virtual ICollection<IrActServer> IrActServerCrudModels { get; } = new List<IrActServer>();

    [InverseProperty("Model")]
    public virtual ICollection<IrActServer> IrActServerModels { get; } = new List<IrActServer>();

    [InverseProperty("BindingModel")]
    public virtual ICollection<IrActUrl> IrActUrls { get; } = new List<IrActUrl>();

    [InverseProperty("BindingModel")]
    public virtual ICollection<IrActWindow> IrActWindows { get; } = new List<IrActWindow>();

    [InverseProperty("BindingModel")]
    public virtual ICollection<IrAction> IrActions { get; } = new List<IrAction>();

    [InverseProperty("Model")]
    public virtual ICollection<IrModelAccess> IrModelAccesses { get; } = new List<IrModelAccess>();

    [InverseProperty("ModelNavigation")]
    public virtual ICollection<IrModelConstraint> IrModelConstraints { get; } = new List<IrModelConstraint>();

    [InverseProperty("ModelNavigation")]
    public virtual ICollection<IrModelField> IrModelFields { get; } = new List<IrModelField>();

    [InverseProperty("ModelNavigation")]
    public virtual ICollection<IrModelRelation> IrModelRelations { get; } = new List<IrModelRelation>();

    [InverseProperty("Model")]
    public virtual ICollection<IrRule> IrRules { get; } = new List<IrRule>();

    [InverseProperty("ResModelNavigation")]
    public virtual ICollection<MailActivity> MailActivities { get; } = new List<MailActivity>();

    [InverseProperty("AliasModel")]
    public virtual ICollection<MailAlias> MailAliasAliasModels { get; } = new List<MailAlias>();

    [InverseProperty("AliasParentModel")]
    public virtual ICollection<MailAlias> MailAliasAliasParentModels { get; } = new List<MailAlias>();

    [InverseProperty("ModelNavigation")]
    public virtual ICollection<MailTemplate> MailTemplates { get; } = new List<MailTemplate>();

    [InverseProperty("CallbackModel")]
    public virtual ICollection<PaymentTransaction> PaymentTransactions { get; } = new List<PaymentTransaction>();

    [InverseProperty("ResModelNavigation")]
    public virtual ICollection<PrivacyLookupWizardLine> PrivacyLookupWizardLines { get; } = new List<PrivacyLookupWizardLine>();

    [InverseProperty("ParentResModelNavigation")]
    public virtual ICollection<RatingRating> RatingRatingParentResModelNavigations { get; } = new List<RatingRating>();

    [InverseProperty("ResModelNavigation")]
    public virtual ICollection<RatingRating> RatingRatingResModelNavigations { get; } = new List<RatingRating>();

    [InverseProperty("ModelNavigation")]
    public virtual ICollection<SmsTemplate> SmsTemplates { get; } = new List<SmsTemplate>();

    [ForeignKey("WebsiteFormDefaultFieldId")]
    [InverseProperty("IrModels")]
    public virtual IrModelField? WebsiteFormDefaultField { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("IrModelWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
