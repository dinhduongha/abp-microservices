using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class WebsiteBaseUnit
{
    public Guid Id { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? Name { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<ProductProduct> ProductProducts { get; } = new List<ProductProduct>();

    public virtual ICollection<ProductTemplate> ProductTemplates { get; } = new List<ProductTemplate>();

    public virtual ResUser? WriteU { get; set; }
}
