using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

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
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

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
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [InverseProperty("Position")]
    public virtual ICollection<AccountFiscalPositionAccountTemplate> AccountFiscalPositionAccountTemplates { get; } = new List<AccountFiscalPositionAccountTemplate>();

    [InverseProperty("Position")]
    public virtual ICollection<AccountFiscalPositionTaxTemplate> AccountFiscalPositionTaxTemplates { get; } = new List<AccountFiscalPositionTaxTemplate>();

    [InverseProperty("AccountFiscalPositionTemplate")]
    public virtual ICollection<AccountFiscalPositionTemplateResCountryStateRel> AccountFiscalPositionTemplateResCountryStateRels { get; } = new List<AccountFiscalPositionTemplateResCountryStateRel>();

    [ForeignKey("ChartTemplateId")]
    [InverseProperty("AccountFiscalPositionTemplates")]
    public virtual AccountChartTemplate? ChartTemplate { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("AccountFiscalPositionTemplateCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("AccountFiscalPositionTemplateWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
