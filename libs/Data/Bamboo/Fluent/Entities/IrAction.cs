using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class IrAction
{
    public Guid Id { get; set; }

    public Guid? BindingModelId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Type { get; set; }

    public string? BindingType { get; set; }

    public string? BindingViewTypes { get; set; }

    public string? Name { get; set; }

    public string? Help { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual IrModel? BindingModel { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
