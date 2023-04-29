using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("res_country")]
[Index("Code", Name = "res_country_code_uniq", IsUnique = true)]
[Index("Name", Name = "res_country_name_uniq", IsUnique = true)]
public partial class ResCountry
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("address_view_id")]
    public Guid? AddressViewId { get; set; }

    [Column("currency_id")]
    public long? CurrencyId { get; set; }

    [Column("phone_code")]
    public long? PhoneCode { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("code")]
    public string? Code { get; set; }

    [Column("name_position")]
    public string? NamePosition { get; set; }

    [Column("name", TypeName = "jsonb")]
    public string? Name { get; set; }

    [Column("vat_label", TypeName = "jsonb")]
    public string? VatLabel { get; set; }

    [Column("address_format")]
    public string? AddressFormat { get; set; }

    [Column("state_required")]
    public bool? StateRequired { get; set; }

    [Column("zip_required")]
    public bool? ZipRequired { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("AddressViewId")]
    [InverseProperty("ResCountries")]
    public virtual IrUiView? AddressView { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("ResCountryCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("ResCountryWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
