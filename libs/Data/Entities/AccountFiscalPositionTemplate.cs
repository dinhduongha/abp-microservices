using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Auditing;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Bamboo.Core.Entities;

[Table("account_fiscal_position_template")]
public partial class AccountFiscalPositionTemplate
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("sequence")]
    public long Sequence { get; set; }

    [Column("chart_template_id")]
    public Guid? ChartTemplateId { get; set; }

    [Column("country_id")]
    public long? CountryId { get; set; }

    [Column("country_group_id")]
    public long? CountryGroupId { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("name", TypeName = "jsonb")]
    public string? Name { get; set; }

    [Column("zip_from")]
    public string? ZipFrom { get; set; }

    [Column("zip_to")]
    public string? ZipTo { get; set; }

    [Column("note", TypeName = "jsonb")]
    public string? Note { get; set; }

    [Column("auto_apply")]
    public bool? AutoApply { get; set; }

    [Column("vat_required")]
    public bool? VatRequired { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [ForeignKey("ChartTemplateId")]
    [InverseProperty("AccountFiscalPositionTemplates")]
    public virtual AccountChartTemplate? ChartTemplate { get; set; }

    [ForeignKey("CountryId")]
    [InverseProperty("AccountFiscalPositionTemplates")]
    public virtual ResCountry? Country { get; set; }

    [ForeignKey("CountryGroupId")]
    [InverseProperty("AccountFiscalPositionTemplates")]
    public virtual ResCountryGroup? CountryGroup { get; set; }

    [ForeignKey("CreatorId")]
    [InverseProperty("AccountFiscalPositionTemplateCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("LastModifierId")]
    [InverseProperty("AccountFiscalPositionTemplateWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [InverseProperty("Position")]
    [NotMapped]
    public virtual ICollection<AccountFiscalPositionAccountTemplate> AccountFiscalPositionAccountTemplates { get; } = new List<AccountFiscalPositionAccountTemplate>();

    [InverseProperty("Position")]
    [NotMapped]
    public virtual ICollection<AccountFiscalPositionTaxTemplate> AccountFiscalPositionTaxTemplates { get; } = new List<AccountFiscalPositionTaxTemplate>();

    [ForeignKey("AccountFiscalPositionTemplateId")]
    [InverseProperty("AccountFiscalPositionTemplates")]
    [NotMapped]
    public virtual ICollection<ResCountryState> ResCountryStates { get; } = new List<ResCountryState>();
}
