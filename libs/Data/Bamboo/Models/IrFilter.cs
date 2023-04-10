using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class IrFilter
{
    public Guid Id { get; set; }

    public Guid? UserId { get; set; }

    public Guid? ActionId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Name { get; set; }

    public string? ModelId { get; set; }

    public string? Domain { get; set; }

    public string? Context { get; set; }

    public string? Sort { get; set; }

    public bool? IsDefault { get; set; }

    public bool? Active { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? User { get; set; }

    //public virtual ICollection<WebsiteSnippetFilter> WebsiteSnippetFilters { get; } = new List<WebsiteSnippetFilter>();

    public virtual ResUser? WriteU { get; set; }
}
