using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class HrRecruitmentSource
{
    public Guid Id { get; set; }

    public Guid? SourceId { get; set; }

    public Guid? JobId { get; set; }

    public Guid? AliasId { get; set; }

    public Guid? MediumId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual MailAlias? Alias { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual HrJob? Job { get; set; }

    public virtual UtmMedium? Medium { get; set; }

    public virtual UtmSource? Source { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
