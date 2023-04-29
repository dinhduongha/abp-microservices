﻿using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class NoteTag
{
    public Guid Id { get; set; }

    public long? Color { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? Name { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<NoteNote> Notes { get; } = new List<NoteNote>();
}
