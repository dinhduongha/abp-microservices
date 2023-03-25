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

[Table("snailmail_confirm_invoice")]
public partial class SnailmailConfirmInvoice
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("invoice_send_id")]
    public Guid? InvoiceSendId { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("model_name")]
    public string? ModelName { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [ForeignKey("CreatorId")]
    [InverseProperty("SnailmailConfirmInvoiceCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("InvoiceSendId")]
    [InverseProperty("SnailmailConfirmInvoices")]
    public virtual AccountInvoiceSend? InvoiceSend { get; set; }

    [ForeignKey("LastModifierId")]
    [InverseProperty("SnailmailConfirmInvoiceWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
