using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class CrmStage
{
    public Guid Id { get; set; }

    public long Sequence { get; set; }

    public Guid? TeamId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? Name { get; set; }

    public string? Requirements { get; set; }

    public bool? IsWon { get; set; }

    public bool? Fold { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual CrmTeam? Team { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
