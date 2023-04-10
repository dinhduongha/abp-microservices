using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class AccountAccountTag
{
    public long Id { get; set; }

    public long? Color { get; set; }

    public long? CountryId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Name { get; set; }

    public string? Applicability { get; set; }

    public bool? Active { get; set; }

    public bool? TaxNegate { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResCountry? Country { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }

    //public virtual ICollection<AccountAccountTemplate> AccountAccountTemplates { get; } = new List<AccountAccountTemplate>();

    //public virtual ICollection<AccountAccount> AccountAccounts { get; } = new List<AccountAccount>();

    //public virtual ICollection<AccountMoveLine> AccountMoveLines { get; } = new List<AccountMoveLine>();

    //public virtual ICollection<AccountTaxRepartitionLineTemplate> AccountTaxRepartitionLineTemplates { get; } = new List<AccountTaxRepartitionLineTemplate>();

    //public virtual ICollection<AccountTaxRepartitionLine> AccountTaxRepartitionLines { get; } = new List<AccountTaxRepartitionLine>();

    //public virtual ICollection<ProductTemplate> ProductTemplates { get; } = new List<ProductTemplate>();
}
