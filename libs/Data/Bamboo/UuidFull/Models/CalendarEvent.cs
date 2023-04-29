using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class CalendarEvent
{
    public Guid Id { get; set; }

    public Guid? MessageMainAttachmentId { get; set; }

    public Guid? UserId { get; set; }

    public Guid? VideocallChannelId { get; set; }

    public Guid? ResId { get; set; }

    public Guid? ResModelId { get; set; }

    public Guid? RecurrenceId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? Name { get; set; }

    public string? Location { get; set; }

    public string? VideocallLocation { get; set; }

    public string? AccessToken { get; set; }

    public string? Privacy { get; set; }

    public string? ShowAs { get; set; }

    public string? ResModel { get; set; }

    public DateOnly? StartDate { get; set; }

    public DateOnly? StopDate { get; set; }

    public string? Description { get; set; }

    public bool? Active { get; set; }

    public bool? Allday { get; set; }

    public bool? Recurrency { get; set; }

    public bool? FollowRecurrence { get; set; }

    public DateTime? Start { get; set; }

    public DateTime? Stop { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public double? Duration { get; set; }

    public Guid? OpportunityId { get; set; }

    public Guid? ApplicantId { get; set; }

    public virtual HrApplicant? Applicant { get; set; }

    public virtual ICollection<CalendarAttendee> CalendarAttendees { get; } = new List<CalendarAttendee>();

    public virtual ICollection<CalendarRecurrence> CalendarRecurrences { get; } = new List<CalendarRecurrence>();

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<HrLeave> HrLeaves { get; } = new List<HrLeave>();

    public virtual ICollection<MailActivity> MailActivities { get; } = new List<MailActivity>();

    public virtual ICollection<MeetingCategoryRel> MeetingCategoryRels { get; } = new List<MeetingCategoryRel>();

    public virtual IrAttachment? MessageMainAttachment { get; set; }

    public virtual CrmLead? Opportunity { get; set; }

    public virtual CalendarRecurrence? Recurrence { get; set; }

    public virtual IrModel? ResModelNavigation { get; set; }

    public virtual ResUser? User { get; set; }

    public virtual MailChannel? VideocallChannel { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<CalendarAlarm> CalendarAlarms { get; } = new List<CalendarAlarm>();

    public virtual ICollection<ResPartner> ResPartners { get; } = new List<ResPartner>();
}
