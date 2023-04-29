﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Auditing;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Bamboo.Core.Entities;

[Table("base_import_tests_models_m2o_required")]
public partial class BaseImportTestsModelsM2oRequired
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("value")]
    public Guid? Value { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [ForeignKey("CreatorId")]
    //[InverseProperty("BaseImportTestsModelsM2oRequiredCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("Value")]
    //[InverseProperty("BaseImportTestsModelsM2oRequireds")]
    public virtual BaseImportTestsModelsM2oRequiredRelated? ValueNavigation { get; set; }

    [ForeignKey("LastModifierId")]
    //[InverseProperty("BaseImportTestsModelsM2oRequiredWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
