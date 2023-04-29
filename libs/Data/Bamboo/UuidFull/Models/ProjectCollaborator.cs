using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class ProjectCollaborator
{
    public Guid Id { get; set; }

    public Guid? ProjectId { get; set; }

    public Guid? PartnerId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResPartner? Partner { get; set; }

    public virtual ProjectProject? Project { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
