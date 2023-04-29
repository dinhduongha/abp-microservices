using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("snailmail_confirm_invoice")]
public partial class SnailmailConfirmInvoice
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("invoice_send_id")]
    public Guid? InvoiceSendId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("model_name")]
    public string? ModelName { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("SnailmailConfirmInvoiceCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("InvoiceSendId")]
    [InverseProperty("SnailmailConfirmInvoices")]
    public virtual AccountInvoiceSend? InvoiceSend { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("SnailmailConfirmInvoiceWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
