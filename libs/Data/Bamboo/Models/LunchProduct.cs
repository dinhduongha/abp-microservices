using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class LunchProduct
{
    public Guid Id { get; set; }

    public Guid? CategoryId { get; set; }

    public Guid? SupplierId { get; set; }

    public Guid? TenantId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public DateOnly? NewUntil { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public decimal? Price { get; set; }

    public bool? Active { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual LunchProductCategory? Category { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    //public virtual ICollection<LunchOrder> LunchOrders { get; } = new List<LunchOrder>();

    public virtual LunchSupplier? Supplier { get; set; }

    public virtual ResUser? WriteU { get; set; }

    //public virtual ICollection<ResUser> Users { get; } = new List<ResUser>();
}
