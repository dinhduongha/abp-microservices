using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class IrMailServer
{
    public Guid Id { get; set; }

    public long? SmtpPort { get; set; }

    public long Sequence { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? Name { get; set; }

    public string? FromFilter { get; set; }

    public string? SmtpHost { get; set; }

    public string? SmtpAuthentication { get; set; }

    public string? SmtpUser { get; set; }

    public string? SmtpPass { get; set; }

    public string? SmtpEncryption { get; set; }

    public bool? SmtpDebug { get; set; }

    public bool? Active { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public byte[]? SmtpSslCertificate { get; set; }

    public byte[]? SmtpSslPrivateKey { get; set; }

    public long? GoogleGmailAccessTokenExpiration { get; set; }

    public string? GoogleGmailAuthorizationCode { get; set; }

    public string? GoogleGmailRefreshToken { get; set; }

    public string? GoogleGmailAccessToken { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<MailComposeMessage> MailComposeMessages { get; } = new List<MailComposeMessage>();

    public virtual ICollection<MailMessage> MailMessages { get; } = new List<MailMessage>();

    public virtual ICollection<MailTemplate> MailTemplates { get; } = new List<MailTemplate>();

    public virtual ResUser? WriteU { get; set; }
}
