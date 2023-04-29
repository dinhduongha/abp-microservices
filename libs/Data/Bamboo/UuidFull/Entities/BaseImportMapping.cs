using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("base_import_mapping")]
[Index("ResModel", Name = "base_import_mapping_res_model_index")]
public partial class BaseImportMapping
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("res_model")]
    public string? ResModel { get; set; }

    [Column("column_name")]
    public string? ColumnName { get; set; }

    [Column("field_name")]
    public string? FieldName { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("BaseImportMappingCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("BaseImportMappingWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
