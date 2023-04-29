using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class SaleOrderTemplateOption
{
    public Guid Id { get; set; }

    public Guid? SaleOrderTemplateId { get; set; }

    public Guid? CompanyId { get; set; }

    public Guid? ProductId { get; set; }

    public Guid? UomId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? Name { get; set; }

    public decimal? Quantity { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ProductProduct? Product { get; set; }

    public virtual SaleOrderTemplate? SaleOrderTemplate { get; set; }

    public virtual UomUom? Uom { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
