using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class HrWorkLocation
{
    public Guid Id { get; set; }

    public Guid? CompanyId { get; set; }

    public Guid? AddressId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? Name { get; set; }

    public string? LocationNumber { get; set; }

    public bool? Active { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResPartner? Address { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<HrEmployee> HrEmployees { get; } = new List<HrEmployee>();

    public virtual ResUser? WriteU { get; set; }
}
