using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("base_import_tests_models_m2o_related")]
public partial class BaseImportTestsModelsM2oRelated
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

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

    [InverseProperty("ValueNavigation")]
    public virtual ICollection<BaseImportTestsModelsM2o> BaseImportTestsModelsM2os { get; } = new List<BaseImportTestsModelsM2o>();

    [ForeignKey("CreateUid")]
    [InverseProperty("BaseImportTestsModelsM2oRelatedCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("BaseImportTestsModelsM2oRelatedWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
