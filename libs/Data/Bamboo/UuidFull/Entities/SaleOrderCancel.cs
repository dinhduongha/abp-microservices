using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("sale_order_cancel")]
[Index("AuthorId", Name = "sale_order_cancel_author_id_index")]
public partial class SaleOrderCancel
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("template_id")]
    public Guid? TemplateId { get; set; }

    [Column("author_id")]
    public Guid? AuthorId { get; set; }

    [Column("order_id")]
    public Guid? OrderId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("lang")]
    public string? Lang { get; set; }

    [Column("subject")]
    public string? Subject { get; set; }

    [Column("email_from")]
    public string? EmailFrom { get; set; }

    [Column("body")]
    public string? Body { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("AuthorId")]
    [InverseProperty("SaleOrderCancels")]
    public virtual ResPartner? Author { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("SaleOrderCancelCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("OrderId")]
    [InverseProperty("SaleOrderCancels")]
    public virtual SaleOrder? Order { get; set; }

    [ForeignKey("TemplateId")]
    [InverseProperty("SaleOrderCancels")]
    public virtual MailTemplate? Template { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("SaleOrderCancelWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
