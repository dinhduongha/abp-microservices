using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class IrLogging
{
    public Guid Id { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? Name { get; set; }

    public string? Type { get; set; }

    public string? Dbname { get; set; }

    public string? Level { get; set; }

    public string? Path { get; set; }

    public string? Func { get; set; }

    public string? Line { get; set; }

    public string? Message { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }
}
