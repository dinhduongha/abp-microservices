using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class ResCountry
{
    public Guid Id { get; set; }

    public Guid? AddressViewId { get; set; }

    public long? CurrencyId { get; set; }

    public long? PhoneCode { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? Code { get; set; }

    public string? NamePosition { get; set; }

    public string? Name { get; set; }

    public string? VatLabel { get; set; }

    public string? AddressFormat { get; set; }

    public bool? StateRequired { get; set; }

    public bool? ZipRequired { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual IrUiView? AddressView { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
