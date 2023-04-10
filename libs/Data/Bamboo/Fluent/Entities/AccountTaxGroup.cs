using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class AccountTaxGroup
{
    public Guid Id { get; set; }

    public long Sequence { get; set; }

    public long? CountryId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? PrecedingSubtotal { get; set; }

    public string? Name { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    //public virtual ICollection<AccountMoveLine> AccountMoveLines { get; } = new List<AccountMoveLine>();

    //public virtual ICollection<AccountTaxTemplate> AccountTaxTemplates { get; } = new List<AccountTaxTemplate>();

    //public virtual ICollection<AccountTax> AccountTaxes { get; } = new List<AccountTax>();

    public virtual ResCountry? Country { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
