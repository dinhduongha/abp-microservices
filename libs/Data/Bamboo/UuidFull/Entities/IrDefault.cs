using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("ir_default")]
[Index("CompanyId", Name = "ir_default_company_id_index")]
[Index("FieldId", Name = "ir_default_field_id_index")]
[Index("UserId", Name = "ir_default_user_id_index")]
public partial class IrDefault
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("field_id")]
    public Guid? FieldId { get; set; }

    [Column("user_id")]
    public Guid? UserId { get; set; }

    [Column("company_id")]
    public Guid? CompanyId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("condition")]
    public string? Condition { get; set; }

    [Column("json_value")]
    public string? JsonValue { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CompanyId")]
    [InverseProperty("IrDefaults")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("IrDefaultCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("FieldId")]
    [InverseProperty("IrDefaults")]
    public virtual IrModelField? Field { get; set; }

    [ForeignKey("UserId")]
    [InverseProperty("IrDefaultUsers")]
    public virtual ResUser? User { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("IrDefaultWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
