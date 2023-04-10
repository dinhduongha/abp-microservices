using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class UomCategory
{
    public long Id { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Name { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public bool? IsPosGroupable { get; set; }

    public virtual ResUser? CreateU { get; set; }

    //public virtual ICollection<UomUom> UomUoms { get; } = new List<UomUom>();

    public virtual ResUser? WriteU { get; set; }
}
