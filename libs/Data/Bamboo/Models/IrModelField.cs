using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class IrModelField
{
    public Guid Id { get; set; }

    public Guid? RelationFieldId { get; set; }

    public Guid? ModelId { get; set; }

    public Guid? RelatedFieldId { get; set; }

    public long? Size { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Name { get; set; }

    public string? CompleteName { get; set; }

    public string? Model { get; set; }

    public string? Relation { get; set; }

    public string? RelationField { get; set; }

    public string? Ttype { get; set; }

    public string? Related { get; set; }

    public string? State { get; set; }

    public string? OnDelete { get; set; }

    public string? Domain { get; set; }

    public string? RelationTable { get; set; }

    public string? Column1 { get; set; }

    public string? Column2 { get; set; }

    public string? Depends { get; set; }

    public string? FieldDescription { get; set; }

    public string? Help { get; set; }

    public string? Compute { get; set; }

    public bool? Copied { get; set; }

    public bool? Required { get; set; }

    public bool? Readonly { get; set; }

    public bool? Index { get; set; }

    public bool? Translate { get; set; }

    public bool? GroupExpand { get; set; }

    public bool? Selectable { get; set; }

    public bool? Store { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public long? Tracking { get; set; }

    public bool? WebsiteFormBlacklisted { get; set; }

    public virtual ResUser? CreateU { get; set; }

    //public virtual ICollection<CrmLeadScoringFrequencyField> CrmLeadScoringFrequencyFields { get; } = new List<CrmLeadScoringFrequencyField>();

    //public virtual ICollection<IrModelField> InverseRelatedField { get; } = new List<IrModelField>();

    //public virtual ICollection<IrModelField> InverseRelationFieldNavigation { get; } = new List<IrModelField>();

    //public virtual ICollection<IrActServer> IrActServers { get; } = new List<IrActServer>();

    //public virtual ICollection<IrDefault> IrDefaults { get; } = new List<IrDefault>();

    //public virtual ICollection<IrModelFieldsSelection> IrModelFieldsSelections { get; } = new List<IrModelFieldsSelection>();

    //public virtual ICollection<IrModel> IrModels { get; } = new List<IrModel>();

    //public virtual ICollection<IrProperty> IrProperties { get; } = new List<IrProperty>();

    //public virtual ICollection<IrServerObjectLine> IrServerObjectLines { get; } = new List<IrServerObjectLine>();

    //public virtual ICollection<MailTrackingValue> MailTrackingValues { get; } = new List<MailTrackingValue>();

    public virtual IrModel? ModelNavigation { get; set; }

    public virtual IrModelField? RelatedField { get; set; }

    public virtual IrModelField? RelationFieldNavigation { get; set; }

    //public virtual ICollection<WebsiteSaleExtraField> WebsiteSaleExtraFields { get; } = new List<WebsiteSaleExtraField>();

    public virtual ResUser? WriteU { get; set; }

    //public virtual ICollection<ResGroup> Groups { get; } = new List<ResGroup>();
}
