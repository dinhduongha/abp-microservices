using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class IrActClient
{
    public Guid Id { get; set; }

    public Guid? BindingModelId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? Type { get; set; }

    public string? BindingType { get; set; }

    public string? BindingViewTypes { get; set; }

    public string? Name { get; set; }

    public string? Help { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public string? Tag { get; set; }

    public string? Target { get; set; }

    public string? ResModel { get; set; }

    public string? Context { get; set; }

    public byte[]? ParamsStore { get; set; }

    public virtual IrModel? BindingModel { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
