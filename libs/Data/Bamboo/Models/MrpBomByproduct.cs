﻿using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class MrpBomByproduct
{
    public Guid Id { get; set; }

    public Guid? ProductId { get; set; }

    public Guid? TenantId { get; set; }

    public Guid? ProductUomId { get; set; }

    public Guid? BomId { get; set; }

    public Guid? OperationId { get; set; }

    public long Sequence { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public decimal? ProductQty { get; set; }

    public decimal? CostShare { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual MrpBom? Bom { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual MrpRoutingWorkcenter? Operation { get; set; }

    public virtual ProductProduct? Product { get; set; }

    public virtual UomUom? ProductUom { get; set; }

    //public virtual ICollection<StockMove> StockMoves { get; } = new List<StockMove>();

    public virtual ResUser? WriteU { get; set; }

    //public virtual ICollection<ProductTemplateAttributeValue> ProductTemplateAttributeValues { get; } = new List<ProductTemplateAttributeValue>();
}