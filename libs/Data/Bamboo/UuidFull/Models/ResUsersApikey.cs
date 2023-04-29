using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class ResUsersApikey
{
    public Guid Id { get; set; }

    public string? Name { get; set; }

    public Guid? UserId { get; set; }

    public string? Scope { get; set; }

    public string? Index { get; set; }

    public string? Key { get; set; }

    public DateTime? CreateDate { get; set; }

    public virtual ResUser? User { get; set; }
}
