using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class BarcodeNomenclature
{
    public long Id { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Name { get; set; }

    public string? UpcEanConv { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public string? Gs1SeparatorFnc1 { get; set; }

    public bool? IsGs1Nomenclature { get; set; }

    //public virtual ICollection<BarcodeRule> BarcodeRules { get; } = new List<BarcodeRule>();

    public virtual ResUser? CreateU { get; set; }

    //public virtual ICollection<ResCompany> ResCompanies { get; } = new List<ResCompany>();

    public virtual ResUser? WriteU { get; set; }
}
