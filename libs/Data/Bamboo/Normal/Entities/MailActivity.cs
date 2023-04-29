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

[Table("mail_activity")]
[Index("DateDeadline", Name = "mail_activity_date_deadline_index")]
[Index("ResId", Name = "mail_activity_res_id_index")]
[Index("ResModelId", Name = "mail_activity_res_model_id_index")]
[Index("ResModel", Name = "mail_activity_res_model_index")]
[Index("UserId", Name = "mail_activity_user_id_index")]
public partial class MailActivity
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("res_model_id")]
    public Guid? ResModelId { get; set; }

    [Column("res_id")]
    public Guid? ResId { get; set; }

    [Column("activity_type_id")]
    public long? ActivityTypeId { get; set; }

    [Column("user_id")]
    public Guid? UserId { get; set; }

    [Column("request_partner_id")]
    public Guid? RequestPartnerId { get; set; }

    [Column("recommended_activity_type_id")]
    public long? RecommendedActivityTypeId { get; set; }

    [Column("previous_activity_type_id")]
    public long? PreviousActivityTypeId { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("res_model")]
    public string? ResModel { get; set; }

    [Column("res_name")]
    public string? ResName { get; set; }

    [Column("summary")]
    public string? Summary { get; set; }

    [Column("date_deadline")]
    public DateOnly? DateDeadline { get; set; }

    [Column("note")]
    public string? Note { get; set; }

    [Column("automated")]
    public bool? Automated { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [Column("calendar_event_id")]
    public Guid? CalendarEventId { get; set; }

    [Column("note_id")]
    public Guid? NoteId { get; set; }

    [ForeignKey("ActivityTypeId")]
    //[InverseProperty("MailActivityActivityTypes")]
    public virtual MailActivityType? ActivityType { get; set; }

    [ForeignKey("CalendarEventId")]
    //[InverseProperty("MailActivities")]
    public virtual CalendarEvent? CalendarEvent { get; set; }

    [ForeignKey("CreatorId")]
    //[InverseProperty("MailActivityCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("NoteId")]
    //[InverseProperty("MailActivities")]
    public virtual NoteNote? NoteNavigation { get; set; }

    [ForeignKey("PreviousActivityTypeId")]
    //[InverseProperty("MailActivityPreviousActivityTypes")]
    public virtual MailActivityType? PreviousActivityType { get; set; }

    [ForeignKey("RecommendedActivityTypeId")]
    //[InverseProperty("MailActivityRecommendedActivityTypes")]
    public virtual MailActivityType? RecommendedActivityType { get; set; }

    [ForeignKey("RequestPartnerId")]
    //[InverseProperty("MailActivities")]
    public virtual ResPartner? RequestPartner { get; set; }

    [ForeignKey("ResModelId")]
    //[InverseProperty("MailActivities")]
    public virtual IrModel? ResModelNavigation { get; set; }

    [ForeignKey("UserId")]
    //[InverseProperty("MailActivityUsers")]
    public virtual ResUser? User { get; set; }

    [ForeignKey("LastModifierId")]
    //[InverseProperty("MailActivityWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
