﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("payment_provider_onboarding_wizard")]
public partial class PaymentProviderOnboardingWizard
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("payment_method")]
    public string? PaymentMethod { get; set; }

    [Column("paypal_user_type")]
    public string? PaypalUserType { get; set; }

    [Column("paypal_email_account")]
    public string? PaypalEmailAccount { get; set; }

    [Column("paypal_seller_account")]
    public string? PaypalSellerAccount { get; set; }

    [Column("paypal_pdt_token")]
    public string? PaypalPdtToken { get; set; }

    [Column("manual_name")]
    public string? ManualName { get; set; }

    [Column("journal_name")]
    public string? JournalName { get; set; }

    [Column("acc_number")]
    public string? AccNumber { get; set; }

    [Column("manual_post_msg")]
    public string? ManualPostMsg { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("PaymentProviderOnboardingWizardCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("PaymentProviderOnboardingWizardWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}