using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class LunchOrder
{
    public Guid Id { get; set; }

    public Guid? ProductId { get; set; }

    public Guid? CategoryId { get; set; }

    public Guid? SupplierId { get; set; }

    public Guid? UserId { get; set; }

    public Guid? LunchLocationId { get; set; }

    public Guid? TenantId { get; set; }

    public long? CurrencyId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? State { get; set; }

    public DateOnly? Date { get; set; }

    public string? Name { get; set; }

    public string? Note { get; set; }

    public string? DisplayToppings { get; set; }

    public decimal? Price { get; set; }

    public bool? Active { get; set; }

    public bool? Notified { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public double? Quantity { get; set; }

    public virtual LunchProductCategory? Category { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResCurrency? Currency { get; set; }

    public virtual LunchLocation? LunchLocation { get; set; }

    public virtual LunchProduct? Product { get; set; }

    public virtual LunchSupplier? Supplier { get; set; }

    public virtual ResUser? User { get; set; }

    public virtual ResUser? WriteU { get; set; }

    //public virtual ICollection<LunchTopping> Toppings { get; } = new List<LunchTopping>();
}
