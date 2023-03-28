using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class BaseImportTestsModelsM2oRequiredRelated
{
    public Guid Id { get; set; }

    public Guid? Value { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    //public virtual ICollection<BaseImportTestsModelsM2oRequired> BaseImportTestsModelsM2oRequireds { get; } = new List<BaseImportTestsModelsM2oRequired>();

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
