using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class ResLang
{
    public Guid Id { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? Name { get; set; }

    public string? Code { get; set; }

    public string? IsoCode { get; set; }

    public string? UrlCode { get; set; }

    public string? Direction { get; set; }

    public string? DateFormat { get; set; }

    public string? TimeFormat { get; set; }

    public string? WeekStart { get; set; }

    public string? Grouping { get; set; }

    public string? DecimalPoint { get; set; }

    public string? ThousandsSep { get; set; }

    public bool? Active { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
