using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class NoteStageRel
{
    public Guid NoteId { get; set; }

    public long StageId { get; set; }

    public virtual NoteNote Note { get; set; } = null!;
}
