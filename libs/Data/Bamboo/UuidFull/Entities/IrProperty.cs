using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("ir_property")]
[Index("CompanyId", Name = "ir_property_company_id_index")]
[Index("Name", Name = "ir_property_name_index")]
[Index("ResId", Name = "ir_property_res_id_index")]
[Index("Type", Name = "ir_property_type_index")]
public partial class IrProperty
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("company_id")]
    public Guid? CompanyId { get; set; }

    [Column("fields_id")]
    public Guid? FieldsId { get; set; }

    [Column("value_integer")]
    public long? ValueInteger { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("res_id")]
    public string? ResId { get; set; }

    [Column("value_reference")]
    public string? ValueReference { get; set; }

    [Column("type")]
    public string? Type { get; set; }

    [Column("value_text")]
    public string? ValueText { get; set; }

    [Column("value_datetime", TypeName = "timestamp without time zone")]
    public DateTime? ValueDatetime { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [Column("value_float")]
    public double? ValueFloat { get; set; }

    [Column("value_binary")]
    public byte[]? ValueBinary { get; set; }

    [ForeignKey("CompanyId")]
    [InverseProperty("IrProperties")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("IrPropertyCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("FieldsId")]
    [InverseProperty("IrProperties")]
    public virtual IrModelField? Fields { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("IrPropertyWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
