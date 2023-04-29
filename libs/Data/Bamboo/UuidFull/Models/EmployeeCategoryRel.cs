using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class EmployeeCategoryRel
{
    public Guid EmpId { get; set; }

    public long CategoryId { get; set; }

    public virtual HrEmployee Emp { get; set; } = null!;
}
