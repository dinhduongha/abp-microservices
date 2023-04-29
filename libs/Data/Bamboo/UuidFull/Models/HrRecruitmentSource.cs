using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class HrRecruitmentSource
{
    public Guid Id { get; set; }

    public Guid? SourceId { get; set; }

    public Guid? JobId { get; set; }

    public Guid? AliasId { get; set; }

    public Guid? MediumId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual MailAlias? Alias { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual HrJob? Job { get; set; }

    public virtual UtmMedium? Medium { get; set; }

    public virtual UtmSource? Source { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
