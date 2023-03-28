using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class MailActivityType
{
    public long Id { get; set; }

    public long Sequence { get; set; }

    public Guid? CreatorId { get; set; }

    public long? DelayCount { get; set; }

    public long? TriggeredNextTypeId { get; set; }

    public Guid? DefaultUserId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? DelayUnit { get; set; }

    public string? DelayFrom { get; set; }

    public string? Icon { get; set; }

    public string? DecorationType { get; set; }

    public string? ResModel { get; set; }

    public string? ChainingType { get; set; }

    public string? Category { get; set; }

    public string? Name { get; set; }

    public string? Summary { get; set; }

    public string? DefaultNote { get; set; }

    public bool? Active { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    //public virtual ICollection<AccountJournal> AccountJournals { get; } = new List<AccountJournal>();

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? DefaultUser { get; set; }

    //public virtual ICollection<HrPlanActivityType> HrPlanActivityTypes { get; } = new List<HrPlanActivityType>();

    //public virtual ICollection<MailActivityType> InverseTriggeredNextType { get; } = new List<MailActivityType>();

    //public virtual ICollection<IrActServer> IrActServers { get; } = new List<IrActServer>();

    //public virtual ICollection<MailActivity> MailActivityActivityTypes { get; } = new List<MailActivity>();

    //public virtual ICollection<MailActivity> MailActivityPreviousActivityTypes { get; } = new List<MailActivity>();

    //public virtual ICollection<MailActivity> MailActivityRecommendedActivityTypes { get; } = new List<MailActivity>();

    //public virtual ICollection<MailComposeMessage> MailComposeMessages { get; } = new List<MailComposeMessage>();

    //public virtual ICollection<MailMessage> MailMessages { get; } = new List<MailMessage>();

    public virtual MailActivityType? TriggeredNextType { get; set; }

    public virtual ResUser? WriteU { get; set; }

    //public virtual ICollection<MailActivityType> Activities { get; } = new List<MailActivityType>();

    //public virtual ICollection<MailTemplate> MailTemplates { get; } = new List<MailTemplate>();

    //public virtual ICollection<MailActivityType> Recommendeds { get; } = new List<MailActivityType>();
}
