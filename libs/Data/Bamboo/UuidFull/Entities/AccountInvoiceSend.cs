using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("account_invoice_send")]
public partial class AccountInvoiceSend
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("composer_id")]
    public Guid? ComposerId { get; set; }

    [Column("template_id")]
    public Guid? TemplateId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("is_email")]
    public bool? IsEmail { get; set; }

    [Column("is_print")]
    public bool? IsPrint { get; set; }

    [Column("printed")]
    public bool? Printed { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [Column("snailmail_is_letter")]
    public bool? SnailmailIsLetter { get; set; }

    [ForeignKey("ComposerId")]
    [InverseProperty("AccountInvoiceSends")]
    public virtual MailComposeMessage? Composer { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("AccountInvoiceSendCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [InverseProperty("InvoiceSend")]
    public virtual ICollection<SnailmailConfirmInvoice> SnailmailConfirmInvoices { get; } = new List<SnailmailConfirmInvoice>();

    [ForeignKey("TemplateId")]
    [InverseProperty("AccountInvoiceSends")]
    public virtual MailTemplate? Template { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("AccountInvoiceSendWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("AccountInvoiceSendId")]
    [InverseProperty("AccountInvoiceSends")]
    public virtual ICollection<AccountMove> AccountMoves { get; } = new List<AccountMove>();
}
