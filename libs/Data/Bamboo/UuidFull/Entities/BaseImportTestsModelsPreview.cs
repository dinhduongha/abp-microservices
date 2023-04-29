using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("base_import_tests_models_preview")]
public partial class BaseImportTestsModelsPreview
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("somevalue")]
    public Guid? Somevalue { get; set; }

    [Column("othervalue")]
    public Guid? Othervalue { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("BaseImportTestsModelsPreviewCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("BaseImportTestsModelsPreviewWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
