using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class ReportPaperformat
{
    public long Id { get; set; }

    public long? PageHeight { get; set; }

    public long? PageWidth { get; set; }

    public long? HeaderSpacing { get; set; }

    public long? Dpi { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Name { get; set; }

    public string? Format { get; set; }

    public string? Orientation { get; set; }

    public bool? Default { get; set; }

    public bool? HeaderLine { get; set; }

    public bool? DisableShrinking { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public double? MarginTop { get; set; }

    public double? MarginBottom { get; set; }

    public double? MarginLeft { get; set; }

    public double? MarginRight { get; set; }

    public virtual ResUser? CreateU { get; set; }

    //public virtual ICollection<IrActReportXml> IrActReportXmls { get; } = new List<IrActReportXml>();

    //public virtual ICollection<ResCompany> ResCompanies { get; } = new List<ResCompany>();

    public virtual ResUser? WriteU { get; set; }
}
