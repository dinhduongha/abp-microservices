using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class WebsiteBaseUnit
{
    public Guid Id { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Name { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResUser? CreateU { get; set; }

    //public virtual ICollection<ProductProduct> ProductProducts { get; } = new List<ProductProduct>();

    //public virtual ICollection<ProductTemplate> ProductTemplates { get; } = new List<ProductTemplate>();

    public virtual ResUser? WriteU { get; set; }
}
