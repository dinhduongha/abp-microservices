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

[Table("res_country_group")]
public partial class ResCountryGroup
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("name", TypeName = "jsonb")]
    public string? Name { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [InverseProperty("CountryGroup")]
    public virtual ICollection<AccountFiscalPositionTemplate> AccountFiscalPositionTemplates { get; } = new List<AccountFiscalPositionTemplate>();

    [InverseProperty("CountryGroup")]
    public virtual ICollection<AccountFiscalPosition> AccountFiscalPositions { get; } = new List<AccountFiscalPosition>();

    [ForeignKey("CreatorId")]
    [InverseProperty("ResCountryGroupCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("LastModifierId")]
    [InverseProperty("ResCountryGroupWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("ResCountryGroupId")]
    [InverseProperty("ResCountryGroups")]
    public virtual ICollection<ProductPricelist> Pricelists { get; } = new List<ProductPricelist>();

    [ForeignKey("ResCountryGroupId")]
    [InverseProperty("ResCountryGroups")]
    public virtual ICollection<ResCountry> ResCountries { get; } = new List<ResCountry>();
}
