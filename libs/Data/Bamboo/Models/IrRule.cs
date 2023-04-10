using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class IrRule
{
    public Guid Id { get; set; }

    public Guid? ModelId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Name { get; set; }

    public string? DomainForce { get; set; }

    public bool? Active { get; set; }

    public bool? PermRead { get; set; }

    public bool? PermWrite { get; set; }

    public bool? PermCreate { get; set; }

    public bool? PermUnlink { get; set; }

    public bool? Global { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual IrModel? Model { get; set; }

    public virtual ResUser? WriteU { get; set; }

    //public virtual ICollection<ResGroup> Groups { get; } = new List<ResGroup>();
}
