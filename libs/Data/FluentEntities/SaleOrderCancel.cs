using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class SaleOrderCancel
{
    public Guid Id { get; set; }

    public Guid? TemplateId { get; set; }

    public Guid? AuthorId { get; set; }

    public Guid? OrderId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Lang { get; set; }

    public string? Subject { get; set; }

    public string? EmailFrom { get; set; }

    public string? Body { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResPartner? Author { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual SaleOrder? Order { get; set; }

    public virtual MailTemplate? Template { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
