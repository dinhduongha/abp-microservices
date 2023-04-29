using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class StockQuantPackage
{
    public Guid Id { get; set; }

    public long? PackageTypeId { get; set; }

    public Guid? LocationId { get; set; }

    public Guid? CompanyId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? Name { get; set; }

    public string? PackageUse { get; set; }

    public DateOnly? PackDate { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual StockLocation? Location { get; set; }

    public virtual ICollection<StockMoveLine> StockMoveLinePackages { get; } = new List<StockMoveLine>();

    public virtual ICollection<StockMoveLine> StockMoveLineResultPackages { get; } = new List<StockMoveLine>();

    public virtual ICollection<StockPackageLevel> StockPackageLevels { get; } = new List<StockPackageLevel>();

    public virtual ICollection<StockQuant> StockQuants { get; } = new List<StockQuant>();

    public virtual ICollection<StockScrap> StockScraps { get; } = new List<StockScrap>();

    public virtual ResUser? WriteU { get; set; }
}
