using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class AccountAccountTag
{
    public Guid Id { get; set; }

    public long? Color { get; set; }

    public long? CountryId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? Name { get; set; }

    public string? Applicability { get; set; }

    public bool? Active { get; set; }

    public bool? TaxNegate { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
