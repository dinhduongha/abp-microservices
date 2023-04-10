using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class AccountFiscalPosition
{
    public Guid Id { get; set; }

    public long Sequence { get; set; }

    public Guid? TenantId { get; set; }

    public long? CountryId { get; set; }

    public long? CountryGroupId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Name { get; set; }

    public string? ZipFrom { get; set; }

    public string? ZipTo { get; set; }

    public string? ForeignVat { get; set; }

    public string? Note { get; set; }

    public bool? Active { get; set; }

    public bool? AutoApply { get; set; }

    public bool? VatRequired { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    //public virtual ICollection<AccountFiscalPositionAccount> AccountFiscalPositionAccounts { get; } = new List<AccountFiscalPositionAccount>();

    //public virtual ICollection<AccountFiscalPositionTax> AccountFiscalPositionTaxes { get; } = new List<AccountFiscalPositionTax>();

    //public virtual ICollection<AccountMove> AccountMoves { get; } = new List<AccountMove>();

    //public virtual ICollection<AccountReportExternalValue> AccountReportExternalValues { get; } = new List<AccountReportExternalValue>();

    public virtual ResCompany? Company { get; set; }

    public virtual ResCountry? Country { get; set; }

    public virtual ResCountryGroup? CountryGroup { get; set; }

    public virtual ResUser? CreateU { get; set; }

    //public virtual ICollection<PosConfig> PosConfigsNavigation { get; } = new List<PosConfig>();

    //public virtual ICollection<PosOrder> PosOrders { get; } = new List<PosOrder>();

    //public virtual ICollection<PurchaseOrder> PurchaseOrders { get; } = new List<PurchaseOrder>();

    //public virtual ICollection<ResConfigSetting> ResConfigSettingsNavigation { get; } = new List<ResConfigSetting>();

    //public virtual ICollection<SaleOrder> SaleOrders { get; } = new List<SaleOrder>();

    public virtual ResUser? WriteU { get; set; }

    //public virtual ICollection<PosConfig> PosConfigs { get; } = new List<PosConfig>();

    //public virtual ICollection<ResConfigSetting> ResConfigSettings { get; } = new List<ResConfigSetting>();

    //public virtual ICollection<ResCountryState> ResCountryStates { get; } = new List<ResCountryState>();
}
