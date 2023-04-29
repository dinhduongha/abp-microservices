﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("ir_mail_server")]
[Index("Name", Name = "ir_mail_server_name_index")]
public partial class IrMailServer
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("smtp_port")]
    public long? SmtpPort { get; set; }

    [Column("sequence")]
    public long Sequence { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("from_filter")]
    public string? FromFilter { get; set; }

    [Column("smtp_host")]
    public string? SmtpHost { get; set; }

    [Column("smtp_authentication")]
    public string? SmtpAuthentication { get; set; }

    [Column("smtp_user")]
    public string? SmtpUser { get; set; }

    [Column("smtp_pass")]
    public string? SmtpPass { get; set; }

    [Column("smtp_encryption")]
    public string? SmtpEncryption { get; set; }

    [Column("smtp_debug")]
    public bool? SmtpDebug { get; set; }

    [Column("active")]
    public bool? Active { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [Column("smtp_ssl_certificate")]
    public byte[]? SmtpSslCertificate { get; set; }

    [Column("smtp_ssl_private_key")]
    public byte[]? SmtpSslPrivateKey { get; set; }

    [Column("google_gmail_access_token_expiration")]
    public long? GoogleGmailAccessTokenExpiration { get; set; }

    [Column("google_gmail_authorization_code")]
    public string? GoogleGmailAuthorizationCode { get; set; }

    [Column("google_gmail_refresh_token")]
    public string? GoogleGmailRefreshToken { get; set; }

    [Column("google_gmail_access_token")]
    public string? GoogleGmailAccessToken { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("IrMailServerCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [InverseProperty("MailServer")]
    public virtual ICollection<MailComposeMessage> MailComposeMessages { get; } = new List<MailComposeMessage>();

    [InverseProperty("MailServer")]
    public virtual ICollection<MailMessage> MailMessages { get; } = new List<MailMessage>();

    [InverseProperty("MailServer")]
    public virtual ICollection<MailTemplate> MailTemplates { get; } = new List<MailTemplate>();

    [ForeignKey("WriteUid")]
    [InverseProperty("IrMailServerWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
