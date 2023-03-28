using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class WebTourTour
{
    public Guid Id { get; set; }

    public Guid? UserId { get; set; }

    public string? Name { get; set; }

    public virtual ResUser? User { get; set; }
}
