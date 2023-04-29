using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class MrpBomByproduct
{
    public Guid Id { get; set; }

    public Guid? ProductId { get; set; }

    public Guid? CompanyId { get; set; }

    public Guid? ProductUomId { get; set; }

    public Guid? BomId { get; set; }

    public Guid? OperationId { get; set; }

    public long Sequence { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public decimal? ProductQty { get; set; }

    public decimal? CostShare { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual MrpBom? Bom { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual MrpRoutingWorkcenter? Operation { get; set; }

    public virtual ProductProduct? Product { get; set; }

    public virtual UomUom? ProductUom { get; set; }

    public virtual ICollection<StockMove> StockMoves { get; } = new List<StockMove>();

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<ProductTemplateAttributeValue> ProductTemplateAttributeValues { get; } = new List<ProductTemplateAttributeValue>();
}
