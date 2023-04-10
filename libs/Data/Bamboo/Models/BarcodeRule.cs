using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class BarcodeRule
{
    public Guid Id { get; set; }

    public long? BarcodeNomenclatureId { get; set; }

    public long Sequence { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Name { get; set; }

    public string? Encoding { get; set; }

    public string? Type { get; set; }

    public string? Pattern { get; set; }

    public string? Alias { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public Guid? AssociatedUomId { get; set; }

    public string? Gs1ContentType { get; set; }

    public bool? Gs1DecimalUsage { get; set; }

    public virtual UomUom? AssociatedUom { get; set; }

    public virtual BarcodeNomenclature? BarcodeNomenclature { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
