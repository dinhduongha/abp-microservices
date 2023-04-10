using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class MailMessageSubtype
{
    public long Id { get; set; }

    public long? ParentId { get; set; }

    public long Sequence { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? RelationField { get; set; }

    public string? ResModel { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public bool? Internal { get; set; }

    public bool? Default { get; set; }

    public bool? Hidden { get; set; }

    public bool? TrackRecipients { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResUser? CreateU { get; set; }

    //public virtual ICollection<HrLeaveType> HrLeaveTypeAllocationNotifSubtypes { get; } = new List<HrLeaveType>();

    //public virtual ICollection<HrLeaveType> HrLeaveTypeLeaveNotifSubtypes { get; } = new List<HrLeaveType>();

    //public virtual ICollection<MailMessageSubtype> InverseParent { get; } = new List<MailMessageSubtype>();

    //public virtual ICollection<MailComposeMessage> MailComposeMessages { get; } = new List<MailComposeMessage>();

    //public virtual ICollection<MailMessage> MailMessages { get; } = new List<MailMessage>();

    public virtual MailMessageSubtype? Parent { get; set; }

    public virtual ResUser? WriteU { get; set; }

    //public virtual ICollection<MailFollower> MailFollowers { get; } = new List<MailFollower>();
}
