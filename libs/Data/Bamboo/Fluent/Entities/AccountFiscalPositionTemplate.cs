using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class AccountFiscalPositionTemplate
{
    public Guid Id { get; set; }

    public long Sequence { get; set; }

    public Guid? ChartTemplateId { get; set; }

    public long? CountryId { get; set; }

    public long? CountryGroupId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Name { get; set; }

    public string? ZipFrom { get; set; }

    public string? ZipTo { get; set; }

    public string? Note { get; set; }

    public bool? AutoApply { get; set; }

    public bool? VatRequired { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    //public virtual ICollection<AccountFiscalPositionAccountTemplate> AccountFiscalPositionAccountTemplates { get; } = new List<AccountFiscalPositionAccountTemplate>();

    //public virtual ICollection<AccountFiscalPositionTaxTemplate> AccountFiscalPositionTaxTemplates { get; } = new List<AccountFiscalPositionTaxTemplate>();

    public virtual AccountChartTemplate? ChartTemplate { get; set; }

    public virtual ResCountry? Country { get; set; }

    public virtual ResCountryGroup? CountryGroup { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }

    //public virtual ICollection<ResCountryState> ResCountryStates { get; } = new List<ResCountryState>();
}
