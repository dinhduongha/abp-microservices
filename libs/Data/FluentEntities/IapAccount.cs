using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class IapAccount
{
    public Guid Id { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? ServiceName { get; set; }

    public string? AccountToken { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }

    //public virtual ICollection<ResCompany> ResCompanies { get; } = new List<ResCompany>();
}
