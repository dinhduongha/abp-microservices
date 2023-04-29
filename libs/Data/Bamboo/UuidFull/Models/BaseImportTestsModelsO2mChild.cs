using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class BaseImportTestsModelsO2mChild
{
    public Guid Id { get; set; }

    public Guid? ParentId { get; set; }

    public Guid? Value { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual BaseImportTestsModelsO2m? Parent { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
