using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class IrProfile
{
    public Guid Id { get; set; }

    public long? SqlCount { get; set; }

    public long? EntryCount { get; set; }

    public string? Session { get; set; }

    public string? Name { get; set; }

    public string? InitStackTrace { get; set; }

    public string? Sql { get; set; }

    public string? TracesAsync { get; set; }

    public string? TracesSync { get; set; }

    public string? Qweb { get; set; }

    public DateTime? CreationTime { get; set; }

    public double? Duration { get; set; }
}
