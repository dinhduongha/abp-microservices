using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class ProductTag
{
    public Guid Id { get; set; }

    public long? Color { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? Name { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public Guid? WebsiteId { get; set; }

    public Guid? RibbonId { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ProductRibbon? Ribbon { get; set; }

    public virtual Website? Website { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
