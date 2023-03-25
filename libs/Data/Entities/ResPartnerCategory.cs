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

[Table("res_partner_category")]
[Index("ParentId", Name = "res_partner_category_parent_id_index")]
[Index("ParentPath", Name = "res_partner_category_parent_path_index")]
public partial class ResPartnerCategory
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("color")]
    public long? Color { get; set; }

    [Column("parent_id")]
    public long? ParentId { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("parent_path")]
    public string? ParentPath { get; set; }

    [Column("name", TypeName = "jsonb")]
    public string? Name { get; set; }

    [Column("active")]
    public bool? Active { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [InverseProperty("PartnerCategory")]
    [NotMapped]
    public virtual ICollection<AccountAnalyticDistributionModel> AccountAnalyticDistributionModels { get; } = new List<AccountAnalyticDistributionModel>();

    [ForeignKey("CreatorId")]
    [InverseProperty("ResPartnerCategoryCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [InverseProperty("Parent")]
    [NotMapped]
    public virtual ICollection<ResPartnerCategory> InverseParent { get; } = new List<ResPartnerCategory>();

    [ForeignKey("ParentId")]
    [InverseProperty("InverseParent")]
    public virtual ResPartnerCategory? Parent { get; set; }

    [ForeignKey("LastModifierId")]
    [InverseProperty("ResPartnerCategoryWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("ResPartnerCategoryId")]
    [InverseProperty("ResPartnerCategories")]
    [NotMapped]
    public virtual ICollection<AccountReconcileModelTemplate> AccountReconcileModelTemplates { get; } = new List<AccountReconcileModelTemplate>();

    [ForeignKey("ResPartnerCategoryId")]
    [InverseProperty("ResPartnerCategories")]
    [NotMapped]
    public virtual ICollection<AccountReconcileModel> AccountReconcileModels { get; } = new List<AccountReconcileModel>();

    [ForeignKey("CategoryId")]
    [InverseProperty("Categories")]
    [NotMapped]
    public virtual ICollection<ResPartner> Partners { get; } = new List<ResPartner>();
}