using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("ir_model_fields")]
[Index("CompleteName", Name = "ir_model_fields_complete_name_index")]
[Index("ModelId", Name = "ir_model_fields_model_id_index")]
[Index("Model", Name = "ir_model_fields_model_index")]
[Index("Name", Name = "ir_model_fields_name_index")]
[Index("Model", "Name", Name = "ir_model_fields_name_unique", IsUnique = true)]
[Index("State", Name = "ir_model_fields_state_index")]
[Index("WebsiteFormBlacklisted", Name = "ir_model_fields_website_form_blacklisted_index")]
public partial class IrModelField
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("relation_field_id")]
    public Guid? RelationFieldId { get; set; }

    [Column("model_id")]
    public Guid? ModelId { get; set; }

    [Column("related_field_id")]
    public Guid? RelatedFieldId { get; set; }

    [Column("size")]
    public long? Size { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("complete_name")]
    public string? CompleteName { get; set; }

    [Column("model")]
    public string? Model { get; set; }

    [Column("relation")]
    public string? Relation { get; set; }

    [Column("relation_field")]
    public string? RelationField { get; set; }

    [Column("ttype")]
    public string? Ttype { get; set; }

    [Column("related")]
    public string? Related { get; set; }

    [Column("state")]
    public string? State { get; set; }

    [Column("on_delete")]
    public string? OnDelete { get; set; }

    [Column("domain")]
    public string? Domain { get; set; }

    [Column("relation_table")]
    public string? RelationTable { get; set; }

    [Column("column1")]
    public string? Column1 { get; set; }

    [Column("column2")]
    public string? Column2 { get; set; }

    [Column("depends")]
    public string? Depends { get; set; }

    [Column("field_description", TypeName = "jsonb")]
    public string? FieldDescription { get; set; }

    [Column("help", TypeName = "jsonb")]
    public string? Help { get; set; }

    [Column("compute")]
    public string? Compute { get; set; }

    [Column("copied")]
    public bool? Copied { get; set; }

    [Column("required")]
    public bool? Required { get; set; }

    [Column("readonly")]
    public bool? Readonly { get; set; }

    [Column("index")]
    public bool? Index { get; set; }

    [Column("translate")]
    public bool? Translate { get; set; }

    [Column("group_expand")]
    public bool? GroupExpand { get; set; }

    [Column("selectable")]
    public bool? Selectable { get; set; }

    [Column("store")]
    public bool? Store { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [Column("tracking")]
    public long? Tracking { get; set; }

    [Column("website_form_blacklisted")]
    public bool? WebsiteFormBlacklisted { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("IrModelFieldCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [InverseProperty("Field")]
    public virtual ICollection<CrmLeadScoringFrequencyField> CrmLeadScoringFrequencyFields { get; } = new List<CrmLeadScoringFrequencyField>();

    [InverseProperty("RelatedField")]
    public virtual ICollection<IrModelField> InverseRelatedField { get; } = new List<IrModelField>();

    [InverseProperty("RelationFieldNavigation")]
    public virtual ICollection<IrModelField> InverseRelationFieldNavigation { get; } = new List<IrModelField>();

    [InverseProperty("LinkField")]
    public virtual ICollection<IrActServer> IrActServers { get; } = new List<IrActServer>();

    [InverseProperty("Field")]
    public virtual ICollection<IrDefault> IrDefaults { get; } = new List<IrDefault>();

    [InverseProperty("Field")]
    public virtual ICollection<IrModelFieldsSelection> IrModelFieldsSelections { get; } = new List<IrModelFieldsSelection>();

    [InverseProperty("WebsiteFormDefaultField")]
    public virtual ICollection<IrModel> IrModels { get; } = new List<IrModel>();

    [InverseProperty("Fields")]
    public virtual ICollection<IrProperty> IrProperties { get; } = new List<IrProperty>();

    [InverseProperty("Col1Navigation")]
    public virtual ICollection<IrServerObjectLine> IrServerObjectLines { get; } = new List<IrServerObjectLine>();

    [InverseProperty("FieldNavigation")]
    public virtual ICollection<MailTrackingValue> MailTrackingValues { get; } = new List<MailTrackingValue>();

    [ForeignKey("ModelId")]
    [InverseProperty("IrModelFields")]
    public virtual IrModel? ModelNavigation { get; set; }

    [ForeignKey("RelatedFieldId")]
    [InverseProperty("InverseRelatedField")]
    public virtual IrModelField? RelatedField { get; set; }

    [ForeignKey("RelationFieldId")]
    [InverseProperty("InverseRelationFieldNavigation")]
    public virtual IrModelField? RelationFieldNavigation { get; set; }

    [InverseProperty("Field")]
    public virtual ICollection<WebsiteSaleExtraField> WebsiteSaleExtraFields { get; } = new List<WebsiteSaleExtraField>();

    [ForeignKey("WriteUid")]
    [InverseProperty("IrModelFieldWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("FieldId")]
    [InverseProperty("Fields")]
    public virtual ICollection<ResGroup> Groups { get; } = new List<ResGroup>();
}
