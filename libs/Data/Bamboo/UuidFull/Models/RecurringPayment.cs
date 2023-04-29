using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class RecurringPayment
{
    public Guid Id { get; set; }

    public Guid? PartnerId { get; set; }

    public Guid? CompanyId { get; set; }

    public Guid? TemplateId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? Name { get; set; }

    public string? PaymentType { get; set; }

    public string? State { get; set; }

    public DateOnly? DateBegin { get; set; }

    public DateOnly? DateEnd { get; set; }

    public string? Description { get; set; }

    public decimal? Amount { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResPartner? Partner { get; set; }

    public virtual ICollection<RecurringPaymentLine> RecurringPaymentLines { get; } = new List<RecurringPaymentLine>();

    public virtual AccountRecurringTemplate? Template { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
