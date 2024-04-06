﻿using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class PosMakePayment
{
    public Guid Id { get; set; }

    public Guid? ConfigId { get; set; }

    public long? PaymentMethodId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? PaymentName { get; set; }

    public decimal? Amount { get; set; }

    public DateTime? PaymentDate { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual PosConfig? Config { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }
}