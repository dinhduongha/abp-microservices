using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("base_import_tests_models_o2m_child")]
public partial class BaseImportTestsModelsO2mChild
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("parent_id")]
    public Guid? ParentId { get; set; }

    [Column("value")]
    public Guid? Value { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("BaseImportTestsModelsO2mChildCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("ParentId")]
    [InverseProperty("BaseImportTestsModelsO2mChildren")]
    public virtual BaseImportTestsModelsO2m? Parent { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("BaseImportTestsModelsO2mChildWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
