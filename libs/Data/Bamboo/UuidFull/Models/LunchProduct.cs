using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class LunchProduct
{
    public Guid Id { get; set; }

    public Guid? CategoryId { get; set; }

    public Guid? SupplierId { get; set; }

    public Guid? CompanyId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public DateOnly? NewUntil { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public decimal? Price { get; set; }

    public bool? Active { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual LunchProductCategory? Category { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<LunchOrder> LunchOrders { get; } = new List<LunchOrder>();

    public virtual LunchSupplier? Supplier { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<ResUser> Users { get; } = new List<ResUser>();
}
