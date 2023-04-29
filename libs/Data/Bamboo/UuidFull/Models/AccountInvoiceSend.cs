using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class AccountInvoiceSend
{
    public Guid Id { get; set; }

    public Guid? ComposerId { get; set; }

    public Guid? TemplateId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public bool? IsEmail { get; set; }

    public bool? IsPrint { get; set; }

    public bool? Printed { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public bool? SnailmailIsLetter { get; set; }

    public virtual MailComposeMessage? Composer { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<SnailmailConfirmInvoice> SnailmailConfirmInvoices { get; } = new List<SnailmailConfirmInvoice>();

    public virtual MailTemplate? Template { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<AccountMove> AccountMoves { get; } = new List<AccountMove>();
}
