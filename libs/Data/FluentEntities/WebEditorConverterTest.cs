using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class WebEditorConverterTest
{
    public Guid Id { get; set; }

    public long? Integer { get; set; }

    public Guid? Many2one { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Char { get; set; }

    public string? SelectionStr { get; set; }

    public DateOnly? Date { get; set; }

    public string? Html { get; set; }

    public string? Text { get; set; }

    public decimal? Numeric { get; set; }

    public DateTime? Datetime { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public double? Float { get; set; }

    public byte[]? Binary { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual WebEditorConverterTestSub? Many2oneNavigation { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
