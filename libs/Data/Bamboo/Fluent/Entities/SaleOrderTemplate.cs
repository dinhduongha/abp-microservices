using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class SaleOrderTemplate
{
    public Guid Id { get; set; }

    public Guid? TenantId { get; set; }

    public Guid? MailTemplateId { get; set; }

    public long? NumberOfDays { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Name { get; set; }

    public string? Note { get; set; }

    public bool? Active { get; set; }

    public bool? RequireSignature { get; set; }

    public bool? RequirePayment { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual MailTemplate? MailTemplate { get; set; }

    //public virtual ICollection<ResCompany> ResCompanies { get; } = new List<ResCompany>();

    //public virtual ICollection<SaleOrderTemplateLine> SaleOrderTemplateLines { get; } = new List<SaleOrderTemplateLine>();

    //public virtual ICollection<SaleOrderTemplateOption> SaleOrderTemplateOptions { get; } = new List<SaleOrderTemplateOption>();

    //public virtual ICollection<SaleOrder> SaleOrders { get; } = new List<SaleOrder>();

    public virtual ResUser? WriteU { get; set; }
}
