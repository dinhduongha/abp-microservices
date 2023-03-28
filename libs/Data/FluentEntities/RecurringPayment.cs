using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class RecurringPayment
{
    public Guid Id { get; set; }

    public Guid? PartnerId { get; set; }

    public Guid? TenantId { get; set; }

    public Guid? TemplateId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Name { get; set; }

    public string? PaymentType { get; set; }

    public string? State { get; set; }

    public DateOnly? DateBegin { get; set; }

    public DateOnly? DateEnd { get; set; }

    public string? Description { get; set; }

    public decimal? Amount { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResPartner? Partner { get; set; }

    //public virtual ICollection<RecurringPaymentLine> RecurringPaymentLines { get; } = new List<RecurringPaymentLine>();

    public virtual AccountRecurringTemplate? Template { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
