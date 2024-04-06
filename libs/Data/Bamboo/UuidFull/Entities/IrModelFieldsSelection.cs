﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("ir_model_fields_selection")]
[Index("FieldId", Name = "ir_model_fields_selection_field_id_index")]
[Index("FieldId", "Value", Name = "ir_model_fields_selection_selection_field_uniq", IsUnique = true)]
public partial class IrModelFieldsSelection
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("field_id")]
    public Guid? FieldId { get; set; }

    [Column("sequence")]
    public long Sequence { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("value")]
    public string? Value { get; set; }

    [Column("name", TypeName = "jsonb")]
    public string? Name { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("IrModelFieldsSelectionCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("FieldId")]
    [InverseProperty("IrModelFieldsSelections")]
    public virtual IrModelField? Field { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("IrModelFieldsSelectionWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}