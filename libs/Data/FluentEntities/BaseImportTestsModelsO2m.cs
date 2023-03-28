using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class BaseImportTestsModelsO2m
{
    public Guid Id { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Name { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    //public virtual ICollection<BaseImportTestsModelsO2mChild> BaseImportTestsModelsO2mChildren { get; } = new List<BaseImportTestsModelsO2mChild>();

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
