using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class BaseImportTestsModelsM2o
{
    public Guid Id { get; set; }

    public Guid? Value { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual BaseImportTestsModelsM2oRelated? ValueNavigation { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
