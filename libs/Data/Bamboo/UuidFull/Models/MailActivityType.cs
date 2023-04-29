using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class MailActivityType
{
    public Guid Id { get; set; }

    public long Sequence { get; set; }

    public Guid? CreateUid { get; set; }

    public long? DelayCount { get; set; }

    public long? TriggeredNextTypeId { get; set; }

    public Guid? DefaultUserId { get; set; }

    public Guid? WriteUid { get; set; }

    public string? DelayUnit { get; set; }

    public string? DelayFrom { get; set; }

    public string? Icon { get; set; }

    public string? DecorationType { get; set; }

    public string? ResModel { get; set; }

    public string? ChainingType { get; set; }

    public string? Category { get; set; }

    public string? Name { get; set; }

    public string? Summary { get; set; }

    public string? DefaultNote { get; set; }

    public bool? Active { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? DefaultUser { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
