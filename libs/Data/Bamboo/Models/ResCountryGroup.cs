using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class ResCountryGroup
{
    public long Id { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Name { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    //public virtual ICollection<AccountFiscalPositionTemplate> AccountFiscalPositionTemplates { get; } = new List<AccountFiscalPositionTemplate>();

    //public virtual ICollection<AccountFiscalPosition> AccountFiscalPositions { get; } = new List<AccountFiscalPosition>();

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }

    //public virtual ICollection<ProductPricelist> Pricelists { get; } = new List<ProductPricelist>();

    //public virtual ICollection<ResCountry> ResCountries { get; } = new List<ResCountry>();
}
