using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class WebEditorConverterTest
{
    public Guid Id { get; set; }

    public long? Integer { get; set; }

    public Guid? Many2one { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? Char { get; set; }

    public string? SelectionStr { get; set; }

    public DateOnly? Date { get; set; }

    public string? Html { get; set; }

    public string? Text { get; set; }

    public decimal? Numeric { get; set; }

    public DateTime? Datetime { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public double? Float { get; set; }

    public byte[]? Binary { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual WebEditorConverterTestSub? Many2oneNavigation { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
