using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class AccountFiscalPositionTemplate
{
    public Guid Id { get; set; }

    public long Sequence { get; set; }

    public Guid? ChartTemplateId { get; set; }

    public long? CountryId { get; set; }

    public long? CountryGroupId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? Name { get; set; }

    public string? ZipFrom { get; set; }

    public string? ZipTo { get; set; }

    public string? Note { get; set; }

    public bool? AutoApply { get; set; }

    public bool? VatRequired { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ICollection<AccountFiscalPositionAccountTemplate> AccountFiscalPositionAccountTemplates { get; } = new List<AccountFiscalPositionAccountTemplate>();

    public virtual ICollection<AccountFiscalPositionTaxTemplate> AccountFiscalPositionTaxTemplates { get; } = new List<AccountFiscalPositionTaxTemplate>();

    public virtual ICollection<AccountFiscalPositionTemplateResCountryStateRel> AccountFiscalPositionTemplateResCountryStateRels { get; } = new List<AccountFiscalPositionTemplateResCountryStateRel>();

    public virtual AccountChartTemplate? ChartTemplate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
