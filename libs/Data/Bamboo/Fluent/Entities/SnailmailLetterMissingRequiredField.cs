using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class SnailmailLetterMissingRequiredField
{
    public Guid Id { get; set; }

    public Guid? PartnerId { get; set; }

    public Guid? LetterId { get; set; }

    public long? StateId { get; set; }

    public long? CountryId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Street { get; set; }

    public string? Street2 { get; set; }

    public string? Zip { get; set; }

    public string? City { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResCountry? Country { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual SnailmailLetter? Letter { get; set; }

    public virtual ResPartner? Partner { get; set; }

    public virtual ResCountryState? State { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
