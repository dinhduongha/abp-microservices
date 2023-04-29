using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class ReportPaperformat
{
    public Guid Id { get; set; }

    public long? PageHeight { get; set; }

    public long? PageWidth { get; set; }

    public long? HeaderSpacing { get; set; }

    public long? Dpi { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? Name { get; set; }

    public string? Format { get; set; }

    public string? Orientation { get; set; }

    public bool? Default { get; set; }

    public bool? HeaderLine { get; set; }

    public bool? DisableShrinking { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public double? MarginTop { get; set; }

    public double? MarginBottom { get; set; }

    public double? MarginLeft { get; set; }

    public double? MarginRight { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
