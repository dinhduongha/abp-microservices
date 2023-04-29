using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class PaymentProvider
{
    public Guid Id { get; set; }

    public long? Sequence { get; set; }

    public Guid? CompanyId { get; set; }

    public Guid? RedirectFormViewId { get; set; }

    public Guid? InlineFormViewId { get; set; }

    public Guid? TokenInlineFormViewId { get; set; }

    public Guid? ExpressCheckoutFormViewId { get; set; }

    public long? Color { get; set; }

    public Guid? ModuleId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? Code { get; set; }

    public string? State { get; set; }

    public string? ModuleState { get; set; }

    public string? Name { get; set; }

    public string? DisplayAs { get; set; }

    public string? PreMsg { get; set; }

    public string? PendingMsg { get; set; }

    public string? AuthMsg { get; set; }

    public string? DoneMsg { get; set; }

    public string? CancelMsg { get; set; }

    public decimal? MaximumAmount { get; set; }

    public bool? IsPublished { get; set; }

    public bool? AllowTokenization { get; set; }

    public bool? CaptureManually { get; set; }

    public bool? AllowExpressCheckout { get; set; }

    public bool? FeesActive { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public double? FeesDomFixed { get; set; }

    public double? FeesDomVar { get; set; }

    public double? FeesIntFixed { get; set; }

    public double? FeesIntVar { get; set; }

    public string? SoReferenceType { get; set; }

    public Guid? WebsiteId { get; set; }

    public virtual ICollection<AccountPaymentMethodLine> AccountPaymentMethodLines { get; } = new List<AccountPaymentMethodLine>();

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual IrUiView? ExpressCheckoutFormView { get; set; }

    public virtual IrUiView? InlineFormView { get; set; }

    public virtual IrModuleModule? Module { get; set; }

    public virtual ICollection<PaymentCountryRel> PaymentCountryRels { get; } = new List<PaymentCountryRel>();

    public virtual ICollection<PaymentToken> PaymentTokens { get; } = new List<PaymentToken>();

    public virtual ICollection<PaymentTransaction> PaymentTransactions { get; } = new List<PaymentTransaction>();

    public virtual IrUiView? RedirectFormView { get; set; }

    public virtual IrUiView? TokenInlineFormView { get; set; }

    public virtual Website? Website { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<PaymentIcon> PaymentIcons { get; } = new List<PaymentIcon>();
}
