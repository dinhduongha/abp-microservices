using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class IrModelDatum
{
    public Guid Id { get; set; }

    public Guid? CreateUid { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public Guid? WriteUid { get; set; }

    public Guid? ResId { get; set; }

    public bool? Noupdate { get; set; }

    public string? Name { get; set; }

    public string? Module { get; set; }

    public string? Model { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
