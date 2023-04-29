using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("recurring_payment")]
public partial class RecurringPayment
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("partner_id")]
    public Guid? PartnerId { get; set; }

    [Column("company_id")]
    public Guid? CompanyId { get; set; }

    [Column("template_id")]
    public Guid? TemplateId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("payment_type")]
    public string? PaymentType { get; set; }

    [Column("state")]
    public string? State { get; set; }

    [Column("date_begin")]
    public DateOnly? DateBegin { get; set; }

    [Column("date_end")]
    public DateOnly? DateEnd { get; set; }

    [Column("description")]
    public string? Description { get; set; }

    [Column("amount")]
    public decimal? Amount { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CompanyId")]
    [InverseProperty("RecurringPayments")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("RecurringPaymentCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("PartnerId")]
    [InverseProperty("RecurringPayments")]
    public virtual ResPartner? Partner { get; set; }

    [InverseProperty("RecurringPayment")]
    public virtual ICollection<RecurringPaymentLine> RecurringPaymentLines { get; } = new List<RecurringPaymentLine>();

    [ForeignKey("TemplateId")]
    [InverseProperty("RecurringPayments")]
    public virtual AccountRecurringTemplate? Template { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("RecurringPaymentWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
