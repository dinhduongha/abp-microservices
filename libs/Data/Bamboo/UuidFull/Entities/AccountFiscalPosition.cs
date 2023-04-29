using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("account_fiscal_position")]
public partial class AccountFiscalPosition
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("sequence")]
    public long Sequence { get; set; }

    [Column("company_id")]
    public Guid? CompanyId { get; set; }

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

    [Column("foreign_vat")]
    public string? ForeignVat { get; set; }

    [Column("note", TypeName = "jsonb")]
    public string? Note { get; set; }

    [Column("active")]
    public bool? Active { get; set; }

    [Column("auto_apply")]
    public bool? AutoApply { get; set; }

    [Column("vat_required")]
    public bool? VatRequired { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [InverseProperty("Position")]
    public virtual ICollection<AccountFiscalPositionAccount> AccountFiscalPositionAccounts { get; } = new List<AccountFiscalPositionAccount>();

    [InverseProperty("AccountFiscalPosition")]
    public virtual ICollection<AccountFiscalPositionResCountryStateRel> AccountFiscalPositionResCountryStateRels { get; } = new List<AccountFiscalPositionResCountryStateRel>();

    [InverseProperty("Position")]
    public virtual ICollection<AccountFiscalPositionTax> AccountFiscalPositionTaxes { get; } = new List<AccountFiscalPositionTax>();

    [InverseProperty("FiscalPosition")]
    public virtual ICollection<AccountMove> AccountMoves { get; } = new List<AccountMove>();

    [InverseProperty("ForeignVatFiscalPosition")]
    public virtual ICollection<AccountReportExternalValue> AccountReportExternalValues { get; } = new List<AccountReportExternalValue>();

    [ForeignKey("CompanyId")]
    [InverseProperty("AccountFiscalPositions")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("AccountFiscalPositionCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [InverseProperty("DefaultFiscalPosition")]
    public virtual ICollection<PosConfig> PosConfigsNavigation { get; } = new List<PosConfig>();

    [InverseProperty("FiscalPosition")]
    public virtual ICollection<PosOrder> PosOrders { get; } = new List<PosOrder>();

    [InverseProperty("FiscalPosition")]
    public virtual ICollection<PurchaseOrder> PurchaseOrders { get; } = new List<PurchaseOrder>();

    [InverseProperty("PosDefaultFiscalPosition")]
    public virtual ICollection<ResConfigSetting> ResConfigSettingsNavigation { get; } = new List<ResConfigSetting>();

    [InverseProperty("FiscalPosition")]
    public virtual ICollection<SaleOrder> SaleOrders { get; } = new List<SaleOrder>();

    [ForeignKey("WriteUid")]
    [InverseProperty("AccountFiscalPositionWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("AccountFiscalPositionId")]
    [InverseProperty("AccountFiscalPositions")]
    public virtual ICollection<PosConfig> PosConfigs { get; } = new List<PosConfig>();

    [ForeignKey("AccountFiscalPositionId")]
    [InverseProperty("AccountFiscalPositions")]
    public virtual ICollection<ResConfigSetting> ResConfigSettings { get; } = new List<ResConfigSetting>();
}
