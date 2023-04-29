using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class SnailmailLetterMissingRequiredField
{
    public Guid Id { get; set; }

    public Guid? PartnerId { get; set; }

    public Guid? LetterId { get; set; }

    public long? StateId { get; set; }

    public long? CountryId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? Street { get; set; }

    public string? Street2 { get; set; }

    public string? Zip { get; set; }

    public string? City { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual SnailmailLetter? Letter { get; set; }

    public virtual ResPartner? Partner { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
