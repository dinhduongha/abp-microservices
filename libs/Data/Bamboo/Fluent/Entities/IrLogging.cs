using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class IrLogging
{
    public Guid Id { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Name { get; set; }

    public string? Type { get; set; }

    public string? Dbname { get; set; }

    public string? Level { get; set; }

    public string? Path { get; set; }

    public string? Func { get; set; }

    public string? Line { get; set; }

    public string? Message { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }
}
