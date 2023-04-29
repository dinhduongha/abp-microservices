using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class PosPayment
{
    public Guid Id { get; set; }

    public Guid? PosOrderId { get; set; }

    public long? PaymentMethodId { get; set; }

    public Guid? SessionId { get; set; }

    public Guid? CompanyId { get; set; }

    public Guid? AccountMoveId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? Name { get; set; }

    public string? CardType { get; set; }

    public string? CardholderName { get; set; }

    public string? TransactionId { get; set; }

    public string? PaymentStatus { get; set; }

    public string? Ticket { get; set; }

    public decimal? Amount { get; set; }

    public bool? IsChange { get; set; }

    public DateTime? PaymentDate { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual AccountMove? AccountMove { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual PosOrder? PosOrder { get; set; }

    public virtual PosSession? Session { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
