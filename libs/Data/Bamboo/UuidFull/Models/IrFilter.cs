using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class IrFilter
{
    public Guid Id { get; set; }

    public Guid? UserId { get; set; }

    public Guid? ActionId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? Name { get; set; }

    public string? ModelId { get; set; }

    public string? Domain { get; set; }

    public string? Context { get; set; }

    public string? Sort { get; set; }

    public bool? IsDefault { get; set; }

    public bool? Active { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? User { get; set; }

    public virtual ICollection<WebsiteSnippetFilter> WebsiteSnippetFilters { get; } = new List<WebsiteSnippetFilter>();

    public virtual ResUser? WriteU { get; set; }
}
