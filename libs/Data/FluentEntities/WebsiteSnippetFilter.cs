using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class WebsiteSnippetFilter
{
    public Guid Id { get; set; }

    public Guid? WebsiteId { get; set; }

    public Guid? ActionServerId { get; set; }

    public Guid? FilterId { get; set; }

    public Guid? Limit { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? FieldNames { get; set; }

    public string? Name { get; set; }

    public bool? IsPublished { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public bool? ProductCrossSelling { get; set; }

    public virtual IrActServer? ActionServer { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual IrFilter? Filter { get; set; }

    public virtual Website? Website { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
