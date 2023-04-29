using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class IrRule
{
    public Guid Id { get; set; }

    public Guid? ModelId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? Name { get; set; }

    public string? DomainForce { get; set; }

    public bool? Active { get; set; }

    public bool? PermRead { get; set; }

    public bool? PermWrite { get; set; }

    public bool? PermCreate { get; set; }

    public bool? PermUnlink { get; set; }

    public bool? Global { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual IrModel? Model { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<ResGroup> Groups { get; } = new List<ResGroup>();
}
