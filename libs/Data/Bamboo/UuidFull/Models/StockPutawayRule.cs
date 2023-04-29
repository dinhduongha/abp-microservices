using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class StockPutawayRule
{
    public Guid Id { get; set; }

    public Guid? ProductId { get; set; }

    public long? CategoryId { get; set; }

    public Guid? LocationInId { get; set; }

    public Guid? LocationOutId { get; set; }

    public long Sequence { get; set; }

    public Guid? CompanyId { get; set; }

    public long? StorageCategoryId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public bool? Active { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual StockLocation? LocationIn { get; set; }

    public virtual StockLocation? LocationOut { get; set; }

    public virtual ProductProduct? Product { get; set; }

    public virtual ICollection<StockPackageTypeStockPutawayRuleRel> StockPackageTypeStockPutawayRuleRels { get; } = new List<StockPackageTypeStockPutawayRuleRel>();

    public virtual ResUser? WriteU { get; set; }
}
