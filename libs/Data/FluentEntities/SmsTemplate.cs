using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class SmsTemplate
{
    public Guid Id { get; set; }

    public Guid? ModelId { get; set; }

    public Guid? SidebarActionId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? TemplateFs { get; set; }

    public string? Lang { get; set; }

    public string? Model { get; set; }

    public string? Name { get; set; }

    public string? Body { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    //public virtual ICollection<CalendarAlarm> CalendarAlarms { get; } = new List<CalendarAlarm>();

    public virtual ResUser? CreateU { get; set; }

    //public virtual ICollection<IrActServer> IrActServers { get; } = new List<IrActServer>();

    public virtual IrModel? ModelNavigation { get; set; }

    //public virtual ICollection<ProjectProjectStage> ProjectProjectStages { get; } = new List<ProjectProjectStage>();

    //public virtual ICollection<ProjectTaskType> ProjectTaskTypes { get; } = new List<ProjectTaskType>();

    //public virtual ICollection<ResCompany> ResCompanies { get; } = new List<ResCompany>();

    public virtual IrActWindow? SidebarAction { get; set; }

    //public virtual ICollection<SmsComposer> SmsComposers { get; } = new List<SmsComposer>();

    //public virtual ICollection<SmsTemplatePreview> SmsTemplatePreviews { get; } = new List<SmsTemplatePreview>();

    public virtual ResUser? WriteU { get; set; }

    //public virtual ICollection<SmsTemplateReset> SmsTemplateResets { get; } = new List<SmsTemplateReset>();
}
