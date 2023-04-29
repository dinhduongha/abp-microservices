﻿using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class ProjectProjectStage
{
    public Guid Id { get; set; }

    public long Sequence { get; set; }

    public Guid? MailTemplateId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? Name { get; set; }

    public bool? Active { get; set; }

    public bool? Fold { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public Guid? SmsTemplateId { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual MailTemplate? MailTemplate { get; set; }

    public virtual SmsTemplate? SmsTemplate { get; set; }

    public virtual ResUser? WriteU { get; set; }
}