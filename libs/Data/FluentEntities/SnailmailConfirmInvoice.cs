using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class SnailmailConfirmInvoice
{
    public Guid Id { get; set; }

    public Guid? InvoiceSendId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? ModelName { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual AccountInvoiceSend? InvoiceSend { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
