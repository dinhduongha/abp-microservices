using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class SaleOrderTemplateLine
{
    public Guid Id { get; set; }

    public Guid? SaleOrderTemplateId { get; set; }

    public long Sequence { get; set; }

    public Guid? TenantId { get; set; }

    public Guid? ProductId { get; set; }

    public Guid? ProductUomId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? DisplayType { get; set; }

    public string? Name { get; set; }

    public decimal? ProductUomQty { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ProductProduct? Product { get; set; }

    public virtual UomUom? ProductUom { get; set; }

    public virtual SaleOrderTemplate? SaleOrderTemplate { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
