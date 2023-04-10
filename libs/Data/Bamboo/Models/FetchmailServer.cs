using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class FetchmailServer
{
    public Guid Id { get; set; }

    public long? Port { get; set; }

    public Guid? ObjectId { get; set; }

    public long? Priority { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Name { get; set; }

    public string? State { get; set; }

    public string? Server { get; set; }

    public string? ServerType { get; set; }

    public string? User { get; set; }

    public string? Password { get; set; }

    public string? Script { get; set; }

    public string? Configuration { get; set; }

    public bool? Active { get; set; }

    public bool? IsSsl { get; set; }

    public bool? Attach { get; set; }

    public bool? Original { get; set; }

    public DateTime? Date { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public Guid? GoogleGmailAccessTokenExpiration { get; set; }

    public string? GoogleGmailAuthorizationCode { get; set; }

    public string? GoogleGmailRefreshToken { get; set; }

    public string? GoogleGmailAccessToken { get; set; }

    public virtual ResUser? CreateU { get; set; }

    //public virtual ICollection<MailMail> MailMails { get; } = new List<MailMail>();

    public virtual IrModel? Object { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
