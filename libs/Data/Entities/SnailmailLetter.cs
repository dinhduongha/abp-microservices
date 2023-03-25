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

[Table("snailmail_letter")]
public partial class SnailmailLetter: IMultiTenant, IMayHaveCreator, IModificationAuditedObject
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("user_id")]
    public Guid? UserId { get; set; }

    [Column("res_id")]
    public Guid? ResId { get; set; }

    [Column("partner_id")]
    public Guid? PartnerId { get; set; }

    [Column("company_id")]
    public Guid? TenantId { get; set; }

    [Column("report_template")]
    public Guid? ReportTemplate { get; set; }

    [Column("attachment_id")]
    public Guid? AttachmentId { get; set; }

    [Column("message_id")]
    public Guid? MessageId { get; set; }

    [Column("state_id")]
    public long? StateId { get; set; }

    [Column("country_id")]
    public long? CountryId { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("model")]
    public string? Model { get; set; }

    [Column("state")]
    public string? State { get; set; }

    [Column("error_code")]
    public string? ErrorCode { get; set; }

    [Column("info_msg")]
    public string? InfoMsg { get; set; }

    [Column("street")]
    public string? Street { get; set; }

    [Column("street2")]
    public string? Street2 { get; set; }

    [Column("zip")]
    public string? Zip { get; set; }

    [Column("city")]
    public string? City { get; set; }

    [Column("color")]
    public bool? Color { get; set; }

    [Column("cover")]
    public bool? Cover { get; set; }

    [Column("duplex")]
    public bool? Duplex { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [ForeignKey("AttachmentId")]
    [InverseProperty("SnailmailLetters")]
    public virtual IrAttachment? Attachment { get; set; }

    [ForeignKey("TenantId")]
    [InverseProperty("SnailmailLetters")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CountryId")]
    [InverseProperty("SnailmailLetters")]
    public virtual ResCountry? Country { get; set; }

    [ForeignKey("CreatorId")]
    [InverseProperty("SnailmailLetterCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [InverseProperty("Letter")]
    public virtual ICollection<MailNotification> MailNotifications { get; } = new List<MailNotification>();

    [ForeignKey("MessageId")]
    [InverseProperty("SnailmailLetters")]
    public virtual MailMessage? Message { get; set; }

    [ForeignKey("PartnerId")]
    [InverseProperty("SnailmailLetters")]
    public virtual ResPartner? Partner { get; set; }

    [ForeignKey("ReportTemplate")]
    [InverseProperty("SnailmailLetters")]
    public virtual IrActReportXml? ReportTemplateNavigation { get; set; }

    [InverseProperty("Letter")]
    public virtual ICollection<SnailmailLetterMissingRequiredField> SnailmailLetterMissingRequiredFields { get; } = new List<SnailmailLetterMissingRequiredField>();

    [ForeignKey("StateId")]
    [InverseProperty("SnailmailLetters")]
    public virtual ResCountryState? StateNavigation { get; set; }

    [ForeignKey("UserId")]
    [InverseProperty("SnailmailLetterUsers")]
    public virtual ResUser? User { get; set; }

    [ForeignKey("LastModifierId")]
    [InverseProperty("SnailmailLetterWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
