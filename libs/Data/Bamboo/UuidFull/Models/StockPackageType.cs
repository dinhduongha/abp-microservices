using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class StockPackageType
{
    public Guid Id { get; set; }

    public long Sequence { get; set; }

    public long? Height { get; set; }

    public long? Width { get; set; }

    public long? PackagingLength { get; set; }

    public Guid? CompanyId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? Name { get; set; }

    public string? Barcode { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public double? BaseWeight { get; set; }

    public double? MaxWeight { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
