using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class RecurringPaymentLine
{
    public Guid Id { get; set; }

    public Guid? RecurringPaymentId { get; set; }

    public Guid? PartnerId { get; set; }

    public Guid? JournalId { get; set; }

    public Guid? TenantId { get; set; }

    public Guid? PaymentId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? State { get; set; }

    public DateOnly? Date { get; set; }

    public decimal? Amount { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual AccountJournal? Journal { get; set; }

    public virtual ResPartner? Partner { get; set; }

    public virtual AccountPayment? Payment { get; set; }

    public virtual RecurringPayment? RecurringPayment { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
