﻿using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class BaseImportTestsModelsPreview
{
    public Guid Id { get; set; }

    public Guid? Somevalue { get; set; }

    public Guid? Othervalue { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? Name { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
