using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class WebsiteLangRel
{
    public Guid WebsiteId { get; set; }

    public long LangId { get; set; }

    public virtual Website Website { get; set; } = null!;
}
