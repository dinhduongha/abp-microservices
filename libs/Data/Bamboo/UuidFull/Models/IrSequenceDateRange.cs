using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class IrSequenceDateRange
{
    public Guid Id { get; set; }

    public Guid? SequenceId { get; set; }

    public long? NumberNext { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public DateOnly? DateFrom { get; set; }

    public DateOnly? DateTo { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual IrSequence? Sequence { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
