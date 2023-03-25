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
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("is_email")]
    public bool? IsEmail { get; set; }

    [Column("is_print")]
    public bool? IsPrint { get; set; }

    [Column("printed")]
    public bool? Printed { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [Column("snailmail_is_letter")]
    public bool? SnailmailIsLetter { get; set; }

    [ForeignKey("ComposerId")]
    //[InverseProperty("AccountInvoiceSends")]
    public virtual MailComposeMessage? Composer { get; set; }

    [ForeignKey("CreatorId")]
    //[InverseProperty("AccountInvoiceSendCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("TemplateId")]
    //[InverseProperty("AccountInvoiceSends")]
    public virtual MailTemplate? Template { get; set; }

    [ForeignKey("LastModifierId")]
    //[InverseProperty("AccountInvoiceSendWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [InverseProperty("InvoiceSend")]
    [NotMapped]
    public virtual ICollection<SnailmailConfirmInvoice> SnailmailConfirmInvoices { get; } = new List<SnailmailConfirmInvoice>();

    [ForeignKey("AccountInvoiceSendId")]
    [InverseProperty("AccountInvoiceSends")]
    [NotMapped]
    public virtual ICollection<AccountMove> AccountMoves { get; } = new List<AccountMove>();
}
