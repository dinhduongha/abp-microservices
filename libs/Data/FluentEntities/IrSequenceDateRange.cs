using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class IrSequenceDateRange
{
    public Guid Id { get; set; }

    public Guid? SequenceId { get; set; }

    public long? NumberNext { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public DateOnly? DateFrom { get; set; }

    public DateOnly? DateTo { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual IrSequence? Sequence { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
