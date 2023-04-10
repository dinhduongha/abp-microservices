using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class IrModel
{
    public Guid Id { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Model { get; set; }

    public string? Order { get; set; }

    public string? State { get; set; }

    public string? Name { get; set; }

    public string? Info { get; set; }

    public bool? Transient { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public bool? IsMailThread { get; set; }

    public bool? IsMailActivity { get; set; }

    public bool? IsMailBlacklist { get; set; }

    public Guid? WebsiteFormDefaultFieldId { get; set; }

    public string? WebsiteFormLabel { get; set; }

    public string? WebsiteFormKey { get; set; }

    public bool? WebsiteFormAccess { get; set; }

    //public virtual ICollection<CalendarEvent> CalendarEvents { get; } = new List<CalendarEvent>();

    public virtual ResUser? CreateU { get; set; }

    //public virtual ICollection<FetchmailServer> FetchmailServers { get; } = new List<FetchmailServer>();

    //public virtual ICollection<IrActClient> IrActClients { get; } = new List<IrActClient>();

    //public virtual ICollection<IrActReportXml> IrActReportXmls { get; } = new List<IrActReportXml>();

    //public virtual ICollection<IrActServer> IrActServerBindingModels { get; } = new List<IrActServer>();

    //public virtual ICollection<IrActServer> IrActServerCrudModels { get; } = new List<IrActServer>();

    //public virtual ICollection<IrActServer> IrActServerModels { get; } = new List<IrActServer>();

    //public virtual ICollection<IrActUrl> IrActUrls { get; } = new List<IrActUrl>();

    //public virtual ICollection<IrActWindow> IrActWindows { get; } = new List<IrActWindow>();

    //public virtual ICollection<IrAction> IrActions { get; } = new List<IrAction>();

    //public virtual ICollection<IrModelAccess> IrModelAccesses { get; } = new List<IrModelAccess>();

    //public virtual ICollection<IrModelConstraint> IrModelConstraints { get; } = new List<IrModelConstraint>();

    //public virtual ICollection<IrModelField> IrModelFields { get; } = new List<IrModelField>();

    //public virtual ICollection<IrModelRelation> IrModelRelations { get; } = new List<IrModelRelation>();

    //public virtual ICollection<IrRule> IrRules { get; } = new List<IrRule>();

    //public virtual ICollection<MailActivity> MailActivities { get; } = new List<MailActivity>();

    //public virtual ICollection<MailAlias> MailAliasAliasModels { get; } = new List<MailAlias>();

    //public virtual ICollection<MailAlias> MailAliasAliasParentModels { get; } = new List<MailAlias>();

    //public virtual ICollection<MailTemplate> MailTemplates { get; } = new List<MailTemplate>();

    //public virtual ICollection<PaymentTransaction> PaymentTransactions { get; } = new List<PaymentTransaction>();

    //public virtual ICollection<PrivacyLookupWizardLine> PrivacyLookupWizardLines { get; } = new List<PrivacyLookupWizardLine>();

    //public virtual ICollection<RatingRating> RatingRatingParentResModelNavigations { get; } = new List<RatingRating>();

    //public virtual ICollection<RatingRating> RatingRatingResModelNavigations { get; } = new List<RatingRating>();

    //public virtual ICollection<SmsTemplate> SmsTemplates { get; } = new List<SmsTemplate>();

    public virtual IrModelField? WebsiteFormDefaultField { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
