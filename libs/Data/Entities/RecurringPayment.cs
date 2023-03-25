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

[Table("recurring_payment")]
public partial class RecurringPayment: IMultiTenant, IMayHaveCreator, IModificationAuditedObject
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("partner_id")]
    public Guid? PartnerId { get; set; }

    [Column("company_id")]
    public Guid? TenantId { get; set; }

    [Column("template_id")]
    public Guid? TemplateId { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

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
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [ForeignKey("TenantId")]
    //[InverseProperty("RecurringPayments")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreatorId")]
    //[InverseProperty("RecurringPaymentCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("PartnerId")]
    //[InverseProperty("RecurringPayments")]
    public virtual ResPartner? Partner { get; set; }

    [ForeignKey("TemplateId")]
    //[InverseProperty("RecurringPayments")]
    public virtual AccountRecurringTemplate? Template { get; set; }

    [ForeignKey("LastModifierId")]
    //[InverseProperty("RecurringPaymentWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [InverseProperty("RecurringPayment")]
    [NotMapped]
    public virtual ICollection<RecurringPaymentLine> RecurringPaymentLines { get; } = new List<RecurringPaymentLine>();
}
