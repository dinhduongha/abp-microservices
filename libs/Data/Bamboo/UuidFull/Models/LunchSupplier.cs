using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class LunchSupplier
{
    public Guid Id { get; set; }

    public Guid? MessageMainAttachmentId { get; set; }

    public Guid? PartnerId { get; set; }

    public Guid? CompanyId { get; set; }

    public Guid? ResponsibleId { get; set; }

    public Guid? CronId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? SendBy { get; set; }

    public string? Tz { get; set; }

    public string? Moment { get; set; }

    public string? Delivery { get; set; }

    public string? ToppingLabel1 { get; set; }

    public string? ToppingLabel2 { get; set; }

    public string? ToppingLabel3 { get; set; }

    public string? ToppingQuantity1 { get; set; }

    public string? ToppingQuantity2 { get; set; }

    public string? ToppingQuantity3 { get; set; }

    public DateOnly? RecurrencyEndDate { get; set; }

    public bool? Mon { get; set; }

    public bool? Tue { get; set; }

    public bool? Wed { get; set; }

    public bool? Thu { get; set; }

    public bool? Fri { get; set; }

    public bool? Sat { get; set; }

    public bool? Sun { get; set; }

    public bool? Active { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public double? AutomaticEmailTime { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual IrCron? Cron { get; set; }

    public virtual ICollection<LunchOrder> LunchOrders { get; } = new List<LunchOrder>();

    public virtual ICollection<LunchProduct> LunchProducts { get; } = new List<LunchProduct>();

    public virtual ICollection<LunchTopping> LunchToppings { get; } = new List<LunchTopping>();

    public virtual IrAttachment? MessageMainAttachment { get; set; }

    public virtual ResPartner? Partner { get; set; }

    public virtual ResUser? Responsible { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<LunchLocation> LunchLocations { get; } = new List<LunchLocation>();
}
