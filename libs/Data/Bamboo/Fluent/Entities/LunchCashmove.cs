using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class LunchCashmove
{
    public Guid Id { get; set; }

    public long? CurrencyId { get; set; }

    public Guid? UserId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public DateOnly? Date { get; set; }

    public string? Description { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public double? Amount { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResCurrency? Currency { get; set; }

    public virtual ResUser? User { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
