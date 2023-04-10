using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class ResBank
{
    public Guid Id { get; set; }

    public long? State { get; set; }

    public long? Country { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Name { get; set; }

    public string? Street { get; set; }

    public string? Street2 { get; set; }

    public string? Zip { get; set; }

    public string? City { get; set; }

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public string? Bic { get; set; }

    public bool? Active { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResCountry? CountryNavigation { get; set; }

    public virtual ResUser? CreateU { get; set; }

    //public virtual ICollection<ResPartnerBank> ResPartnerBanks { get; } = new List<ResPartnerBank>();

    public virtual ResCountryState? StateNavigation { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
