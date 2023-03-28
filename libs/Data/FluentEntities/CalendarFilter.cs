using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class CalendarFilter
{
    public Guid Id { get; set; }

    public Guid? UserId { get; set; }

    public Guid? PartnerId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public bool? Active { get; set; }

    public bool? PartnerChecked { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResPartner? Partner { get; set; }

    public virtual ResUser? User { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
