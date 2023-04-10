using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class HrDepartureReason
{
    public long Id { get; set; }

    public long Sequence { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Name { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResUser? CreateU { get; set; }

    //public virtual ICollection<HrDepartureWizard> HrDepartureWizards { get; } = new List<HrDepartureWizard>();

    //public virtual ICollection<HrEmployee> HrEmployees { get; } = new List<HrEmployee>();

    public virtual ResUser? WriteU { get; set; }
}
