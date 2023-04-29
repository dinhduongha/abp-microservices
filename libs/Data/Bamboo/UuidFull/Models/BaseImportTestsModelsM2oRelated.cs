using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class BaseImportTestsModelsM2oRelated
{
    public Guid Id { get; set; }

    public Guid? Value { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ICollection<BaseImportTestsModelsM2o> BaseImportTestsModelsM2os { get; } = new List<BaseImportTestsModelsM2o>();

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
