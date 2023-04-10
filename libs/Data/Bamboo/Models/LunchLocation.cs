using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class LunchLocation
{
    public Guid Id { get; set; }

    public Guid? TenantId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Name { get; set; }

    public string? Address { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    //public virtual ICollection<LunchOrder> LunchOrders { get; } = new List<LunchOrder>();

    //public virtual ICollection<ResUser> ResUsers { get; } = new List<ResUser>();

    public virtual ResUser? WriteU { get; set; }

    //public virtual ICollection<LunchAlert> LunchAlerts { get; } = new List<LunchAlert>();

    //public virtual ICollection<LunchSupplier> LunchSuppliers { get; } = new List<LunchSupplier>();
}
