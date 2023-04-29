using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("snailmail_letter")]
public partial class SnailmailLetter
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
    public Guid? CompanyId { get; set; }

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
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

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
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("AttachmentId")]
    [InverseProperty("SnailmailLetters")]
    public virtual IrAttachment? Attachment { get; set; }

    [ForeignKey("CompanyId")]
    [InverseProperty("SnailmailLetters")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreateUid")]
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

    [ForeignKey("UserId")]
    [InverseProperty("SnailmailLetterUsers")]
    public virtual ResUser? User { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("SnailmailLetterWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
