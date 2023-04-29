using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class ProjectShareWizard
{
    public Guid Id { get; set; }

    public Guid? ResId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? ResModel { get; set; }

    public string? AccessMode { get; set; }

    public string? Note { get; set; }

    public bool? DisplayAccessMode { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<ResPartner> ResPartners { get; } = new List<ResPartner>();
}
