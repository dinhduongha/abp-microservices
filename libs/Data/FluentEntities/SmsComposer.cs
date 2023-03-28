using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class SmsComposer
{
    public Guid Id { get; set; }

    public Guid? ResId { get; set; }

    public Guid? TemplateId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? CompositionMode { get; set; }

    public string? ResModel { get; set; }

    public string? ResIds { get; set; }

    public string? RecipientSingleNumberItf { get; set; }

    public string? NumberFieldName { get; set; }

    public string? Numbers { get; set; }

    public string? Body { get; set; }

    public bool? MassKeepLog { get; set; }

    public bool? MassForceSend { get; set; }

    public bool? MassUseBlacklist { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual SmsTemplate? Template { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
