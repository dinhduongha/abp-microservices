using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class BaseImportTestsModelsM2oRelated
{
    public Guid Id { get; set; }

    public Guid? Value { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    //public virtual ICollection<BaseImportTestsModelsM2o> BaseImportTestsModelsM2os { get; } = new List<BaseImportTestsModelsM2o>();

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
