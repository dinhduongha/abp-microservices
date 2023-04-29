using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class LunchLocation
{
    public Guid Id { get; set; }

    public Guid? CompanyId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? Name { get; set; }

    public string? Address { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<LunchOrder> LunchOrders { get; } = new List<LunchOrder>();

    public virtual ICollection<ResUser> ResUsers { get; } = new List<ResUser>();

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<LunchAlert> LunchAlerts { get; } = new List<LunchAlert>();

    public virtual ICollection<LunchSupplier> LunchSuppliers { get; } = new List<LunchSupplier>();
}
