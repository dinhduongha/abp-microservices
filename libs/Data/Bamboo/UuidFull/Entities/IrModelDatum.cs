using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("ir_model_data")]
[Index("Model", "ResId", Name = "ir_model_data_model_res_id_index")]
[Index("Module", "Name", Name = "ir_model_data_module_name_uniq_index", IsUnique = true)]
public partial class IrModelDatum
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("res_id")]
    public Guid? ResId { get; set; }

    [Column("noupdate")]
    public bool? Noupdate { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("module")]
    public string? Module { get; set; }

    [Column("model")]
    public string? Model { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("IrModelDatumCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("IrModelDatumWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
